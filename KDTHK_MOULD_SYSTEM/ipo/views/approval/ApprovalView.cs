using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.utils;

namespace KDTHK_MOULD_SYSTEM.ipo.views.approval
{
    public partial class ApprovalView : UserControl
    {
        public ApprovalView()
        {
            InitializeComponent();

            LoadData();

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            toolStrip1.Enabled = dgvApproval.Rows.Count > 0 ? true : false;
        }

        private void LoadData()
        {
            dgvApproval.Rows.Clear();

            string status = GlobalService.Owner == GlobalService.IPO1st ? "IPO 1st Approval" : GlobalService.Owner == GlobalService.IPO2nd ? "IPO 2nd Approval" : "";

            string query = string.Format("select m_chaseno, m_itemtext, m_itemcode, m_ringi, m_vendor, mv_name" +
                " from TB_MOULD_MAIN, TB_MASTER_VENDOR, TB_FA_APPROVAL where m_vendor = mv_code" +
                " and m_pdfid = f_pdfid and f_status = '{0}'", status);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string chaseno = reader.GetString(0);
                    string itemtext = reader.GetString(1);
                    string itemcode = reader.GetString(2);
                    string ringi = reader.GetString(3);
                    string vendor = reader.GetString(4);
                    string vendorname = reader.GetString(5);

                    vendor = vendor + "  " + vendorname;

                    dgvApproval.Rows.Add("---", chaseno, itemtext, itemcode, ringi, vendor);
                }
            }
        }

        private void btnApproveAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApproval.Rows)
                row.Cells[0].Value = "Approve";
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApproval.Rows)
                row.Cells[0].Value = "Reject";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvApproval.Rows)
            {
                string approval = row.Cells[0].Value.ToString().Trim();

                if (approval == "---")
                    continue;

                string chaseno = row.Cells[1].Value.ToString().Trim();

                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                string query = "";

                if (GlobalService.Owner == GlobalService.IPO1st)
                {
                    if (approval == "Approve")
                    {
                        query = string.Format("update TB_FA_APPROVAL set f_status = '{0}', f_ipo1stapp = '{1}', f_ipo1stdate = '{2}'" +
                       " where f_chaseno = '{3}'", "IPO 2nd Approval", "Approve", now, chaseno);

                        EmailUtil.SendEmail("ken.ho@dthk.kyocera.com", "ken.ho@dthk.kyocera.com", "Fixed Asset Application Approval");
                    }
                    else
                    {
                        query = string.Format("delete from TB_FA_APPROVAL where f_chaseno = '{0}'", chaseno);

                        RejectStatus(chaseno);
                    }
                }
                else
                {
                    if (approval == "Approve")
                        query = string.Format("update TB_FA_APPROVAL set f_status = '{0}', f_ipo2ndapp = '{1}', f_ipo2nddate = '{2}'" +
                       " where f_chaseno = '{3}'", "Ringi Approval", "Approve", now, chaseno);
                    else
                    {
                        query = string.Format("delete from TB_FA_APPROVAL where f_chaseno = '{0}'", chaseno);

                        RejectStatus(chaseno);
                    }
                }

                DataService.GetInstance().ExecuteNonQuery(query);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RejectStatus(string chaseno)
        {
            string backText = string.Format("update tb_betamould set tm_st_code = 'F' where tm_chaseno = '{0}'", chaseno);
            DataServiceMould.GetInstance().ExecuteNonQuery(backText);
        }
    }
}
