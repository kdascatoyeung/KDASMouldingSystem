using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.data;
using CustomUtil.utils.buffer;

namespace KDTHK_MOULD_SYSTEM.forms.transfer
{
    public partial class TransferView : UserControl
    {
        bool isVendorOK = false;
        bool isItemOK = false;

        string _vendor = "";

        public TransferView()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvPreview, true);
            BufferUtil.DoubleBuffered(dgvSearch, true);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            isItemOK = dgvSearch.SelectedRows.Count > 0 ? true : false;
            btnPreview.Enabled = isVendorOK && isItemOK ? true : false;
            tsbtnSave.ForeColor = dgvPreview.Rows.Count > 0 ? Color.DarkOrange : Color.DimGray;
        }

        private void LoadItem(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mm_mouldno as mould, mm_itemcode as partno" +
                ", mm_rev as rev, mm_vendorcode as vendor, mv_name as name, mm_chaseno as chaseno" +
                " from TB_MOULD_MAIN, TB_MASTER_VENDOR where mm_vendorcode = mv_code" +
                " and (mm_mouldno like '%{0}%' or mm_itemcode like '%{0}%' or mm_vendorcode like '%{0}%'" +
                " or mv_name like '%{0}%')", source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(tb);

            dgvSearch.DataSource = tb;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadItem(txtSearch.Text);
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            this.LoadItem(txtSearch.Text);
        }

        private void LoadVendor(string source)
        {
            string vendor = source.Trim();

            if (Vendor.IsVendorValid(vendor))
            {
                isVendorOK = true;

                _vendor = vendor;

                txtVendorname.ForeColor = Color.Black;
                txtVendorname.Text = Vendor.GetVendorName(vendor);

                foreach (string group in Vendor.GroupList(vendor))
                    cbPgroup.Items.Add(group);

                cbPgroup.SelectedIndex = 0;

                SendKeys.Send("{TAB}");
            }
            else
            {
                isVendorOK = false;

                txtVendorname.ForeColor = Color.Red;
                txtVendorname.Text = "Invalid Vendor Code";
            }
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadVendor(txtVendor.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadVendor(txtVendor.Text);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSearch.SelectedRows)
            {
                string mouldNo = row.Cells[0].Value.ToString();
                string partNo = row.Cells[1].Value.ToString();
                string rev = row.Cells[2].Value.ToString();
                string vendor = row.Cells[3].Value.ToString();
                string chaseNo = row.Cells[5].Value.ToString();

                string model = Mould.GetModel(chaseNo);
                string amount = Mould.GetAmount(chaseNo);
                string remarks = Mould.GetRemarks(chaseNo);
                string pcs = Mould.GetPcs(chaseNo);

                dgvPreview.Rows.Add(Properties.Resources.cross, mouldNo, partNo, rev, vendor, _vendor, model, amount, remarks, pcs, chaseNo);
            }
        }

        private void dgvSearch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var cell = dgvSearch.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = dgvSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void dgvPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvPreview.Rows.Remove(dgvPreview.CurrentRow);
            }
        }

        private void tsbtnTemplate_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnUpload_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnHistory_Click(object sender, EventArgs e)
        {
            TransferHistory history = new TransferHistory();
            history.ShowDialog();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPreview.Rows)
            {
                string mouldNo = row.Cells[1].Value.ToString();
                string partNo = row.Cells[2].Value.ToString();
                string rev = row.Cells[3].Value.ToString();
                string fromVendor = row.Cells[4].Value.ToString();
                string toVendor = row.Cells[5].Value.ToString();
                string remarks = row.Cells[8].Value.ToString();
                string pcs = row.Cells[9].Value.ToString();
                string chaseNo = row.Cells[10].Value.ToString();
                
                List<string> list = FaList(chaseNo);

                string fa = "";
                string category = "K";

                if (list.Count == 0)
                    fa = "";
                else if (list.Count == 1)
                {
                    fa = list[0].ToString();
                    category = "A";
                }
                else
                {
                    fa = string.Join(",", list.ToArray());
                    category = "A";
                }

                string lastChaseNo = Mould.GetLatestChaseNo();
                string tmNo = lastChaseNo.Replace("MS", "TM");
                string purG = Vendor.GetVendorGroup(toVendor);
                string div = Mould.GetDiv(chaseNo);
                string mouldCode = Mould.GetMouldCode(chaseNo);
                string itemText = mouldNo + "MP+" + Mould.GetMouldCode(chaseNo) + "+TM";
                string type = "TM";
                string isModify = "False";
                string projectText = partNo + "-" + rev;
                string request = partNo + rev;
                string quantity = "1";
                string amount = "0";
                string currency = Vendor.GetVendorCurrency(toVendor);
                string status = "T";
                string owner = "KDTHK";
                string common = "Non-Common";
                string model = mouldNo.Substring(1, 3);

                string query = string.Format("insert into TB_MOULD_MAIN (mm_chaseno, mm_mouldno, mm_itemcode, mm_rev" +
                    ", mm_div, mm_type, mm_currency, mm_amount, mm_amounthkd, mm_mpa, mm_mouldcode, mm_vendorcode" +
                    ", mm_status_code, mm_quantity, mm_itemtext, mm_projecttext, mm_request, mm_owner, mm_category" +
                    ", mm_created, mm_createdby, mm_model, mm_group, mm_po, mm_fixedassetcode" +
                    ", mm_pcs, mm_ismodify, mm_remarks) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}'" +
                    ", '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}')", lastChaseNo,
                    mouldNo, partNo, rev, div, type, currency, amount, amount, "False", mouldCode, toVendor, status, quantity,
                    itemText, projectText, request, owner, category, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    GlobalService.Owner, model, purG, tmNo, fa, pcs, isModify, remarks);

                DataService.GetInstance().ExecuteNonQuery(query);

                this.SaveTransferHistory(tmNo, mouldNo, partNo, rev, fromVendor, toVendor, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    chaseNo, fa, remarks);
            }

            MessageBox.Show("Record has been saved.");

            dgvPreview.Rows.Clear();
        }

        private List<string> FaList(string chaseNo)
        {
            string query = string.Format("select mm_fixedassetcode from TB_MOULD_MAIN where mm_chaseno = '{0}' and mm_fixedassetcode != ''" +
                " and mm_fixedassetcode not like '%,%' and mm_fixedassetcode not like '%VC%'", chaseNo);

            List<string> list = new List<string>();

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                    list.Add(GlobalService.Reader.GetString(0));
            }

            return list;
        }

        private void SaveTransferHistory(string tmNo, string mouldNo, string partNo, string rev, string from, string to, string date, string chaseNo, string fa, string remarks)
        {
            string query = string.Format("insert into TB_MOULD_TRANSFER (mt_tmno, mt_mouldno, mt_itemcode, mt_rev, mt_locationbefore" +
                ", mt_locationafter, mt_date, mt_chaseno, mt_fa, mt_remarks) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                tmNo, mouldNo, partNo, rev, from, to, date, chaseNo, fa, remarks);

            DataService.GetInstance().ExecuteNonQuery(query);
        }
    }
}
