using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.output;
using CustomUtil.utils.buffer;

namespace KDTHK_MOULD_SYSTEM.forms.transfer
{
    public partial class TransferHistory : Form
    {
        public TransferHistory()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvHistory, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mt_tmno as tmno, mt_mouldno as mould, mt_itemcode as partno, mt_rev as rev" +
                ", mt_locationbefore as fromv, mt_locationafter as tov, mt_date as dt, mt_remarks as remarks from" +
                " TB_MOULD_TRANSFER where mt_mouldno like '%{0}%' or mt_itemcode like '%{0}%' or mt_locationbefore like '%{0}%'" +
                " or mt_locationafter like '%{0}%' or mt_remarks like '%{0}%'", source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(tb);

            dgvHistory.DataSource = tb;
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

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = (DataTable)dgvHistory.DataSource;
            ExcelUtil.SaveExcel(output, "Transfer History");
        }
    }
}
