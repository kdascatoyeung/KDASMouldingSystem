using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.ipo.lists;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.ipo.views
{
    public partial class QuotationEditView : UserControl
    {
        public event EventHandler SavedEvent;

        public QuotationEditView(List<QuotationEditList> list)
        {
            InitializeComponent();

            this.LoadData(list);
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoadData(List<QuotationEditList> list)
        {
            foreach (QuotationEditList item in list)
                dgvInput.Rows.Add(item.ChaseNo, "---", item.MouldNo, item.PartNo, item.Rev, item.Vendor, item.PurGroup, item.Model, item.Div, item.MouldCode,
                    item.Amount, item.Remarks, item.Modify, item.Pcs, item.Oem, item.AccountCode, item.CostCenter);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvInput.EndEdit();

            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                string chaseno = row.Cells[0].Value.ToString();
                string status = row.Cells[1].Value.ToString();
                string mouldno = row.Cells[2].Value.ToString();
                string partno = row.Cells[3].Value.ToString();
                string rev = row.Cells[4].Value.ToString();
                string vendor = row.Cells[5].Value.ToString();
                string pgroup = row.Cells[6].Value.ToString();
                string model = row.Cells[7].Value.ToString();
                string div = row.Cells[8].Value.ToString();
                string mouldcode = row.Cells[9].Value.ToString();
                string amount = row.Cells[10].Value.ToString();
                string remarks = row.Cells[11].Value.ToString();
                string modify = row.Cells[12].Value.ToString();
                string pcs = row.Cells[13].Value.ToString();
                string oem = row.Cells[14].Value.ToString();
                string accountcode = row.Cells[15].Value.ToString();
                string costcenter = row.Cells[16].Value.ToString();

                string query = "";

                if (status != "---")
                {
                    decimal hkd = Convert.ToDecimal(amount);
                    string statuscode = hkd > 10000 ? "F" : "U";

                    query = string.Format("update TB_MOULD_MAIN set m_mouldno = '{0}', m_itemcode = '{1}', m_rev = '{2}', m_vendor = '{3}', m_group = '{4}', m_model = '{5}'" +
                        ", m_div = '{6}', m_mouldcode = '{7}', m_amounthkd = '{8}', m_remarks = N'{9}', m_modify = '{10}', m_pcs = '{11}', m_oem = '{12}', m_accountcode = '{13}'" +
                        ", m_costcenter = '{14}', m_status = '{15}' where m_chaseno = '{16}'", mouldno, partno, rev, vendor, pgroup, model, div, mouldcode, amount, remarks, modify, pcs, oem, accountcode, costcenter, statuscode, chaseno);
                }
                else
                {
                    query = string.Format("update TB_MOULD_MAIN set m_mouldno = '{0}', m_itemcode = '{1}', m_rev = '{2}', m_vendor = '{3}', m_group = '{4}', m_model = '{5}'" +
                        ", m_div = '{6}', m_mouldcode = '{7}', m_amounthkd = '{8}', m_remarks = N'{9}', m_modify = '{10}', m_pcs = '{11}', m_oem = '{12}', m_accountcode = '{13}'" +
                        ", m_costcenter = '{14}' where m_chaseno = '{15}'", mouldno, partno, rev, vendor, pgroup, model, div, mouldcode, amount, remarks, modify, pcs, oem, accountcode, costcenter, chaseno);
                }

                DataService.GetInstance().ExecuteNonQuery(query);
            }

            if (SavedEvent != null)
                SavedEvent(this, new EventArgs());
        }
    }
}
