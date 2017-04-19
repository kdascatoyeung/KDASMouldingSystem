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
    public partial class MasterOemInput : Form
    {
        string _mode = "";

        public MasterOemInput(string mode, string code, string content, string accountCode, string costCentre, string remarks)
        {
            InitializeComponent();

            this.Text = mode == "edit" ? "Edit OEM" : "New OEM";

            _mode = mode;

            if (mode == "edit")
            {
                txtCode.Text = code;
                txtContent.Text = content;
                txtAccountCode.Text = accountCode;
                txtCostCentre.Text = costCentre;
                txtRemarks.Text = remarks;

                txtContent.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string content = txtContent.Text;
            string accountCode = txtAccountCode.Text;
            string costCentre = txtCostCentre.Text;
            string remarks = txtRemarks.Text;

            if (Oem.IsOemValid(code) && _mode == "new")
            {
                MessageBox.Show("OEM  " + code + "  already exists.");
                return;
            }

            if (string.IsNullOrEmpty(accountCode) || string.IsNullOrEmpty(costCentre))
            {
                MessageBox.Show("Please input Account Code and Cost Centre.");
                return;
            }

            if (_mode == "edit")
            {
                string query = string.Format("update TB_MASTER_OEM set mo_content = N'{0}', mo_accountcode = '{1}', mo_costcentre = '{2}'" +
                    ", mo_remarks = N'{3}' where mo_code = '{4}'", content, accountCode, costCentre, remarks, code);
                DataService.GetInstance().ExecuteNonQuery(query);
            }
            else
            {
                string query = string.Format("insert into TB_MASTER_OEM (mo_code, mo_content, mo_accountcode, mo_costcentre, mo_remarks)" +
                    " values ('{0}', N'{1}', '{2}', '{3}', N'{4}')", code, content, accountCode, costCentre, remarks);
                DataService.GetInstance().ExecuteNonQuery(query);
            }

            MessageBox.Show("Record has been saved.");
            this.DialogResult = DialogResult.OK;
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_mode == "edit")
                e.Handled = true;
        }
    }
}
