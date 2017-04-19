using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.buffer;
using KDTHK_MOULD_SYSTEM.account.form;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaApproval : UserControl
    {
        public FaApproval()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvApproval, true);

            this.LoadData("");

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnApprove.Enabled = dgvApproval.Rows.Count > 0 ? true : false;
            tsbtnSave.Enabled = dgvApproval.Rows.Count > 0 ? true : false;
            tsbtnDelete.Enabled = dgvApproval.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();
            string[] headers = { "approval", "assetclass", "fa", "apptype", "pdfid", "desc", "mpa", "link", "path", "chaseno", "id" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select f_pdfid, f_desc, f_mpa, f_assetclass, f_attachment, f_fixedasset, f_apptype, f_id, f_chaseno from TB_FA_APPROVAL where f_status = 'Final Approval'" +
                " and f_cm3rd = N'{1}' and (f_status like '%{0}%' or f_pdfid like '%{0}%' or f_assetclass like '%{0}%' or f_desc like '%{0}%' or f_mpa like '%{0}%')", source, GlobalService.Owner);
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string mgtno = GlobalService.Reader.GetString(0);
                    string desc = GlobalService.Reader.GetString(1);
                    string mpa = GlobalService.Reader.GetString(2);
                    string assetClass = GlobalService.Reader.GetString(3);
                    string attachment = GlobalService.Reader.GetString(4);
                    string fixedAsset = GlobalService.Reader.GetString(5);
                    string type = GlobalService.Reader.GetString(6);
                    int id = GlobalService.Reader.GetInt32(7);
                    string chaseno = GlobalService.Reader.GetString(8);

                    table.Rows.Add("Please select", assetClass, fixedAsset, type, mgtno, desc, mpa, "Attachment", attachment, chaseno, id);
                }
            }

            dgvApproval.DataSource = table;

            lblCount.Text = "Total: " + dgvApproval.Rows.Count;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData("");
        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApproval.Rows)
                row.Cells[0].Value = "Approve";
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            dgvApproval.EndEdit();

            List<string> list = new List<string>();

            foreach (DataGridViewRow row in dgvApproval.Rows)
            {
                string approval = row.Cells[0].Value.ToString();
                string assetClass = row.Cells[1].Value.ToString();
                string fixedAsset = row.Cells[2].Value.ToString();

                string chaseno = row.Cells[9].Value.ToString();
                string id = row.Cells[10].Value.ToString();

                if (approval == "Reject")
                {
                    list.Add(id);
                    continue;
                }

                if (approval != "Approve")
                    continue;
                if (assetClass == "")
                    continue;
                if (fixedAsset == "")
                    continue;

                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                string query = string.Format("update TB_FA_APPROVAL set f_status = 'Finished', f_fixedasset = '{0}'" +
                    ", f_assetclass = '{1}', f_cm3rdapp = '{2}', f_cm3rddate = '{3}' where f_id = '{4}'",
                    fixedAsset, assetClass, "Approve", now, id);
                DataService.GetInstance().ExecuteNonQuery(query);

                string mainQuery = "";

                if (fixedAsset.StartsWith("4"))
                    mainQuery = string.Format("update tb_betamould set tm_tmpfixedassetcode = '{0}' where tm_chaseno = '{1}'", fixedAsset, chaseno);
                else
                    mainQuery = string.Format("update tb_betamould set tm_fixedassetcode = '{0}' where tm_chaseno = '{1}'", fixedAsset, chaseno);

                DataServiceMould.GetInstance().ExecuteNonQuery(mainQuery);

                CheckStatus(chaseno);
            }

            if (list.Count > 0)
            {
                RejectForm form = new RejectForm(list);
                form.ShowDialog();
            }

            this.LoadData("");
        }

        private void CheckStatus(string chaseno)
        {
            List<string> list = new List<string>();
            string q1 = string.Format("select f_mpa from TB_FA_APPROVAL where f_chaseno = '{0}'", chaseno);
            using (IDataReader reader = DataService.GetInstance().ExecuteReader(q1))
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }

            if (list.Count == 1)
            {
                string st = IsTransfer(chaseno) ? "T" : "U";

                string query = string.Format("update tb_betamould set tm_st_code = '{0}' where tm_chaseno = '{1}'", st, chaseno.Trim());
                DataServiceMould.GetInstance().ExecuteNonQuery(query);
            }
            else
            {
                if (IsNormalInput(chaseno) && IsTempInput(chaseno))
                {
                    string query = string.Format("update tb_betamould set tm_st_code = 'U' where tm_chaseno = '{0}'", chaseno);
                    DataServiceMould.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private bool IsTransfer(string chaseno)
        {
            string query = string.Format("select tm_status from tb_betamould where tm_chaseno = '{0}'", chaseno);
            string result = DataServiceMould.GetInstance().ExecuteScalar(query).ToString().Trim();
            if (result == "TM")
                return true;

            return false;
        }

        private bool IsNormalInput(string chaseno)
        {
            string query = string.Format("select count(*) from TB_FA_APPROVAL where f_fixedasset != '' and f_status = 'Finished' and f_mpa != 'Temp' and f_chaseno = '{0}'", chaseno);
            int result = (int)DataService.GetInstance().ExecuteScalar(query);
            if (result == 0)
                return false;

            return true;
        }

        private bool IsTempInput(string chaseno)
        {
            string query = string.Format("select count(*) from TB_FA_APPROVAL where f_fixedasset != '' and f_status = 'Finished' and f_mpa = 'Temp' and f_chaseno = '{0}'", chaseno);
            int result = (int)DataService.GetInstance().ExecuteScalar(query);
            if (result == 0)
                return false;

            return true;
        }

        private void dgvInput_SelectionChanged(object sender, EventArgs e)
        {
            SetText("Selected: " + dgvApproval.SelectedRows.Count);
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

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvApproval.SelectedRows)
                    {
                        string chaseno = row.Cells[6].Value.ToString();
                        AccountUtil.DeleteRecord(chaseno);
                    }
                    MessageBox.Show("Record has been deleted.");
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void tsbtnReject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApproval.Rows)
                row.Cells[0].Value = "Reject";
        }

        private void tstxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData(tstxtSearch.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            LoadData(tstxtSearch.Text);
        }
    }
}
