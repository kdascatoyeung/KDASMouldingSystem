using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.utils;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.forms.quotation
{
    public partial class QuotationEdit : Form
    {
        string _chaseNo = "";
        string _mode = "";

        public QuotationEdit(string chaseNo, string mouldNo, string partNo, string rev, string div, string model, string amount,
             string status, string remarks, string vendor, string mouldCode, string mode)
        {
            InitializeComponent();

            _chaseNo = chaseNo;
            _mode = mode;

            this.Text = _mode == "Edit" ? "Quotation - Edit" : "Quotation - Modify";

            this.LoadData(mouldNo, partNo, rev, div, model, amount, remarks, vendor, mouldCode);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadData(string mouldNo, string partNo, string rev, string div, string model, string amount, string remarks, string vendor, string mouldCode)
        {
            this.txtMouldNo.Text = mouldNo;
            this.txtPartNo.Text = partNo;
            this.txtRev.Text = rev;
            this.cbDiv.Text = div;
            this.txtModel.Text = model;
            this.txtAmount.Text = amount;
            this.cbBase.Text = DataUtil.GetProductionBase(_chaseNo);
            this.cbIsModify.Text = DataUtil.GetIsModify(_chaseNo) == "True" ? "Yes" : "No";
            this.txtInStock.Text = DataUtil.GetInStockDate(_chaseNo);
            this.txtRemarks.Text = remarks;

            this.txtVendor.Text = vendor;
            this.cbPurGroup.DataSource = DataUtil.GetPurGroup(vendor);
            this.cbPurGroup.SelectedIndex = 0;
            //this.txtPurchaser.Text = DataUtil.GetPurchaser(this.cbPurGroup.Text);
            this.txtName.Text = DataUtil.GetVendorName(vendor);

            this.txtMouldCode.Text = mouldCode;
            this.txtType.Text = DataUtil.GetMouldCodeType(mouldCode);
            this.txtItemGroup.Text = DataUtil.GetMouldCodeItemGroup(mouldCode);
            this.txtContent.Text = DataUtil.GetMouldCodeContent(mouldCode);
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string vendor = txtVendor.Text;
                this.cbPurGroup.DataSource = DataUtil.GetPurGroup(vendor);
                this.cbPurGroup.SelectedIndex = 0;
                //this.txtPurchaser.Text = DataUtil.GetPurchaser(this.cbPurGroup.Text);
                this.txtName.Text = DataUtil.GetVendorName(vendor);
            }
        }

        private void txtMouldCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string mouldCode = txtMouldCode.Text;
                this.txtType.Text = DataUtil.GetMouldCodeType(mouldCode);
                this.txtItemGroup.Text = DataUtil.GetMouldCodeItemGroup(mouldCode);
                this.txtContent.Text = DataUtil.GetMouldCodeContent(mouldCode);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mouldNo = this.txtMouldNo.Text;
            string partNo = this.txtPartNo.Text;
            string rev = this.txtRev.Text;
            string div = this.cbDiv.Text;
            string model = this.txtModel.Text;
            string amount = this.txtAmount.Text;
            string pbase = this.cbBase.Text;
            string isModify = this.cbIsModify.Text == "Yes" ? "True" : "False";
            string inStock = this.txtInStock.Text;
            string remarks = this.txtInStock.Text;
            string vendor = this.txtVendor.Text;
            string pgroup = this.cbPurGroup.Text;
            string mouldCode = this.txtMouldCode.Text;

            string query = "";

            if (_mode == "Edit")
            {
                query = string.Format("update TB_MOULD_MAIN set mm_mouldno = '{0}', mm_itemcode = '{1}', mm_rev = '{2}'" +
                    ", mm_div = '{3}', mm_model = '{4}', mm_amount = '{5}', mm_pbase = '{6}', mm_isModify = '{7}', mm_instockdate = '{8}'" +
                    ", mm_remarks = N'{9}', mm_vendorcode = '{10}', mm_group = '{11}', mm_mouldcode = '{12}' where mm_chaseno = '{13}'",
                    mouldNo, partNo, rev, div, model, amount, pbase, isModify, inStock, remarks, vendor, pgroup, mouldCode, _chaseNo);
            }
            else
            {
                string chaseNo = DataUtil.GetLatestChaseNo();

                //query = string.Format("insert into TB_MOULD_MAIN (mm_chaseno, mm_mouldno, mm_itemcode, mm_rev, mm_div, mm_type"+
                   // ", mm_currency, mm_amount, mm_amounthkd
            }

            DataService.GetInstance().ExecuteNonQuery(query);

            MessageBox.Show("Record has been saved.");

            this.DialogResult = DialogResult.OK;
        }
    }
}
