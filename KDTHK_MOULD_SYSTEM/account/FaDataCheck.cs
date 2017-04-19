using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.output;
using CustomUtil.utils.buffer;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaDataCheck : UserControl
    {
        DataTable table = null;

        public FaDataCheck()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvDataCheck, true);

            this.LoadData("");

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnDelete.Enabled = dgvDataCheck.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string source)
        {
            table = new DataTable();
            string[] headers = { "app", "apptype", "pdf", "assetclass", "fa", "desc", "mpa", "chaseno", "id" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select f_apptype, f_pdfid, f_assetclass, f_fixedasset, f_desc, f_mpa, f_chaseno, f_id from TB_FA_APPROVAL where f_status = 'Data Check'" +
                " and (f_status like '%{0}%' or f_pdfid like '%{0}%' or f_assetclass like '%{0}%' or f_fixedasset like '%{0}%' or f_desc like '%{0}%' or f_mpa like '%{0}%')", source);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string type = GlobalService.Reader.GetString(0);
                    string pdf = GlobalService.Reader.GetString(1);
                    string asset = GlobalService.Reader.GetString(2);
                    string fa = GlobalService.Reader.GetString(3);
                    string desc = GlobalService.Reader.GetString(4);
                    string mpa = GlobalService.Reader.GetString(5);
                    string chaseno = GlobalService.Reader.GetString(6);
                    int id = GlobalService.Reader.GetInt32(7);

                    table.Rows.Add("Please select", type, pdf, asset, fa, desc, mpa, chaseno, id);
                }
            }

            dgvDataCheck.DataSource = table;

            lblCount.Text = "Total: " + table.Rows.Count;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            ExcelUtil.SaveExcel(table, "FA Data Check");
        }

        private void dgvDataCheck_SelectionChanged(object sender, EventArgs e)
        {
            SetText("Selected: " + dgvDataCheck.SelectedRows.Count);
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

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        private void tstxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(tstxtSearch.Text);
        }

        private void dgvDataCheck_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDataCheck.SortOrder.ToString() == "Descending")
                table.DefaultView.Sort = dgvDataCheck.SortedColumn.DataPropertyName.ToString() + " DESC";
            else
                table.DefaultView.Sort = dgvDataCheck.SortedColumn.DataPropertyName.ToString() + " ASC";

            table = table.DefaultView.ToTable();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvDataCheck.SelectedRows)
                    {
                        string chaseno = row.Cells[7].Value.ToString();
                        AccountUtil.DeleteRecord(chaseno);
                    }
                    MessageBox.Show("Record has been deleted.");
                    LoadData(tstxtSearch.Text);
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDataCheck.Rows)
                row.Cells[0].Value = "Approve";
        }

        private void tsbtnReject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDataCheck.Rows)
                row.Cells[0].Value = "Reject";
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            dgvDataCheck.EndEdit();

            foreach (DataGridViewRow row in dgvDataCheck.Rows)
            {
                string approval = row.Cells[0].Value.ToString();
                string id = row.Cells[8].Value.ToString();

                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                if (approval == "Reject")
                {
                    string text = string.Format("update TB_FA_APPROVAL set f_status = 'Fixed Asset Input', f_fixedasset = '', f_cm1stapp = '---', f_cm1stdate = '---', f_cm2ndapp = 'Reject'" +
                    " where f_id = '{0}'", id);
                    DataService.GetInstance().ExecuteNonQuery(text);
                }

                if (approval != "Approve")
                    continue;

                string query = string.Format("update TB_FA_APPROVAL set f_status = 'Final Approval', f_cm2ndapp = 'Approve'" +
                    ", f_cm2nddate = '{0}' where f_id = '{1}'", now, id);
                DataService.GetInstance().ExecuteNonQuery(query);
            }

            this.LoadData("");
        }

        private void tstxtSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
