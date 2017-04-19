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
    public partial class RejectForm : Form
    {
        List<string> _list = null;

        public RejectForm(List<string> list)
        {
            InitializeComponent();

            _list = list;

            cbStatus.SelectedIndex = 0;
        }

        private void SaveData(List<string> list)
        {
            string status = cbStatus.SelectedIndex == 0 ? "Asset Class Input"
                : cbStatus.SelectedIndex == 1 ? "Download Data"
                : cbStatus.SelectedIndex == 2 ? "Fixed Asset Input"
                : cbStatus.SelectedIndex == 3 ? "Reviewer"
                : cbStatus.SelectedIndex == 4 ? "Data Check" : "";

            foreach (string item in list)
            {
                string query = string.Format("update TB_FA_APPROVAL set f_cm3rdapp = 'Reject', f_status = '{0}' where f_id = '{1}'", status, item);
                DataService.GetInstance().ExecuteNonQuery(query);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData(_list);
        }
    }
}
