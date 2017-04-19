using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.data;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.forms.data
{
    public partial class MasterVendorInput : Form
    {
        string _mode = "";

        public MasterVendorInput(string mode, string vendor, string name, string currency, string pGroup, string payTerms, string region, string request, string edi, string remarks)
        {
            InitializeComponent();

            this.Text = mode == "edit" ? "Edit Vendor" : "New Vendor";

            _mode = mode;

            cbCurrency.SelectedIndex = 0;
            cbRegion.SelectedIndex = 0;
            cbEdi.SelectedIndex = 0;

            if (mode == "edit")
            {
                txtVendorCode.Text = vendor;
                txtName.Text = name;
                txtPurG.Text = pGroup;
                cbCurrency.Text = currency;
                txtPayTerms.Text = payTerms;
                txtRequest.Text = request;
                cbEdi.Text = edi;
                txtRemarks.Text = remarks;

                txtPurG.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string vendor = txtVendorCode.Text;
            string name = txtName.Text;
            string pGroup = txtPurG.Text;
            string currency = cbCurrency.Text;
            string payTerms = txtPayTerms.Text;
            string region = cbRegion.Text;
            string request = txtRequest.Text;
            string edi = cbEdi.Text;
            string remarks = txtRemarks.Text;

            if (Vendor.IsVendorValid(vendor) && _mode == "new")
            {
                MessageBox.Show("Vendor  " + vendor + "  already exists.");
                return;
            }

            if (_mode == "edit")
            {
                string query = string.Format("update TB_MASTER_VENDOR set mv_name = N'{0}', mv_group = '{1}', mv_detail = '{2}'" +
                    ", mv_paycurr = '{3}', mv_payterms = '{4}', mv_request = '{5}', mv_edi = '{6}', mv_remarks = N'{7}' where mv_code = '{8}'",
                    name, pGroup, region, currency, payTerms, request, edi, remarks, vendor);
                DataService.GetInstance().ExecuteNonQuery(query);
            }
            else
            {
                string query = string.Format("insert into TB_MASTER_VENDOR (mv_code, mv_name, mv_group, mv_detail, mv_paycurr" +
                    ", mv_payterms, mv_request, mv_edi, mv_remarks) values ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', N'{8}')",
                    vendor, name, pGroup, region, currency, payTerms, request, edi, remarks);
                DataService.GetInstance().ExecuteNonQuery(query);
            }

            MessageBox.Show("Record has been saved.");
            this.DialogResult = DialogResult.OK;
        }

        private void txtVendorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (_mode == "edit")
                e.Handled = true;
        }
    }
}
