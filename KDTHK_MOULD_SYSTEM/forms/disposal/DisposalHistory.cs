using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.buffer;
using KDTHK_MOULD_SYSTEM.output;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.forms.disposal
{
    public partial class DisposalHistory : UserControl
    {
        public event EventHandler SwitchRequestEvent;
        public event EventHandler SwitchProcessingEvent;

        public DisposalHistory()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvHistory, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select md_type as type, md_status as status, md_mouldno as mould" +
                ", md_itemcode as partno, md_vendor as vendor, md_vendorname as name from TB_MOULD_DISPOSAL" +
                " where (md_mouldno like '%{0}%' or md_itemcode like '%{0}%' or md_vendor like '%{0}%' or md_vendorname like '%{0}%')", source);

            //GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            //GlobalService.Adapter.Fill(tb);

            //dgvHistory.DataSource = tb;
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

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchRequestEvent != null)
                SwitchRequestEvent(this, new EventArgs());
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SwitchProcessingEvent != null)
                SwitchProcessingEvent(this, new EventArgs());
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = (DataTable)dgvHistory.DataSource;
            ExcelUtil.SaveExcel(output, "Disposal History");
        }
    }
}
