using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.buffer;
using KDTHK_MOULD_SYSTEM.data;

namespace KDTHK_MOULD_SYSTEM.forms.disposal
{
    public partial class DisposalView : UserControl
    {
        public event EventHandler SwitchProcessingEvent;
        public event EventHandler SwitchHistoryEvent;

        public DisposalView()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvDisposal, true);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnRequest.Enabled = dgvDisposal.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mm_vendorcode as vendor, mv_name as name, mm_chaseno as chaseno" +
                ", mm_mouldno as mould, mm_itemcode as partno, mm_rev as rev from TB_MOULD_MAIN, TB_MASTER_VENDOR" +
                " where mm_vendorcode = mv_code and mm_status_code = 'S' and (mm_vendorcode like '%{0}%' or mv_name like '%{0}%' or mm_mouldno like '%{0}%'" +
                " or mm_itemcode like '%{0}%')", source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(tb);

            dgvDisposal.DataSource = tb;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(txtSearch.Text);
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            this.LoadData(txtSearch.Text);
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchProcessingEvent != null)
                SwitchProcessingEvent(this, new EventArgs());
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchHistoryEvent != null)
                SwitchHistoryEvent(this, new EventArgs());
        }

        private void tsbtnRequest_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDisposal.SelectedRows)
            {
                string vendor = row.Cells[0].Value.ToString();
                string vendorName = row.Cells[1].Value.ToString();
                string chaseNo = row.Cells[2].Value.ToString();
                string mouldNo = row.Cells[3].Value.ToString();
                string partNo = row.Cells[4].Value.ToString();
                string rev = row.Cells[5].Value.ToString();

                string fixedAsset = Mould.GetFixedAssetCode(chaseNo);
                string saveFa = fixedAsset == "" ? "-" : fixedAsset;

                string query = string.Format("insert into TB_MOULD_DISPOSAL (md_type, md_status, md_chaseno, md_mouldno" +
                    ", md_itemcode, md_fixedasset, md_vendor, md_vendorname) values ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                    "-----", "調整依賴中", chaseNo, mouldNo, partNo, saveFa, vendor, vendorName);

                DataService.GetInstance().ExecuteNonQuery(query);

                string updateText = string.Format("update TB_MOULD_MAIN set mm_status_code = 'DP' where mm_chaseno = '{0}'", chaseNo);
                DataService.GetInstance().ExecuteNonQuery(updateText);
            }

            MessageBox.Show("Record has been saved. Please go to Processing view for further operations.");

            this.LoadData(txtSearch.Text);
        }
    }
}
