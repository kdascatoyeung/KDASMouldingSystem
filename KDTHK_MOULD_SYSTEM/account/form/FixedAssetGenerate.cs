using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.account.form
{
    public partial class FixedAssetGenerate : Form
    {
        public FixedAssetGenerate()
        {
            InitializeComponent();
        }

        private void txtFixedAssetCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveData();
        }

        private void SaveData()
        {
            if (txtFixedAssetCode.Text.Length != 9)
            {
                MessageBox.Show("Fixed Asset Code MUST be 9 digits");
                return;
            }

            GlobalService.FixedAssetCode = txtFixedAssetCode.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
