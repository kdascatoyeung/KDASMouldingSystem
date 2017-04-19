using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.output;

namespace KDTHK_MOULD_SYSTEM.forms.report
{
    public partial class ReportBase : UserControl
    {
        public event EventHandler ToCdReportEvent;
        public event EventHandler ToModifyRecordEvent;
        public event EventHandler ToPaymentEvent;
        public event EventHandler ToCollectionEvent;

        bool isSelected = false;
        string _selected = "";

        public ReportBase()
        {
            InitializeComponent();
        }

        private void LoadData(string mode, string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mm_vendorcode as vendor, mv_name as name, mm_group as pgroup" +
                ", mm_mouldno as mould, mm_itemcode as partno, mm_rev as rev, mm_div as div, mm_model as model" +
                ", mm_amounthkd as hkd, mm_po as po, mm_instockdate as instock from TB_MOULD_MAIN, TB_MASTER_VENDOR" +
                " where mm_vendorcode = mv_code and mm_productbase = '{0}' and (mm_vendorcode like '%{1}%' or mv_name like '%{1}%'" +
                "or mv_group like '%{1}%' or mm_mouldno like '%{1}%' or mm_itemcode like '%{1}%' or mm_model like '%{1}%' or mm_po like '%{1}%')", mode, source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(tb);

            dgvBase.DataSource = tb;
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

                case "collection":
                    if (ToCollectionEvent != null)
                        ToCollectionEvent(this, new EventArgs());
                    break;
            }
        }

        private void tsbtnCN_Click(object sender, EventArgs e)
        {
            isSelected = true;
            _selected = "CN";

            tsbtnCN.ForeColor = Color.DarkOrange;
            tsbtnVN.ForeColor = Color.DimGray;

            this.LoadData("CN", txtSearch.Text);
        }

        private void tsbtnVN_Click(object sender, EventArgs e)
        {
            isSelected = true;
            _selected = "VN";

            tsbtnCN.ForeColor = Color.DimGray;
            tsbtnVN.ForeColor = Color.DarkOrange;

            this.LoadData("VN", txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isSelected)
                {
                    MessageBox.Show("Please select Production Base.");
                    return;
                }

                this.LoadData(_selected, txtSearch.Text);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                MessageBox.Show("Please select Production Base.");
                return;
            }

            this.LoadData(_selected, txtSearch.Text);
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = (DataTable)dgvBase.DataSource;
            ExcelUtil.SaveExcel(output, "Product Base - " + _selected);
        }
    }
}
