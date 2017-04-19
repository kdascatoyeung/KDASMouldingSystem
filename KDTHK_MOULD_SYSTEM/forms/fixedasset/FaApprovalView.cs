using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.authentication;
using KDTHK_MOULD_SYSTEM.services;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.forms.fixedasset
{
    public partial class FaApprovalView : UserControl
    {
        //const string ipo1st = "Poon Nga Wai(潘雅慧,Anna)";
        const string ipo1st = "Ho Kin Hang(何健恒,Ken)";
        const string ipo2nd = "Cheng Chong Wah(鄭創華)";

        string user = "";
        public FaApprovalView()
        {
            InitializeComponent();

            user = AdUtil.getUsername("kmhk.local");

            this.LoadData();

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnApproveAll.Enabled = dgvApproval.Rows.Count > 0 ? true : false;
        }

        private void LoadData()
        {
            dgvApproval.Rows.Clear();

            string aStatus = user == ipo1st ? "IPO 1st Approval"
                : user == ipo2nd ? "IPO 2nd Approval" : "";

            string query = string.Format("select f_type, mm_chaseno, mm_vendorcode, mv_name, mm_mouldno" +
                ", mm_itemcode, mm_rev, mm_model, mm_currency, mm_amounthkd, f_status, f_attachment" +
                " from TB_MOULD_MAIN, TB_FA_APPROVAL, TB_MASTER_VENDOR where mm_pdfid = f_pdfid" +
                " and mm_vendorcode = mv_code and f_status = '{0}'", aStatus);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string type = GlobalService.Reader.GetString(0);
                    string chaseNo = GlobalService.Reader.GetString(1);
                    string vendor = GlobalService.Reader.GetString(2);
                    string vendorName = GlobalService.Reader.GetString(3);
                    string mouldNo = GlobalService.Reader.GetString(4);
                    string partNo = GlobalService.Reader.GetString(5);
                    string rev = GlobalService.Reader.GetString(6);
                    string model = GlobalService.Reader.GetString(7);
                    string currency = GlobalService.Reader.GetString(8);
                    string amountHkd = GlobalService.Reader.GetString(9);
                    string status = GlobalService.Reader.GetString(10);
                    string attachment = GlobalService.Reader.GetString(11);
                    string link = attachment != "" ? "Attachment" : "None";

                    dgvApproval.Rows.Add(type, status, chaseNo, vendor, vendorName, mouldNo, partNo, rev, model, currency, amountHkd, link, attachment);
                }
            }
        }

        private void dgvApproval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = dgvApproval.CurrentRow.Cells[0].Value.ToString();
            string chaseNo = dgvApproval.CurrentRow.Cells[1].Value.ToString();
            string path = dgvApproval.CurrentRow.Cells[12].Value.ToString();

            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            if (e.ColumnIndex == 11)
            {
                if (path == "")
                    return;

                Process.Start(path);
            }

            if (e.ColumnIndex == 13)
            {
                switch (status)
                {
                    case "IPO 1st Approval":

                        string q1st = string.Format("update TB_FA_APPROVAL set f_status = '{0}', f_ipo1stapp = '{1}', f_ipo1stdate = '{2}'" +
                            " where f_chaseno = '{3}'", "IPO 2nd Approval", "Approve", now, chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(q1st);

                        break;

                    case "IPO 2nd Approval":

                        string q2nd = string.Format("update TB_FA_APPROVAL set f_status = '{0}', f_ipo2ndapp = '{1}', f_ipo2nddate = '{2}'" +
                            " where f_chaseno = '{3}'", "CM 1st Approval", "Approve", now, chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(q2nd);

                        break;
                }

                this.LoadData();
            }

            if (e.ColumnIndex == 14)
            {
                switch (status)
                {
                    case "IPO 1st Approval":

                        string q1st = string.Format("update TB_FA_APPROVAL set f_ipo1stapp = '{0}', f_ipo1stdate = '{1}'" +
                            " where f_chaseno = '{2}'", "Reject", now, chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(q1st);

                        break;

                    case "IPO 2nd Approval":

                        string q2nd = string.Format("update TB_FA_APPROVAL set f_status = '{0}', f_ipo2ndapp = '{1}', f_ipo2nddate = '{2}'" +
                            " where f_chaseno = '{3}'", "IPO 1st Approval", "Reject", now, chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(q2nd);

                        break;
                }

                this.LoadData();
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void tsbtnApproveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApproval.Rows)
            {
                string status = row.Cells[0].Value.ToString();
                string chaseNo = row.Cells[1].Value.ToString();

                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                switch (status)
                {
                    case "IPO 1st Approval":

                        string q1st = string.Format("update TB_FA_APPROVAL set f_status = '{0}', f_ipo1stapp = '{1}', f_ipo1stdate = '{2}'" +
                            " where f_chaseno = '{3}'", "IPO 2nd Approval", "Approve", now, chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(q1st);

                        break;

                    case "IPO 2nd Approval":

                        string q2nd = string.Format("update TB_FA_APPROVAL set f_status = '{0}', f_ipo2ndapp = '{1}', f_ipo2nddate = '{2}'" +
                            " where f_chaseno = '{3}'", "CM 1st Approval", "Approve", now, chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(q2nd);

                        break;
                }
            }
        }
    }
}
