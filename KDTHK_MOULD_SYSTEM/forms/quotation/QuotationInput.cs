using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.data;
using KDTHK_MOULD_SYSTEM.services;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.forms.quotation
{
    public partial class QuotationInput : UserControl
    {
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        bool isDataOK = false;

        public QuotationInput()
        {
            InitializeComponent();

            cbBase.SelectedIndex = 0;

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            btnNext.Enabled = isDataOK ? true : false;
            btnSave.Enabled = dgvInput.Rows.Count > 0 ? true : false;
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void VendorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.CheckVendor();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.CheckVendor();
        }

        private void CheckVendor()
        {
            string vendor = txtVendor.Text.Trim();

            if (Vendor.IsVendorValid(vendor))
            {
                isDataOK = true;

                txtVendorname.ForeColor = Color.Black;
                txtVendorname.Text = Vendor.GetVendorName(vendor);

                foreach (string group in Vendor.GroupList(vendor))
                    cbPgroup.Items.Add(group);

                cbPgroup.SelectedIndex = 0;

                SendKeys.Send("{TAB}");
                
            }
            else
            {
                isDataOK = false;

                txtVendorname.ForeColor = Color.Red;
                txtVendorname.Text = "Invalid Vendor Code";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string vendor = txtVendor.Text;
            string partNo = txtPartno.Text;
            string rev = txtRev.Text.Length == 1 ? "0" + txtRev.Text : txtRev.Text;
            string model = txtModel.Text;
            string remarks = txtRemarks.Text;
            int newNo = Convert.ToInt32(nudnew.Value);
            int modifyNo = Convert.ToInt32(nudmodify.Value);
            int pcs = Convert.ToInt32(nudPcs.Value);
            string pbase = cbBase.SelectedItem.ToString();
            string oem = txtOem.Text;
            string pgroup = cbPgroup.SelectedItem.ToString();

            if (partNo.Length != 8 && partNo.Length != 10 && partNo.Length != 12 && partNo.Length != 15)
            {
                MessageBox.Show("Part No. must be 8 / 10 / 12 / 15 digits.");
                return;
            }

            if (string.IsNullOrEmpty(rev))
            {
                MessageBox.Show("Please input rev for this item.");
                return;
            }

            if (partNo.Length == 12 || partNo.Length == 15)
            {
                if (string.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Please input model for this item.");
                    return;
                }
            }
            else if (partNo.Length == 8)
                model = partNo.Substring(0, 3);
            else
            {
                if (partNo.StartsWith("1"))
                    model = partNo.Substring(3, 3);
                else
                    model = partNo.Substring(2, 3);
            }

            if (oem != "")
            {
                if (oem.Length == 1)
                    oem = "0" + oem;

                if (!Oem.IsOemValid(oem))
                {
                    MessageBox.Show("Please input valid OEM for this item.");
                    return;
                }
            }

            string currency = Vendor.GetVendorCurrency(vendor);

            if (newNo != 0)
            {
                string mouldNo = Mould.IsPartNoExist(partNo) ? "K" + Mould.GetLatestMouldNo(partNo) : "K" + partNo + "01";

                dgvInput.Rows.Add(Properties.Resources.cross, mouldNo, partNo, rev, vendor, model, "New", "", currency, "0", "---", remarks,
                    "---", pcs, oem, pbase, pgroup);

                for (int i = 1; i < newNo; i++)
                {
                    int rowIndex = dgvInput.Rows.Count - 1;
                    string rMould = dgvInput.Rows[rowIndex].Cells[1].Value.ToString();
                    int mId = Convert.ToInt32(rMould.Substring(rMould.Length - 2));
                    int cmId = mId + 1;
                    mouldNo = "K" + partNo + cmId.ToString("00");

                    dgvInput.Rows.Add(Properties.Resources.cross, mouldNo, partNo, rev, vendor, model, "New", "", currency, "0", "---", remarks,
                    "---", pcs, oem, pbase, pgroup);
                }
            }

            if (modifyNo != 0)
            {
                if (!Mould.IsPartNoValidExact(partNo))
                {
                    MessageBox.Show("Part No. " + partNo + " does not exist.");
                    return;
                }

                for (int i = 0; i < modifyNo; i++)
                    dgvInput.Rows.Add(Properties.Resources.cross, "", partNo, rev, vendor, model, "Modify", "", currency, "0", "---", remarks,
                    "---", pcs, oem, pbase, pgroup);
            }
        }

        private void dgvInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                dgvInput.Rows.Remove(dgvInput.Rows[e.RowIndex]);
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
                    dgvInput.Rows[index].DefaultCellStyle.BackColor = Color.Coral;
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

                string query = string.Format("insert into TB_MOULD_MAIN (mm_chaseno, mm_mouldno, mm_itemcode" +
                    ", mm_rev, mm_div, mm_currency, mm_amount, mm_amounthkd, mm_mpa, mm_quantity, mm_pcs" +
                    ", mm_itemtext, mm_request, mm_projecttext, mm_model, mm_po, mm_category, mm_vendorcode" +
                    ", mm_group, mm_mouldcode, mm_status_code, mm_remarks, mm_oemasset, mm_instockdate50" +
                    ", mm_created, mm_createdby, mm_accountcode, mm_costcentre, mm_productbase) values" +
                    " ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}'" +
                    ", '{18}', '{19}', '{20}', N'{21}', '{22}', '{23}', '{24}', N'{25}', '{26}', '{27}', '{28}')", chaseno, mouldNo, partNo,
                    rev, div, currency, amount, amountHkd, mpa, quantity, pcs, itemText, request, projectText, model, po,
                    category, vendor, pgroup, mouldCode, status, remarks, oem, instock50, created, createdby,
                    accountCode, costCentre, pbase);

                DataService.GetInstance().ExecuteNonQuery(query);
            }

            switch (MessageBox.Show("Record has been saved. Back to Data View?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    if (CancelEvent != null)
                        CancelEvent(this, new EventArgs());
                    break;

                case DialogResult.No:
                    if (SaveEvent != null)
                        SaveEvent(this, new EventArgs());
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelEvent != null)
                CancelEvent(this, new EventArgs());
        }
    }
}
