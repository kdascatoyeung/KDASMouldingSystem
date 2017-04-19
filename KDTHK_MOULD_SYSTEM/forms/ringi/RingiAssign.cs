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
using System.Diagnostics;
using KDTHK_MOULD_SYSTEM.data;
using KDTHK_MOULD_SYSTEM.output;
using CustomUtil.utils.import;

namespace KDTHK_MOULD_SYSTEM.forms.ringi
{
    public partial class RingiAssign : UserControl
    {
        List<SavedList> savedList;

        public RingiAssign()
        {
            InitializeComponent();

            SystemUtil.DoubleBuffered(dgvRingi, true);
            SystemUtil.DoubleBuffered(dgvResult, true);

            this.LoadRingi(txtSearch.Text);
            this.LoadData(txtSearchItem.Text);
        }

        private void LoadData(string source)
        {
            dgvResult.Rows.Clear();

            string query = string.Format("select m_chaseno, m_mouldno, m_itemcode" +
                ", m_vendor, m_currency, m_amount" +
                " from TB_MOULD_MAIN where m_status = 'F' and (m_mouldno like '%{0}%'" +
                " or m_itemcode like '%{0}%' or m_vendor like '%{0}%')", source);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string chaseNo = GlobalService.Reader.GetString(0);
                    string mouldNo = GlobalService.Reader.GetString(1);
                    string partNo = GlobalService.Reader.GetString(2);
                    string vendor = GlobalService.Reader.GetString(3);
                    string currency = GlobalService.Reader.GetString(4);
                    string amount = GlobalService.Reader.GetString(5);

                    dgvResult.Rows.Add(chaseNo, mouldNo, partNo, vendor, currency, amount, "---");
                }
            }
        }

        private void LoadRingi(string source)
        {
            dgvRingi.Rows.Clear();

            string query = string.Format("select mr_no, mr_content, mr_balance from TB_MASTER_RINGI" +
                " where (mr_no like '%{0}%' or mr_content like '%{0}%')", source);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string rgno = GlobalService.Reader.GetString(0);
                    string content = GlobalService.Reader.GetString(1);
                    string balance = GlobalService.Reader.GetString(2);

                    dgvRingi.Rows.Add(rgno, content, balance);
                }
            }
        }

        private void dgvResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                foreach (DataGridViewRow row in dgvResult.SelectedRows)
                {
                    if (lblRingi.Text != "Unknown")
                        row.Cells[6].Value = lblRingi.Text;
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            List<RingiTempList> tempList = new List<RingiTempList>();

            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                string chaseNo = row.Cells[0].Value.ToString();
                string ringi = row.Cells[6].Value.ToString();
                decimal amount = Convert.ToDecimal(row.Cells[5].Value);

                if (ringi == "---")
                    continue;

                tempList.Add(new RingiTempList { Ringi = ringi, Total = amount });
            }

            var groupedList = tempList.GroupBy(u => u.Ringi)
                .Select(g => new
                {
                    Key = g.Key,
                    Total = g.Sum(s => s.Total)
                }).ToList();

            List<string> errorList = new List<string>();

            foreach (var item in groupedList)
            {
                decimal balance = Ringi.GetRingiBalance(item.Key);
                if (balance < item.Total)
                    errorList.Add(item.Key);
            }

            if (errorList.Count > 0)
            {
                foreach (DataGridViewRow row in dgvResult.Rows)
                {
                    string ringi = row.Cells[6].Value.ToString();

                    if (errorList.Contains(ringi))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = SystemColors.ControlLightLight;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            else
            {
                savedList = new List<SavedList>();

                foreach (DataGridViewRow row in dgvResult.Rows)
                {
                    string chaseNo = row.Cells[0].Value.ToString();
                    string mouldNo = row.Cells[1].Value.ToString();
                    string partNo = row.Cells[2].Value.ToString();
                    string vendor = row.Cells[3].Value.ToString();
                    string ringi = row.Cells[6].Value.ToString();

                    if (ringi == "---")
                        continue;

                    savedList.Add(new SavedList { ChaseNo = chaseNo, MouldNo = mouldNo, PartNo = partNo, Vendor = vendor, Ringi = ringi });
                }
                MessageBox.Show("Data is validated.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable pdfTable = new DataTable();
            string[] headers = { "Chase No.", "Item Text", "Part No.", "Ringi", "Vendor" };

            foreach (string header in headers)
                pdfTable.Columns.Add(header);

            foreach (SavedList item in savedList)
            {
                string itemText = Mould.GetItemText(item.ChaseNo);
                string vendorName = Vendor.GetVendorName(item.Vendor);
                string storedVendor = item.Vendor + " " + vendorName;

                string query = string.Format("update TB_MOULD_MAIN set m_ringi = '{0}' where m_chaseno = '{1}'", item.ChaseNo, item.Ringi);
                DataService.GetInstance().ExecuteNonQuery(query);

                pdfTable.Rows.Add(item.ChaseNo, itemText, item.PartNo, item.Ringi, storedVendor);
            }

            PdfUtil.ExportPdf(pdfTable);

            MessageBox.Show("Record has been saved.");

            this.LoadRingi(txtSearch.Text);
            this.LoadData(txtSearchItem.Text);
        }

        private void txtSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(txtSearchItem.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadRingi(txtSearch.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);
                foreach (DataRow row in table.Rows)
                {
                    string rgno = row.ItemArray[0].ToString();
                    string content = row.ItemArray[1].ToString();
                    string currency = row.ItemArray[2].ToString();
                    string amount = row.ItemArray[3].ToString();
                    string rate = row.ItemArray[4].ToString();
                    string hkd = row.ItemArray[5].ToString();
                    string regdate = (Convert.ToDateTime(row.ItemArray[6]).ToString("yyyy/MM/dd"));
                    string expired = (Convert.ToDateTime(row.ItemArray[7]).ToString("yyyy/MM/dd"));
                    string r3date = (Convert.ToDateTime(row.ItemArray[8]).ToString("yyyy/MM/dd"));
                    string balance = row.ItemArray[9].ToString();

                    string query = string.Format("insert into TB_MASTER_RINGI (mr_no, mr_content, mr_currency" +
                        ", mr_amount, mr_rate, mr_amounthkd, mr_regdate, mr_expired, mr_confirmdate, mr_balance)" +
                        " values ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", rgno, content, currency, amount,
                        rate, hkd, regdate, expired, r3date, balance);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
        }

        private void dgvRingi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                lblRingi.Text = dgvRingi.SelectedRows[0].Cells[0].Value.ToString();
                Clipboard.SetText(dgvRingi.SelectedRows[0].Cells[0].Value.ToString());
                e.SuppressKeyPress = true;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dgvRingi.SelectedRows[0].Cells[0].Value.ToString());
            lblRingi.Text = dgvRingi.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void dgvRingi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvRingi.HitTest(e.X, e.Y);
                dgvRingi.ClearSelection();
                if (((dgvRingi.Rows[0].Height * dgvRingi.Rows.Count) + dgvRingi.ColumnHeadersHeight) >= e.Location.Y)
                    dgvRingi.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void dgvRingi_MouseHover(object sender, EventArgs e)
        {
            dgvRingi.Focus();
        }

        private void dgvResult_MouseHover(object sender, EventArgs e)
        {
            dgvResult.Focus();
        }
    }

    class RingiTempList
    {
        public string Ringi { get; set; }
        public decimal Total { get; set; }
    }

    class SavedList
    {
        public string ChaseNo { get; set; }
        public string MouldNo { get; set; }
        public string PartNo { get; set; }
        public string Vendor { get; set; }
        public string Ringi{get;set;}
    }
}
