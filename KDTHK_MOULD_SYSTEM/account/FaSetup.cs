using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaSetup : UserControl
    {
        public FaSetup()
        {
            InitializeComponent();

            foreach (string item in GlobalService.AccountStaffList)
            {
                cb1st.Items.Add(item);
                cb2nd.Items.Add(item);
                cb3rd.Items.Add(item);
            }

            cb1st.Text = Load1stApprover();
            cb2nd.Text = Load2ndApprover();
            cb3rd.Text = Load3rdApprover();
        }

        private string Load1stApprover()
        {
            string query = "select a_name from TB_APPROVER where a_id = 1";
            return DataService.GetInstance().ExecuteScalar(query).ToString().Trim();
        }

        private string Load2ndApprover()
        {
            string query = "select a_name from TB_APPROVER where a_id = 2";
            return DataService.GetInstance().ExecuteScalar(query).ToString().Trim();
        }

        private string Load3rdApprover()
        {
            string query = "select a_name from TB_APPROVER where a_id = 3";
            return DataService.GetInstance().ExecuteScalar(query).ToString().Trim();
        }

        private void Keypressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string app1st = cb1st.SelectedItem.ToString().Trim();
            string app2nd = cb2nd.SelectedItem.ToString().Trim();
            string app3rd = cb3rd.SelectedItem.ToString().Trim();

            string q1 = string.Format("update TB_FA_APPROVAL set f_cm1st = N'{0}' where f_cm1stapp = '---'", app1st);
            DataService.GetInstance().ExecuteNonQuery(q1);

            string q2 = string.Format("update TB_FA_APPROVAL set f_cm2nd = N'{0}' where f_cm2ndapp = '---'", app2nd);
            DataService.GetInstance().ExecuteNonQuery(q2);

            string q3 = string.Format("update TB_FA_APPROVAL set f_cm3rd = N'{0}' where f_cm3rdapp = '---'", app3rd);
            DataService.GetInstance().ExecuteNonQuery(q3);

            string q4 = string.Format("update TB_APPROVER set a_name = N'{0}' where a_id = 1", app1st);
            DataService.GetInstance().ExecuteNonQuery(q4);

            string q5 = string.Format("update TB_APPROVER set a_name = N'{0}' where a_id = 2", app2nd);
            DataService.GetInstance().ExecuteNonQuery(q5);

            string q6 = string.Format("update TB_APPROVER set a_name = N'{0}' where a_id = 3", app3rd);
            DataService.GetInstance().ExecuteNonQuery(q6);

            MessageBox.Show("Record has been saved.");
        }
    }
}
