using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using System.Data.SqlClient;
using System.Diagnostics;
using KDTHK_MOULD_SYSTEM.utils;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaRingi : UserControl
    {
        public FaRingi()
        {
            InitializeComponent();

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();
            string[] headers = { "approval", "pdfid", "request", "ringi", "desc", "model", "currency", "amount", "type", "chaseno", "id" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select f_pdfid, f_ringi, f_desc, f_model, f_currency, f_amount, f_chaseno, f_id, f_apptype, f_request from TB_FA_APPROVAL where f_status = 'Ringi Approval' and (f_pdfid like '%{0}%' or f_ringi like '%{0}%' or f_model like '%{0}%') and f_mpa != 'Temp'", source);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    string pdfId = reader.GetString(0);
                    string ringi = reader.GetString(1);
                    string desc = reader.GetString(2);
                    string model = reader.GetString(3);
                    string currency = reader.GetString(4);
                    string amount = reader.GetString(5);
                    string chaseno = reader.GetString(6);
                    int id = reader.GetInt32(7);
                    string apptype = reader.GetString(8);
                    string request = reader.GetString(9);

                    table.Rows.Add("Please select", pdfId, request, ringi, desc, model, currency, amount, apptype, chaseno, id);
                }
            }

            dgvRingi.DataSource = table;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRingi.Rows)
                row.Cells[0].Value = "Approve";
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            dgvRingi.EndEdit();

            int count = 0;

             foreach (DataGridViewRow row in dgvRingi.Rows)
             {
                 string approval = row.Cells[0].Value.ToString();
                 string ringi = row.Cells[3].Value.ToString();
                 decimal amount = Convert.ToDecimal(row.Cells[7].Value);
                 string type = row.Cells[8].Value.ToString();
                 string chaseno = row.Cells[9].Value.ToString();
                 string id = row.Cells[10].Value.ToString();

                 if (approval != "Approve")
                     continue;

                 string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                 string assetClass = type == "Mould" ? "Z1600" : type == "Jigs" ? "Z1710" : "";

                 string query = string.Format("update TB_FA_APPROVAL set f_ringi1stapp = 'Approve', f_ringi1st = N'{0}', f_ringi1stdate = '{1}', f_status = 'Asset Class Input', f_assetclass = '{2}' where f_id = '{3}'", GlobalService.Owner, now, assetClass, id);
                 DataService.GetInstance().ExecuteNonQuery(query);

                 //string text = string.Format("update TB_MASTER_RINGI set mr_balance = cast(mr_balance as decimal(10, 2)) - {0} where mr_no = '{1}'", amount, ringi);
                 //DataService.GetInstance().ExecuteNonQuery(text);

                 string text = string.Format("update tb_ringi set rg_balance = cast(rg_balance as decimal(10, 2)) - {0} where rg_no = '{1}'", amount, ringi);
                 DataServiceMould.GetInstance().ExecuteNonQuery(text);

                 count += 1;
                 CheckMpa(id);
             }

             this.LoadData("");
        }

        private void CheckMpa(string id)
        {
            DataTable table = new DataTable();

            string text = string.Format("select f_request, f_applicant, f_type, f_chaseno, f_pdfid, f_status, f_desc, f_vendor, f_attachment, f_mould, f_costcenter, f_resp, f_location, f_ringi" +
                    ", f_assetdesc, f_ipo1st, f_ipo1stapp, f_ipo1stdate, f_ipo2nd, f_ipo2ndapp, f_ipo2nddate, f_ringi1st, f_ringi1stapp, f_ringi1stdate, f_cm1st, f_cm2nd, f_cm3rd, f_partno from TB_FA_APPROVAL where f_id = '{0}' and f_mpa = 'Yes'", id);

            SqlDataAdapter sda = new SqlDataAdapter(text, DataService.GetInstance().Connection);
            sda.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string request = row.ItemArray[0].ToString();
                string applicant = row.ItemArray[1].ToString();
                string type = row.ItemArray[2].ToString();
                string chaseno = row.ItemArray[3].ToString();
                string pdfid = row.ItemArray[4].ToString();
                string status = row.ItemArray[5].ToString();
                string desc = row.ItemArray[6].ToString();
                string vendor = row.ItemArray[7].ToString();
                string attachement = row.ItemArray[8].ToString();
                string mould = row.ItemArray[9].ToString();
                string costcenter = row.ItemArray[10].ToString();
                string resp = row.ItemArray[11].ToString();
                string location = row.ItemArray[12].ToString();
                string ringi = row.ItemArray[13].ToString();
                string assetdesc = row.ItemArray[14].ToString();
                string ipo1st = row.ItemArray[15].ToString();
                string ipo1stapp = row.ItemArray[16].ToString();
                string ipo1stdate = row.ItemArray[17].ToString();
                string ipo2nd = row.ItemArray[18].ToString();
                string ipo2ndapp = row.ItemArray[19].ToString();
                string ipo2nddate = row.ItemArray[20].ToString();
                string ringi1st = row.ItemArray[21].ToString();
                string ringi1stapp = row.ItemArray[22].ToString();
                string ringi1stdate = row.ItemArray[23].ToString();
                string cm1st = row.ItemArray[24].ToString();
                string cm2nd = row.ItemArray[25].ToString();
                string cm3rd = row.ItemArray[26].ToString();
                string partno = row.ItemArray[27].ToString();

                string query = string.Format("insert into TB_FA_APPROVAL (f_request, f_applicant, f_type, f_chaseno, f_pdfid, f_status, f_desc, f_vendor, f_attachment, f_mould, f_costcenter, f_resp, f_location, f_ringi" +
                    ", f_assetdesc, f_ipo1st, f_ipo1stapp, f_ipo1stdate, f_ipo2nd, f_ipo2ndapp, f_ipo2nddate, f_ringi1st, f_ringi1stapp, f_ringi1stdate, f_cm1st, f_cm2nd, f_cm3rd, f_mpa, f_apptype, f_assetclass, f_partno) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}'" +
                    ", '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', N'{15}', '{16}', '{17}', N'{18}', '{19}', '{20}', N'{21}', '{22}', '{23}', N'{24}', N'{25}', N'{26}', '{27}', '{28}', '{29}', '{30}')", request, applicant, type, chaseno, pdfid, status, desc, vendor, attachement,
                    mould, costcenter, resp, location, ringi, assetdesc, ipo1st, ipo1stapp, ipo1stdate, ipo2nd, ipo2ndapp, ipo2nddate, ringi1st, ringi1stapp, ringi1stdate, cm1st, cm2nd, cm3rd, "Temp", "Mould", "Z4000", partno);

                DataService.GetInstance().ExecuteNonQuery(query);
            }
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

        private void tsbtnSend_Click(object sender, EventArgs e)
        {
            EmailUtil.SendNotificationMail();
        }
    }
}
