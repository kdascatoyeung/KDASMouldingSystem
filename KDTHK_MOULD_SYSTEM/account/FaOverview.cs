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
using KDTHK_MOULD_SYSTEM.output;
using CustomUtil.utils.buffer;
using System.IO;
using System.Diagnostics;
using KDTHK_MOULD_SYSTEM.account.lists;
using KDTHK_MOULD_SYSTEM.utils;
using CustomUtil.utils.import;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaOverview : UserControl
    {
        DataTable table = null;

        public FaOverview()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvOverview, true);

            this.LoadData(tstxtSearch.Text);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnDelete.Enabled = dgvOverview.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string source)
        {
            //var dt = new DataTableReplacement();
            table = new DataTable();
            string[] headers = {"Type", "Request", "Created", "MgtNo", "Status", "Remarks", "ChaseNo", "AssetClass", "FA", "FARef", "Desc", "Mpa", "RingiApprover", "RingiApproval",
                                 "1stApprover", "1stApproval", "1stDate", "2ndApprover", "2ndApproval", "2ndDate", "3rdApprover", "3rdApproval", "3rdDate", "Vendor",
                               "Serial", "Creation", "Company", "SimilarAsset", "Managed", "Indicator", "Note", "CostCenter", "Resp", "Location",
                               "License", "Group", "Purchased", "TypeName", "Key01", "Life01", "Key02", "Life02"};
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select f_request, f_pdfid, f_status, f_fixedasset, f_partno, f_desc, f_mpa, f_vendor, f_ringi1stapp, f_ringi1st" +
                ", f_cm1stapp, f_cm1st, f_cm1stdate, f_cm2ndapp, f_cm2nd, f_cm2nddate, f_cm3rdapp, f_cm3rd, f_cm3rddate, f_applicant, f_assetclass"+
                ", f_costcenter, f_resp, f_location, f_ringi, f_apptype, f_chaseno, mv_name, f_remarks, f_faref from TB_FA_APPROVAL, TB_MASTER_VENDOR" +
                " where f_vendor = mv_code and f_ipo2ndapp = case f_apptype when 'Others' then '---' else 'Approve' end and (f_pdfid like '%{0}%' or f_assetclass like '%{0}%' or f_request like '%{0}%' or f_fixedasset like '%{0}%' or f_vendor like '%{0}%')", source);

            List<OverviewList> list = new List<OverviewList>();

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string request = GlobalService.Reader.GetString(0);
                    string pdf = GlobalService.Reader.GetString(1);
                    string status = GlobalService.Reader.GetString(2);
                    string fa = GlobalService.Reader.GetString(3);
                    string partno = GlobalService.Reader.GetString(4);
                    string desc = GlobalService.Reader.GetString(5);
                    string mpa = GlobalService.Reader.GetString(6);
                    string license = GlobalService.Reader.GetString(7);
                    string cm1stapp = GlobalService.Reader.GetString(8);
                    string cm1st = GlobalService.Reader.GetString(9);
                    string cm2ndapp = GlobalService.Reader.GetString(10);
                    string cm2nd = GlobalService.Reader.GetString(11);
                    string cm2nddate = GlobalService.Reader.GetString(12);
                    string cm3rdapp = GlobalService.Reader.GetString(13);
                    string cm3rd = GlobalService.Reader.GetString(14);
                    string cm3rddate = GlobalService.Reader.GetString(15);
                    string cm4thapp = GlobalService.Reader.GetString(16);
                    string cm4th = GlobalService.Reader.GetString(17);
                    string cm4thdate = GlobalService.Reader.GetString(18);
                    string applicant = GlobalService.Reader.GetString(19);
                    string assetclass = GlobalService.Reader.GetString(20);
                    string costcenter = GlobalService.Reader.GetString(21);
                    string resp = GlobalService.Reader.GetString(22);
                    string location = GlobalService.Reader.GetString(23);
                    string ringi = GlobalService.Reader.GetString(24);
                    string type = GlobalService.Reader.GetString(25);
                    string chaseno = GlobalService.Reader.GetString(26);
                    string vname = GlobalService.Reader.GetString(27);
                    string remarks = GlobalService.Reader.GetString(28);
                    string faRef = GlobalService.Reader.GetString(29);

                    string vendor = license + " " + vname;

                    string dkey1 = "", dkey2 = "", life1 = "", life2 = "";

                    if (assetclass == "Z4000")
                    {
                        dkey1 = dkey2 = "0000";
                        life1 = life2 = "1";
                    }
                    else if (assetclass == "Z1110" || assetclass == "Z1310" || assetclass == "Z2510" || assetclass == "Z2710")
                    {
                        dkey1 = "HM12";
                        dkey2 = "MM12";
                        life1 = life2 = "12";
                    }
                    else if (assetclass == "Z1120" || assetclass == "Z1320" || assetclass == "Z2520" || assetclass == "Z2720")
                    {
                        dkey1 = "HM20";
                        dkey2 = "MM20";
                        life1 = life2 = "20";
                    }
                    else if (assetclass == "Z1330" || assetclass == "Z1500" || assetclass == "Z1720" || assetclass == "Z2730" || assetclass == "Z3020")
                    {
                        dkey1 = "HM04";
                        dkey2 = "MM04";
                        life1 = life2 = "4";
                    }
                    else
                    {
                        dkey1 = "HE06"; 
                        life1 = "6"; 
                        dkey2 = "ME06"; 
                        life2 = "6";
                    }

                    table.Rows.Add(type, request, applicant, pdf, status, remarks, chaseno, assetclass, fa, faRef, desc, mpa, cm1st, cm1stapp, cm2nd, cm2ndapp, cm2nddate, cm3rd, cm3rdapp, cm3rddate, cm4th, cm4thapp, cm4thdate, vendor,
                        "1", "10", "1404", "1", "X", "X", partno, costcenter, resp, location, license, "00000", "X", ringi, dkey1, life1, dkey2, life2);
                }
            }
            dgvOverview.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(tstxtSearch.Text);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        DataTable _outputTable = new DataTable();

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            ExportTextUtil.ExportText(table, "FA Application");
        }

        private void dgvOverview_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvOverview.SortOrder.ToString() == "Descending")
                table.DefaultView.Sort = dgvOverview.SortedColumn.DataPropertyName.ToString() + " DESC";
            else
                table.DefaultView.Sort = dgvOverview.SortedColumn.DataPropertyName.ToString() + " ASC";

            table = table.DefaultView.ToTable();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvOverview.SelectedRows)
                    {
                        string status = row.Cells[4].Value.ToString();
                        string chaseno = row.Cells[6].Value.ToString();

                        if (status != "Ringi Approval")
                            AccountUtil.DeleteRecord(chaseno);
                    }
                    MessageBox.Show("Record has been deleted.");
                    LoadData(tstxtSearch.Text);
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string id = row.ItemArray[0].ToString().Trim();
                    string faref = row.ItemArray[3].ToString().Trim();

                    string query = string.Format("update TB_FA_APPROVAL set f_faref = '{0}' where f_id = '{1}'", faref, id);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }
    }
}
