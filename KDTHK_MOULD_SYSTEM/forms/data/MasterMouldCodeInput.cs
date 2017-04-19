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
    public partial class MasterMouldCodeInput : Form
    {
        string _mode = "";

        public MasterMouldCodeInput(string mode, string mouldCode, string type, string jp, string eng, string chin, string itemGroup)
        {
            InitializeComponent();

            this.Text = mode == "edit" ? "Edit Mould Code" : "New Mould Code";

            _mode = mode;

            if (mode == "edit")
            {
                txtMouldCode.Text = mouldCode;
                txtType.Text = type;
                txtContentJp.Text = jp;
                txtContentEng.Text = eng;
                txtContentChin.Text = chin;

                txtType.Select();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mouldCode = txtMouldCode.Text;
            string type = txtType.Text;
            string jp = txtContentJp.Text;
            string eng = txtContentEng.Text;
            string chin = txtContentChin.Text;
            string itemGroup = txtItemGroup.Text;

            if (MouldCode.IsMouldCodeValid(mouldCode) && _mode == "new")
            {
                MessageBox.Show("Mould Code  " + mouldCode + "  already exists.");
                return;
            }

            if (_mode == "edit")
            {
                string query = string.Format("update TB_MASTER_MOULDCODE set mc_type = N'{0}', mc_contentjp = N'{1}'" +
                    ", mc_contenteng = N'{2}', mc_contentchin = N'{3}', mc_itemgroup = '{4}' where mc_code = '{5}'",
                    type, jp, eng, chin, itemGroup, mouldCode);
                DataService.GetInstance().ExecuteNonQuery(query);
            }
            else
            {
                string query = string.Format("insert into TB_MASTER_MOULDCODE (mc_code, mc_type, mc_contentjp" +
                    ", mc_contenteng, mc_contentchin, mc_itemgroup) values ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}')",
                    mouldCode, type, jp, eng, chin, itemGroup);
                DataService.GetInstance().ExecuteNonQuery(query);
            }

            MessageBox.Show("Record has been saved.");
            this.DialogResult = DialogResult.OK;
        }

        private void txtMouldCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_mode == "edit")
                e.Handled = true;
        }
    }
}
