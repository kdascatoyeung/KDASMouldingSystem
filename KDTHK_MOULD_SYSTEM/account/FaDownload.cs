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
using CustomUtil.utils.buffer;
using System.IO;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaDownload : UserControl
    {
        DataTable output = null;

        public FaDownload()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvDownload, true);

            this.LoadData("");

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnDelete.Enabled = dgvDownload.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string source)
        {
            output = new DataTable();
            string[] headers = {"Serial No.", "Type of Creation", "Asset Class", "Company Code", "Number of similar assets",
                                   "x01", "x02", "x03", "x04", "x05", "x06", "Description", "Additional asset description", "x07", "x08",
                                   "x09", "x10", "x11", "Managed historically", "x12", "Inventory indicator", "Inventory note", "x13",
                                   "x14", "Cost center", "Resp. cost center", "x15", "Location", "x16", "License plate number", "x17",
                                   "x18", "x19", "x20", "x21", "Evalutation group 5", "x22", "x23", "x24", "x25", "Asset purchased new",
                                   "x26", "x27", "x28", "Type name", "x29", "x30", "x31", "x32", "x33", "Depreciation key(01)", "Useful life(01)",
                                   "x34", "x35", "x36", "x37", "Depreciation key(02)", "Useful life(02)"};
            foreach (string header in headers)
                output.Columns.Add(header);

            DataTable table = new DataTable();
            string[] headerss = {"apptype", "serial", "creation", "assetclass", "company", "similar",
                                   "x01", "x02", "x03", "x04", "x05", "x06", "description", "additional", "x07", "x08",
                                   "x09", "x10", "x11", "managed", "x12", "indicator", "note", "x13",
                                   "x14", "costcenter", "resp", "x15", "location", "x16", "license", "x17",
                                   "x18", "x19", "x20", "x21", "evaluation", "x22", "x23", "x24", "x25", "purchased",
                                   "x26", "x27", "x28", "typename", "x29", "x30", "x31", "x32", "x33", "key01", "life01",
                                   "x34", "x35", "x36", "x37", "key02", "life02", "id", "chaseno"};
            foreach (string header in headerss)
                table.Columns.Add(header);

            string text = string.Format("select f_assetclass, f_desc, f_assetdesc, f_costcenter, f_resp, f_location, f_vendor, f_ringi, f_id, f_apptype, f_chaseno, f_partno from TB_FA_APPROVAL where (f_status = 'Download Data' or f_status = 'Fixed Asset Input')"+
                " and (f_assetclass like '%{0}%' or f_desc like '%{0}%' or f_assetdesc like '%{0}%')", source);

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
                    string itemcode = reader.GetString(11);
                    int id = reader.GetInt32(8);
                    string apptype = reader.GetString(9);
                    string chaseno = reader.GetString(10);

                    string key01 = "", key02 = "", life01 = "", life02 = "";

                    if (ac == "Z1110" || ac == "Z1310" || ac == "Z2510" || ac == "Z2710")
                    {
                        life01 = life02 = "12";
                        key01 = "HM12";
                        key02 = "MM12";
                    }
                    else if (ac == "Z1120" || ac == "Z1320" || ac == "Z2520" || ac == "Z2720")
                    {
                        life01 = life02 = "20";
                        key01 = "HM20";
                        key02 = "MM20";
                    }
                    else if (ac == "Z1330" || ac == "Z1500" || ac == "Z1720" || ac == "Z2730" || ac == "Z2900" || ac == "Z3020")
                    {
                        life01 = life02 = "4";
                        key01 = "HM04";
                        key02 = "MM04";
                    }
                    else if (ac == "Z4000" || ac == "Z4200")
                    {
                        life01 = life02 = "1";
                        key01 = key02 = "0000";
                    }
                    else
                    {
                        life01 = life02 = "6";
                        key01 = "HE06";
                        key02 = "ME06";
                    }

                    table.Rows.Add(apptype, "1", "10", ac, "1404", "1", "", "", "", "", "", "", desc, ad, "", "", "", "", "", "X", "", "X", itemcode, "", "", costcenter, resp, "", location, "", vendor, "", "", "", "", "", "00000", "", "", "", "", "X", "", "", "", ringi, "", "", "", "", "", key01, life01, "", "", "", "", key02, life02, id, chaseno);
                    output.Rows.Add("1", "10", ac, "1404", "1", "", "", "", "", "", "", desc, ad, "", "", "", "", "", "X", "", "X", itemcode, "", "", costcenter, resp, "", location, "", vendor, "", "", "", "", "", "00000", "", "", "", "", "X", "", "", "", ringi, "", "", "", "", "", key01, life01, "", "", "", "", key02, life02);
                }
            }

            dgvDownload.DataSource = table;

            lblCount.Text = "Total: " + table.Rows.Count;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            if (output.Rows.Count > 0)
            {
                string apptype = dgvDownload.Rows[0].Cells[0].Value.ToString();
                string assetclass = dgvDownload.Rows[0].Cells[3].Value.ToString();

                string file;

                string tmpfile = assetclass == "Z1600" ? "mould_" : assetclass == "Z4000" ? "cip_" : assetclass == "Z1710" || assetclass == "Z1720" ? "jig_" : "others_";

                SaveFileDialog sfd = new SaveFileDialog()
                {
                    DefaultExt = "txt",
                    Filter = "Text Files (*.txt)|*.txt",
                    FilterIndex = 1,
                    FileName = tmpfile + DateTime.Now.ToString("yyyy_MM_dd_HHmm")
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                foreach (DataGridViewRow row in dgvDownload.Rows)
                {
                    string assetClass = row.Cells[3].Value.ToString().Trim();
                    string id = row.Cells[59].Value.ToString();

                    string query = string.Format("update TB_FA_APPROVAL set f_status = 'Fixed Asset Input' where f_status = 'Download Data' and f_id = '{0}'", id);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
      
                    file = sfd.FileName;
                    FileStream fs = new FileStream(file, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    int icolcount = output.Columns.Count;

                    for (int i = 0; i < icolcount; i++)
                    {
                        if (i == 1)
                            sw.Write(" " + output.Columns[i]);
                        else
                            sw.Write(output.Columns[i]);
                        if (i < icolcount - 1)
                            sw.Write('\t');
                    }
                    sw.WriteLine('\n');

                    foreach (DataRow dr in output.Rows)
                    {
                        for (int i = 0; i < icolcount; i++)
                        {
                            if (!Convert.IsDBNull(dr[i]))
                                sw.Write(dr[i].ToString());

                            if (i < icolcount - 1)
                                sw.Write('\t');
                        }
                        sw.Write(sw.NewLine);
                    }
                    sw.Close();

                    this.LoadData("");
                }
            }
            else
                MessageBox.Show("No record can be downloaded.");
        }

        private void tstxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                this.LoadData(tstxtSearch.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        private void dgvDownload_SelectionChanged(object sender, EventArgs e)
        {
            SetText("Selected: " + dgvDownload.SelectedRows.Count);
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

        private void dgvDownload_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDownload.SortOrder.ToString() == "Descending")
                output.DefaultView.Sort = dgvDownload.SortedColumn.DataPropertyName.ToString() + " DESC";
            else
                output.DefaultView.Sort = dgvDownload.SortedColumn.DataPropertyName.ToString() + " ASC";

            output = output.DefaultView.ToTable();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in dgvDownload.SelectedRows)
                    {
                        string chaseno = row.Cells[60].Value.ToString();
                        AccountUtil.DeleteRecord(chaseno);
                    }
                    MessageBox.Show("Record has been deleted.");
                    LoadData(tstxtSearch.Text);
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void tsbtnRollBack_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to rollback selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    foreach (DataGridViewRow row in dgvDownload.SelectedRows)
                    {
                        string id = row.Cells[59].Value.ToString();

                        string query = string.Format("update TB_FA_APPROVAL set f_status = 'Asset Class Input', f_cm1stapp = '---', f_cm1stdate = '---', f_cm2ndapp = '---', f_cm2nddate = '---' where f_id = '{0}'", id);
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }

                    LoadData(tstxtSearch.Text);
                    break;
                    
                case DialogResult.No:
                    break;
            }
        }
    }
}
