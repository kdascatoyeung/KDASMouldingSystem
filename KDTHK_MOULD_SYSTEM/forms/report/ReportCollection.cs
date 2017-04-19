using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.output;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.import;
using CustomUtil.utils.buffer;

namespace KDTHK_MOULD_SYSTEM.forms.report
{
    public partial class ReportCollection : UserControl
    {
        public event EventHandler ToCdReportEvent;
        public event EventHandler ToModifyRecordEvent;
        public event EventHandler ToPaymentEvent;
        public event EventHandler ToBaseEvent;

        public ReportCollection()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvCollection, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mm_passremarks as pstatus, mm_passdate as pdate, mm_collectdate as cdate" +
                ", s_status as status, mm_vendorcode as vendor, mv_name as name, mv_group as pgroup, mm_model as model" +
                ", mm_mouldno as mould, mm_itemcode as partno, mm_rev as rev, mm_div as div, mm_amounthkd as hkd" +
                ", mm_po as po, mm_poissued as issued from TB_MOULD_MAIN, TB_STATUS, TB_MASTER_VENDOR where" +
                " mm_vendorcode = mv_code and mm_status_code = s_code and (mm_status_code = 'K' or mm_status_code = 'P'" +
                " or mm_status_code = 'HS' or mm_status_code = 'PR') and (mm_vendorcode like '%{0}%' or mv_name like '%{0}%'" +
                " or mv_group like '%{0}%' or mm_model like '%{0}%' or mm_mouldno like '%{0}%' or mm_po like '%{0}%')", source);

            //GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            //GlobalService.Adapter.Fill(tb);

            //dgvCollection.DataSource = tb;
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

                case "modify":
                    if (ToModifyRecordEvent != null)
                        ToModifyRecordEvent(this, new EventArgs());
                    break;

                case "payment":
                    if (ToPaymentEvent != null)
                        ToPaymentEvent(this, new EventArgs());
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
            DataTable output = new DataTable();
            ExcelUtil.SaveExcel(output, "PO Collection");
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|" +
                    "All Excel Types|*.xls;*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ofd.FileName.EndsWith(".xls") ? ImportExcel2003.TranslateToTable(ofd.FileName) : ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {

                }
            }
        }
    }
}
