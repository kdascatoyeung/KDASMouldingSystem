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
using CustomUtil.utils.buffer;
using CustomUtil.utils.export;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaReview : UserControl
    {
        DataTable outputTable = null;

        public FaReview()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvReviewer, true);

            this.LoadData("", "");

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            string reviewer = Load2ndApprover();

            tsbtnApprove.Enabled = dgvReviewer.Rows.Count > 0 && GlobalService.Owner == reviewer ? true : false;
            tsbtnSave.Enabled = dgvReviewer.Rows.Count > 0 && GlobalService.Owner == reviewer ? true : false;
            //tsbtnSave.Enabled = true; /*Added by Cato Yeung 2017/04/13 */
            tsbtnDelete.Enabled = dgvReviewer.SelectedRows.Count > 0 && GlobalService.Owner == reviewer ? true : false;
            tsbtnReject.Enabled = dgvReviewer.Rows.Count > 0 && GlobalService.Owner == reviewer ? true : false;
        }

        private void LoadData(string mgtno, string assetclass)
        {
            DataTable table = new DataTable();
            string[] headers = {"approval", "assetclass", "createdby", "mould", "pdfid", "desc", "mpa", "costcenter", "resp", "location", "ringi",
                                   "link", "assetdesc", "path", "chaseno", "id"};
            foreach (string header in headers)
                table.Columns.Add(header);

            outputTable = new DataTable();
            string[] oheaders = { "Asset Class", "Created By", "Mould", "Mgt No.", "Description", "MPA", "Cost Center", "Resp. Cost Center", "Location", "Ringi", "Additional Asset Description" };
            foreach (string header in oheaders)
                outputTable.Columns.Add(header);

            string query = string.Format("select f_assetclass, f_applicant, f_mould, f_pdfid, f_desc" +
                ", f_mpa, f_costcenter, f_resp, f_location, f_ringi, f_assetDesc, f_chaseno, f_attachment, f_id from TB_FA_APPROVAL" +
                " where f_status = 'Reviewer' and f_pdfid like '%{0}%' and f_assetclass like '%{1}%'", mgtno, assetclass, GlobalService.Owner);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string assetClass = GlobalService.Reader.GetString(0);
                    string applicant = GlobalService.Reader.GetString(1);
                    string mould = GlobalService.Reader.GetString(2);
                    string pdfid = GlobalService.Reader.GetString(3);
                    string desc = GlobalService.Reader.GetString(4);
                    string mpa = GlobalService.Reader.GetString(5);
                    string costcenter = GlobalService.Reader.GetString(6);
                    string resp = GlobalService.Reader.GetString(7);
                    string location = GlobalService.Reader.GetString(8);
                    string ringi = GlobalService.Reader.GetString(9);
                    string assetDesc = GlobalService.Reader.GetString(10);
                    string chaseNo = GlobalService.Reader.GetString(11);
                    string attachment = GlobalService.Reader.GetString(12);
                    int id = GlobalService.Reader.GetInt32(13);

                    table.Rows.Add("Please select", assetClass, applicant, mould, pdfid, desc, mpa,
                        costcenter, resp, location, ringi, "Attachment", assetDesc, attachment, chaseNo, id);

                    outputTable.Rows.Add(assetClass, applicant, mould, pdfid, desc, mpa, costcenter, resp, location, ringi, assetDesc);
                }
            }

            dgvReviewer.DataSource = table;

            lblCount.Text = "Total: " + dgvReviewer.Rows.Count;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            tstxtSearch.Clear();
            tstxtAssetClass.Clear();

            LoadData("", "");
        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReviewer.Rows)
                row.Cells[0].Value = "Approve";
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            dgvReviewer.EndEdit();

            foreach (DataGridViewRow row in dgvReviewer.Rows)
            {
                string approval = row.Cells[0].Value.ToString();
                string assetClass = row.Cells[1].Value.ToString();
                string id = row.Cells[15].Value.ToString();

                if (approval == "Reject")
                {
                    string text = string.Format("update TB_FA_APPROVAL set f_status = 'Asset Class Input', f_cm1stapp = '---', f_cm1stdate = '---'" +
                    " where f_id = '{0}'", id);
                    DataService.GetInstance().ExecuteNonQuery(text);
                }

                if (approval != "Approve")
                    continue;
                if (assetClass == "Please select")
                    continue;

                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                string query = string.Format("update TB_FA_APPROVAL set f_assetclass = '{0}'" +
                    ", f_status = 'Download Data', f_cm2ndapp = 'Approve', f_cm2nddate = '{1}' where f_id = '{2}'", assetClass, now, id);

                DataService.GetInstance().ExecuteNonQuery(query);
            }

            LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void dgvReviewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
                Process.Start(dgvReviewer.CurrentRow.Cells[13].Value.ToString());
        }

        private void dgvReviewer_SelectionChanged(object sender, EventArgs e)
        {
            SetText("Selected: " + dgvReviewer.SelectedRows.Count);
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
            if (e.KeyCode == Keys.Enter)
                LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void tsbtnReject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReviewer.Rows)
                row.Cells[0].Value = "Reject";
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvReviewer.SelectedRows)
                    {
                        string chaseno = row.Cells[14].Value.ToString();
                        AccountUtil.DeleteRecord(chaseno);
                    }
                    MessageBox.Show("Record has been deleted.");
                    LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void tstxtAssetClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData(tstxtSearch.Text, tstxtAssetClass.Text);
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            ExportTextUtil.ExportText(outputTable, "FA Record - Review");
        }

        private void dgvReviewer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvReviewer.SortOrder.ToString() == "Descending")
                outputTable.DefaultView.Sort = dgvReviewer.SortedColumn.DataPropertyName.ToString() + " DESC";
            else
                outputTable.DefaultView.Sort = dgvReviewer.SortedColumn.DataPropertyName.ToString() + " ASC";

            outputTable = outputTable.DefaultView.ToTable();
        }

        private string Load2ndApprover()
        {
            string query = "select a_name from TB_APPROVER where a_id = 2";
            return DataService.GetInstance().ExecuteScalar(query).ToString().Trim();
        }
    }
}
