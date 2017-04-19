using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.export;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaAssetClass : UserControl
    {
        public FaAssetClass()
        {
            InitializeComponent();

            this.LoadData();
        }


        private void LoadData()
        {
            dgvInput.Rows.Clear();
            string query = "select f_applicant, f_mould, f_pdfid, f_desc, f_mpa, f_attachment, f_ringi, f_chaseno, f_assetclass, f_downloaded, f_cm2ndapp, f_costcenter"+
                ", f_resp, f_location, f_assetdesc from TB_FA_APPROVAL where f_status = 'CM 1st Approval 1'";

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string applicant = GlobalService.Reader.GetString(0);
                    string mould = GlobalService.Reader.GetString(1);
                    string pdfid = GlobalService.Reader.GetString(2);
                    string desc = GlobalService.Reader.GetString(3);
                    string mpa = GlobalService.Reader.GetString(4);
                    string attachment = GlobalService.Reader.GetString(5);
                    string ringi = GlobalService.Reader.GetString(6);
                    string chaseNo = GlobalService.Reader.GetString(7);
                    string assetClass = GlobalService.Reader.GetString(8);
                    string ac = assetClass == "" ? "Please select" : assetClass;
                    string downloaded = GlobalService.Reader.GetString(9);
                    string approval = GlobalService.Reader.GetString(10);
                    string app = approval == "---" ? "Please select" : approval;
                    string costCenter = GlobalService.Reader.GetString(11);
                    string resp = GlobalService.Reader.GetString(12);
                    string location = GlobalService.Reader.GetString(13);
                    string assetDesc = GlobalService.Reader.GetString(14);

                    dgvInput.Rows.Add(app, downloaded, ac, applicant, mould, pdfid, desc, mpa, costCenter, resp, location, ringi, "Attachment", assetDesc, attachment, chaseNo);
                }
            }
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
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
                string assetClass = row.Cells[2].Value.ToString();

                if (approval != "Approve")
                    continue;
                if (assetClass == "Please select")
                    continue;

                string chaseNo = row.Cells[15].Value.ToString();
                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                string query = string.Format("update TB_FA_APPROVAL set f_assetclass = '{0}', f_cm2ndapp = 'Approve'" +
                    ", f_cm2nddate = '{1}', f_status = 'CM 2nd Approval' where f_chaseno = '{2}' and f_status = 'CM 1st Approval 1'", assetClass, now, chaseNo);

                Debug.WriteLine("Query: " + query);
                DataService.GetInstance().ExecuteNonQuery(query);
            }

            this.LoadData();
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = new DataTable();
            string[] headers = {"Serial No.", "Type of Creation", "Asset Class", "Company Code", "Number of similar assets",
                                   "x01", "x02", "x03", "x04", "x05", "x06", "Description", "Additional asset description", "x07", "x08",
                                   "x09", "x10", "x11", "Managed historically", "x12", "Inventory indicator", "Inventory note", "x13",
                                   "x14", "Cost center", "Resp. cost center", "x15", "Location", "x16", "License plate number", "x17",
                                   "x18", "x19", "x20", "x21", "Evalutation group 5", "x22", "x23", "x24", "x25", "Asset purchased new",
                                   "x26", "x27", "x28", "Type name", "x29", "x30", "x31", "x32", "x33", "Depreciation key(01)", "Useful life(01)",
                                   "x34", "x35", "x36", "x37", "Depreciation key(02)", "Useful life(02)"};
            foreach (string header in headers)
                output.Columns.Add(header);

            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                string approval = row.Cells[0].Value.ToString();
                string assetClass = row.Cells[1].Value.ToString();

                if (approval != "Approve")
                    continue;
                if (assetClass == "Please select")
                    continue;

                string chaseNo = row.Cells[14].Value.ToString();

                string query = string.Format("update TB_FA_APPROVAL set f_status = 'CM 1st Approval 2', f_downloaded = 'Yes' where f_chaseno = '{0}'", chaseNo);
                DataService.GetInstance().ExecuteNonQuery(query);

                string text = string.Format("select f_assetclass, f_desc, f_assetdesc, f_costcenter, f_resp, f_location, f_vendor, f_ringi from TB_FA_APPROVAL where f_status = 'CM 1st Approval 2' and f_chaseno = '{0}'", chaseNo);

                using (IDataReader reader = DataService.GetInstance().ExecuteReader(text))
                {
                    while (reader.Read())
                    {
                        string ac = reader.GetString(0);
                        string desc = reader.GetString(1);
                        string ad = reader.GetString(2);
                        string costcenter = reader.GetString(3);
                        string resp = reader.GetString(4);
                        string location = reader.GetString(5);
                        string vendor = reader.GetString(6);
                        string ringi = reader.GetString(7);
                        string itemcode = desc.Substring(1);
                        itemcode = itemcode.Substring(0, 10);

                        output.Rows.Add("1", "10", ac, "1404", "1", "", "", "", "", "", "", desc, ad, "", "", "", "", "", "X", "", "X", itemcode, "", "", costcenter, resp, "", location, "", vendor, "", "", "", "", "", "00000", "", "", "", "", "X", "", "", "", ringi, "", "", "", "", "", "HE06", "6", "", "", "", "", "ME06", "6");
                    }
                }
            }

            if (output.Rows.Count > 0)
            {
                ExportTextUtil.ExportText(output, "Fa Upload");
                this.LoadData();
            }
            else
                MessageBox.Show("No record can be downloaded.");
        }

        private void dgvInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12)
                Process.Start(dgvInput.CurrentRow.Cells[14].Value.ToString());
        }

        private void dgvInput_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
        }
    }
}
