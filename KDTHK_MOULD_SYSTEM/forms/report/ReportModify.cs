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
using KDTHK_MOULD_SYSTEM.output;

namespace KDTHK_MOULD_SYSTEM.forms.report
{
    public partial class ReportModify : UserControl
    {
        public event EventHandler ToCdReportEvent;
        public event EventHandler ToPaymentEvent;
        public event EventHandler ToCollectionEvent;
        public event EventHandler ToBaseEvent;

        public ReportModify()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvModifyRecord, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mm_vendorcode as vendor, mv_name as name, mv_group as pgroup" +
                ", mm_chaseno as chaseno, mm_mouldno as mould, mm_itemcode as partno, mm_rev as rev" +
                ", mm_div as div, mm_model as model, mm_amounthkd as hkd, mm_po as po, mm_instockdate as instock" +
                " from TB_MOULD_MAIN, TB_MASTER_VENDOR where mm_vendorcode = mv_code and mm_ismodify = 'True'" +
                " and (mm_vendorcode like '%{0}%' or mv_name like '%{0}%' or mv_group like '%{0}%' or mm_mouldno like '%{0}%'" +
                " or mm_itemcode like '%{0}%' or mm_model like '%{0}%' or mm_po like '%{0}%')", source);

            //GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            //GlobalService.Adapter.Fill(tb);

            //dgvModifyRecord.DataSource = tb;
        }

        private void SwitchView(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string tag = item.Tag.ToString();

            switch (tag)
            {
                case "cdreport":
                    if (ToCdReportEvent != null)
                        ToCdReportEvent(this, new EventArgs());
                    break;

                case "payment":
                    if (ToPaymentEvent != null)
                        ToPaymentEvent(this, new EventArgs());
                    break;

                case "collection":
                    if (ToCollectionEvent != null)
                        ToCollectionEvent(this, new EventArgs());
                    break;

                case "pbase":
                    if (ToBaseEvent != null)
                        ToBaseEvent(this, new EventArgs());
                    break;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData(txtSearch.Text);
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = (DataTable)dgvModifyRecord.DataSource;

            ExcelUtil.SaveExcel(output, "Modify Record");
        }
    }
}
