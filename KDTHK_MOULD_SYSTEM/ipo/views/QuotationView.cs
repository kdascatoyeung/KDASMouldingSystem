using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.data;
using KDTHK_MOULD_SYSTEM.utils;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.ipo.views
{
    public partial class QuotationView : UserControl
    {
        bool _isDataOK = true;

        public event EventHandler SavedEvent;

        public QuotationView()
        {
            InitializeComponent();

            cbBase.SelectedIndex = 0;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GetVendorName(string vendor)
        {
            if (Vendor.IsVendorValid(vendor.Trim()))
            {
                txtVendorname.ForeColor = Color.Black;
                txtVendorname.Text = Vendor.GetVendorName(vendor.Trim());
                txtVendorname.SelectionStart = 0;

                foreach (string gp in Vendor.GroupList(vendor.Trim()))
                    if (!cbPgroup.Items.Contains(gp))
                        cbPgroup.Items.Add(gp);

                cbPgroup.SelectedIndex = 0;

                txtPartno.Select();
                //SendKeys.Send("{TAB}");
                //SendKeys.Send("{TAB}");
                //SendKeys.Send("{TAB}");
            }
            else
            {
                _isDataOK = false;

                txtVendorname.ForeColor = Color.Red;
                txtVendorname.Text = "Invalid Vendor Code";
            }
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetVendorName(txtVendor.Text.Trim());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetVendorName(txtVendor.Text.Trim());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string vendor = txtVendor.Text.Trim();
            string partno = txtPartno.Text.Trim();
            string rev = txtRev.Text.Trim().Length == 1 ? "0" + txtRev.Text.Trim() : txtRev.Text.Trim();
            string model = txtModel.Text.Trim();
            string remarks = txtRemarks.Text;
            int newNo = Convert.ToInt32(nudnew.Value);
            int modifyNo = Convert.ToInt32(nudmodify.Value);
            int pcs = Convert.ToInt32(nudPcs.Value);
            string pbase = cbBase.SelectedItem.ToString();
            string oem = txtOem.Text;
            string pgroup = cbPgroup.SelectedItem.ToString();

            if (!QuotationUtil.IsLengthValid(partno))
            {
                MessageBox.Show("Invalid Part No. Length");
                return;
            }

            if (string.IsNullOrEmpty(rev))
            {
                MessageBox.Show("Please input Rev");
                return;
            }

            if (partno.Length == 12 || partno.Length == 15)
            {
                if (string.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Please input Model");
                    return;
                }
            }
            else if (partno.Length == 8)
                model = partno.Substring(0, 3);
            else
            {
                if (partno.StartsWith("1"))
                    model = partno.Substring(3, 3);
                else
                    model = partno.Substring(2, 3);
            }

            if (oem != "")
            {
                if (oem.Length == 1)
                    oem = "0" + oem;

                if (!Oem.IsOemValid(oem))
                {
                    MessageBox.Show("Please input valid OEM");
                    return;
                }
            }

            string currency = Vendor.GetVendorCurrency(vendor);

            if (newNo != 0)
            {
                string mouldno = Mould.IsPartNoExist(partno) ? "K" + Mould.GetLatestMouldNo(partno) : "K" + partno + "01";

                dgvInput.Rows.Add(Properties.Resources.cross, mouldno, partno, rev, vendor, model, "New", "", currency, "0", "---", remarks,
                    "---", pcs, oem, pbase, pgroup);

                for (int i = 1; i < newNo; i++)
                {
                    int rowIndex = dgvInput.Rows.Count - 1;
                    string rMould = dgvInput.Rows[rowIndex].Cells[1].Value.ToString();
                    int mId = Convert.ToInt32(rMould.Substring(rMould.Length - 2));
                    int cmId = mId + 1;
                    mouldno = "K" + partno + cmId.ToString("00");

                    dgvInput.Rows.Add(Properties.Resources.cross, mouldno, partno, rev, vendor, model, "New", "", currency, "0", "---", remarks,
                    "---", pcs, oem, pbase, pgroup);
                }
            }

            if (modifyNo != 0)
            {
                for (int i = 0; i < modifyNo; i++)
                    dgvInput.Rows.Add(Properties.Resources.cross, "", partno, rev, vendor, model, "Modify", "", currency, "0", "---", remarks,
                        "---", pcs, oem, pbase, pgroup);
            }
        }

        private List<int> CheckDataList()
        {
            List<int> indexList = new List<int>();

            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                row.DefaultCellStyle.BackColor = SystemColors.ControlLightLight;
                row.DefaultCellStyle.ForeColor = Color.Black;

                string mouldCode = row.Cells[7].Value.ToString();
                string currency = row.Cells[8].Value.ToString();
                string amount = row.Cells[9].Value.ToString();

                if (!General.IsValidPrice(amount))
                    indexList.Add(row.Index);

                if (!MouldCode.IsMouldCodeValid(mouldCode))
                    indexList.Add(row.Index);
            }

            indexList = indexList.Distinct().ToList();

            return indexList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckDataList().Count > 0)
            {
                foreach (int index in CheckDataList())
                {
                    dgvInput.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    dgvInput.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                }
                return;
            }

            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                string mouldNo = row.Cells[1].Value.ToString();
                string partNo = row.Cells[2].Value.ToString();
                string rev = row.Cells[3].Value.ToString();
                string vendor = row.Cells[4].Value.ToString();
                string model = row.Cells[5].Value.ToString();
                string div = row.Cells[6].Value.ToString();
                string mouldCode = row.Cells[7].Value.ToString();
                string currency = row.Cells[8].Value.ToString();
                string amount = row.Cells[9].Value.ToString();
                string mpa = row.Cells[10].Value == "Yes" ? "True" : "False";
                string remarks = row.Cells[11].Value.ToString();
                string modify = row.Cells[12].Value == "Yes" ? "True" : "False";
                string pcs = row.Cells[13].Value.ToString();
                string oem = row.Cells[14].Value.ToString();
                string pbase = row.Cells[15].Value.ToString();
                string pgroup = row.Cells[16].Value.ToString();

                string chaseno = Mould.GetLatestChaseNo();
                string projectText = partNo + "-" + rev;
                string request = partNo + rev;
                string itemText = mpa == "Yes" ? mouldNo + "MP+" + mouldCode + "+" + div + "*" : mouldNo + "MP+" + mouldCode + "+" + div;
                string instock50 = mpa == "Yes" ? "Yes" : "#N/A";
                string quantity = mpa == "Yes" ? "2" : "1";

                string accountCode = oem != "" ? Oem.GetAccountCode(oem) : "";
                string costCentre = oem != "" ? Oem.GetCostCentre(oem) : "";

                decimal cAmount = currency == "JPY" ? Convert.ToDecimal(amount) * Convert.ToDecimal(Amount.GetMonthlyJpyRate(DateTime.Today.ToString("yyyy"), DateTime.Today.ToString("MM")))
                    : Amount.AmountWithRate(currency, amount);

                string amountHkd = cAmount.ToString("#.##");

                cAmount = cAmount / Convert.ToInt32(pcs);

                string category = "A";
                string status = "";

                if (cAmount < 10000)
                {
                    category = "K";
                    status = cAmount == 0 ? "K" : "U";
                }
                else
                {
                    category = (mouldCode.StartsWith("8") && mouldCode != "8") || (oem != "") ? "K" : "A";
                    status = (mouldCode.StartsWith("8") && mouldCode != "8") || (oem != "") ? "U" : "F";
                }

                string po = div == "TM" ? chaseno.Replace("MS", "TM") : "";

                string created = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                string createdby = GlobalService.Owner;

                string query = string.Format("insert into TB_MOULD_MAIN (m_chaseno, m_mouldno, m_itemcode" +
                    ", m_rev, m_div, m_currency, m_amount, m_amounthkd, m_mpa, m_quantity, m_pcs" +
                    ", m_itemtext, m_request, m_projecttext, m_model, m_po, m_category, m_vendor" +
                    ", m_group, m_mouldcode, m_status, m_remarks, m_oem, m_instock50" +
                    ", m_created, m_createdby, m_accountcode, m_costcenter, m_productbase) values" +
                    " ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}'" +
                    ", '{18}', '{19}', '{20}', N'{21}', '{22}', '{23}', '{24}', N'{25}', '{26}', '{27}', '{28}')", chaseno, mouldNo, partNo,
                    rev, div, currency, amount, amountHkd, mpa, quantity, pcs, itemText, request, projectText, model, po,
                    category, vendor, pgroup, mouldCode, status, remarks, oem, instock50, created, createdby,
                    accountCode, costCentre, pbase);

                DataService.GetInstance().ExecuteNonQuery(query);
            }

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
        }
    }
}
