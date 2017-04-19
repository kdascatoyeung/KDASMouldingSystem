using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using System.Diagnostics;
using KDTHK_MOULD_SYSTEM.account.form;
using CustomUtil.utils.buffer;
using CustomUtil.utils.export;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaAssetClass2 : UserControl
    {
        string[] _AssetClass = {"Z1110","Z1120","Z1310","Z1320","Z1330","Z1400","Z1500","Z1600","Z1710","Z1720","Z2510","Z2520","Z2710"
                                                ,"Z2720","Z2730","Z2800","Z2900","Z3010","Z3020","Z4000","Z4200"};

        DataTable outputTable = null;

        public FaAssetClass2()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvInput, true);

            this.LoadData(tstxtSearch.Text, tstxtAssetClass.Text);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnDelete.Enabled = dgvInput.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string mgtno, string assetclass)
        {
            DataTable table = new DataTable();
            string[] headers = {"approval", "AssetClass", "CreatedBy", "Mould", "MgtNo", "Description", "MPA", "CostCenter", "RespCostCenter", "Location", "Ringi", "link",
                                   "AdditionalAssetDescription", "path", "id", "chaseno"};
            foreach (string header in headers)
                table.Columns.Add(header);

            outputTable = new DataTable();
            string[] oheaders = { "AssetClass", "CreatedBy", "Mould", "MgtNo", "Description", "MPA", "CostCenter", "RespCostCenter", "Location", "Ringi", "AdditionalAssetDescription" };
            foreach (string header in oheaders)
                outputTable.Columns.Add(header);

            string query = string.Format("select f_applicant, f_mould, f_pdfid, f_desc, f_mpa, f_attachment, f_ringi, f_id, f_assetclass, f_cm1stapp, f_costcenter" +
                ", f_resp, f_location, f_assetdesc, f_chaseno, f_request from TB_FA_APPROVAL where f_status = 'Asset Class Input' and f_pdfid like '%{0}%' and f_assetclass like '%{1}%' order by f_mould", mgtno, assetclass);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string applicant = reader.GetString(0);
                    string mould = reader.GetString(1);
                    string pdfid = reader.GetString(2);
                    string desc = reader.GetString(3);
                    string mpa = reader.GetString(4);
                    string attachment = reader.GetString(5);
                    string ringi = reader.GetString(6);
                    int id = reader.GetInt32(7);
                    string assetClass = reader.GetString(8);
                    string ac = assetClass == "" ? "Please select" : assetClass;
                    string approval = reader.GetString(9);
                    string app = approval == "---" ? "Please select" : approval;
                    string costCenter = reader.GetString(10);
                    string resp = reader.GetString(11);
                    string location = reader.GetString(12);
                    string assetDesc = reader.GetString(13);
                    string chaseno = reader.GetString(14);
                    /* Start of Added by Cato Yeung 2017/04/13 */
                    //DateTime request = Convert.ToDateTime(reader.GetString(15));
                    //if (!(request >= Convert.ToDateTime("2017/04/13"))) continue;
                    /* End of Added by Cato Yeung 2017/04/13 */

                    table.Rows.Add(app, ac, applicant, mould, pdfid, desc, mpa, costCenter, resp, location, ringi, "Attachment", assetDesc, attachment, id, chaseno);
                    outputTable.Rows.Add(ac, applicant, mould, pdfid, desc, mpa, costCenter, resp, location, ringi, assetDesc);
                }
            }

            dgvInput.DataSource = table;

            lblCount.Text = "Total: " + dgvInput.Rows.Count;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            tstxtSearch.Clear();
            tstxtAssetClass.Clear();

            this.LoadData("", "");
        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInput.Rows)
                row.Cells[0].Value = "Approve";
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            dgvInput.EndEdit();

            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                string approval = row.Cells[0].Value.ToString();
                string assetClass = row.Cells[1].Value.ToString();

                if (approval != "Approve")
                    continue;
                if (assetClass == "Please select")
                    continue;

                string id = row.Cells[14].Value.ToString();
                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                string query = string.Format("update TB_FA_APPROVAL set f_assetclass = '{0}', f_cm1stapp = 'Approve'" +
                    ", f_cm1stdate = '{1}', f_status = 'Reviewer' where f_id = '{2}' and f_status = 'Asset Class Input'", assetClass, now, id);

                DataService.GetInstance().ExecuteNonQuery(query);
            }

            this.LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void dgvInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                Debug.WriteLine(dgvInput.CurrentRow.Cells[13].Value.ToString());
                Process.Start(dgvInput.CurrentRow.Cells[13].Value.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tstxtAssetClass.Text == "" || !_AssetClass.Contains(tstxtAssetClass.Text))
            {
                MessageBox.Show("Please input valid Asset Class");
                return;
            }

            foreach (DataGridViewRow row in dgvInput.Rows)
                row.Cells[1].Value = tstxtAssetClass.Text;
        }

        private void tstxtAssetClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void dgvInput_SelectionChanged(object sender, EventArgs e)
        {
            SetText("Selected: " + dgvInput.SelectedRows.Count);
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback callback = new SetTextCallback(SetText);
                this.Invoke(callback, new object[] { text });
            }
            else
                lblSelected.Text = text;
        }

        private void tstxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                this.LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvInput.SelectedRows)
                    {
                        string chaseno = row.Cells[15].Value.ToString();
                        AccountUtil.DeleteRecord(chaseno);
                    }
                    MessageBox.Show("Delete Operation successful.");
                    LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            ExportTextUtil.ExportText(outputTable, "FA Record - Asset Class");
        }

        private void dgvInput_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 0 && e.ColumnIndex != 1)
                {
                    if (dgvInput.SortOrder.ToString() == "Descending")
                        outputTable.DefaultView.Sort = dgvInput.SortedColumn.DataPropertyName.ToString() + " DESC";
                    else
                        outputTable.DefaultView.Sort = dgvInput.SortedColumn.DataPropertyName.ToString() + " ASC";

                    outputTable = outputTable.DefaultView.ToTable();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
        }

        private void dgvInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvInput.Rows.Count > 0)
            {
                if (((dgvInput.Rows[0].Height * dgvInput.Rows.Count) + dgvInput.ColumnHeadersHeight) < e.Location.Y)
                    dgvInput.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvInput.HitTest(e.X, e.Y);

                        if (dgvInput.SelectedRows.Count == 1)
                        {
                            dgvInput.ClearSelection();

                            if (((dgvInput.Rows[0].Height * dgvInput.Rows.Count) + dgvInput.ColumnHeadersHeight) >= e.Location.Y)
                                dgvInput.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvInput.Rows[0].Height * dgvInput.Rows.Count) + dgvInput.ColumnHeadersHeight) >= e.Location.Y)
                                dgvInput.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInput.SelectedRows)
                row.Cells[0].Value = "Approve";
        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInput.SelectedRows)
                row.Cells[0].Value = "Reject";
        }
    }
}
