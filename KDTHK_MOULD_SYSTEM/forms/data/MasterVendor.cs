using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.data;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.export;
using KDTHK_MOULD_SYSTEM.output;
using CustomUtil.utils.import;
using CustomUtil.utils.buffer;

namespace KDTHK_MOULD_SYSTEM.forms.data
{
    public partial class MasterVendor : UserControl
    {
        public event EventHandler MouldCodeSwitchEvent;
        public event EventHandler OemSwitchEvent;

        public MasterVendor()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvVendor, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mv_code as vendor, mv_name as name, mv_group as pgroup" +
                ", mv_paycurr as cur, mv_payterms as terms, mv_request as request, mv_edi as edi, mv_remarks as remarks" +
                " from TB_MASTER_VENDOR where (mv_code like N'%{0}%' or mv_name like N'%{0}%' or mv_group like N'%{0}%'" +
                " or mv_payterms like N'%{0}%' or mv_edi like '%{0}%' or mv_remarks like N'%{0}%')", source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(tb);

            dgvVendor.DataSource = tb;
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

        private void dgvVendor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVendor.SelectedRows == null)
                return;

            string vendor = dgvVendor.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvVendor.SelectedRows[0].Cells[1].Value.ToString();
            string pGroup = dgvVendor.SelectedRows[0].Cells[2].Value.ToString();
            string currency = dgvVendor.SelectedRows[0].Cells[3].Value.ToString();
            string payTerms = dgvVendor.SelectedRows[0].Cells[4].Value.ToString();
            string request = dgvVendor.SelectedRows[0].Cells[5].Value.ToString();
            string edi = dgvVendor.SelectedRows[0].Cells[6].Value.ToString();
            string remarks = dgvVendor.SelectedRows[0].Cells[7].Value.ToString();

            string region = Vendor.GetVendorRegion(vendor);

            MasterVendorInput input = new MasterVendorInput("edit", vendor, name, currency, pGroup, payTerms, region, request, edi, remarks);
            if (input.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
        }

        private void mouldCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MouldCodeSwitchEvent != null)
                MouldCodeSwitchEvent(this, new EventArgs());
        }

        private void oEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OemSwitchEvent != null)
                OemSwitchEvent(this, new EventArgs());
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            MasterVendorInput input = new MasterVendorInput("new", "", "", "", "", "", "", "", "", "");
            if (input.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
        }

        private void tsbtnTemplate_Click(object sender, EventArgs e)
        {
            DataTable template = new DataTable();
            string[] headers = { "Vendor", "Name", "Pur.G", "Currency", "Pay Terms", "Region", "Request", "EDI", "Remarks" };
            foreach (string header in headers)
                template.Columns.Add(header);

            ExportExcelUtil.ExportExcel(template);
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
                    string vendor = row.ItemArray[0].ToString();
                    string name = row.ItemArray[1].ToString();
                    string pGroup = row.ItemArray[2].ToString();
                    string currency = row.ItemArray[3].ToString();
                    string payTerms = row.ItemArray[4].ToString();
                    string region = row.ItemArray[5].ToString();
                    string request = row.ItemArray[6].ToString();
                    string edi = row.ItemArray[7].ToString();
                    string remarks = row.ItemArray[8].ToString();

                    string query = string.Format("if not exists (select * from TB_MASTER_VENDOR where mv_code = '{0}')" +
                        " insert into TB_MASTER_VENDOR (mv_code, mv_name, mv_group, mv_detail, mv_paycurr" +
                        ", mv_payterms, mv_request, mv_edi, mv_remarks) values ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', N'{8}')" +
                        " else update TB_MASTER_VENDOR set mv_name = N'{1}', mv_group = '{2}', mv_detail = '{3}'" +
                        ", mv_paycurr = '{4}', mv_payterms = '{5}', mv_request = '{6}', mv_edi = '{7}', mv_remarks = N'{8}'" +
                        " where mv_code = '{0}'", vendor, name, pGroup, region, currency, payTerms, request, edi, remarks);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
                this.LoadData(txtSearch.Text);
            }
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = (DataTable)dgvVendor.DataSource;
            ExcelUtil.SaveExcel(output, "Vendor");
        }
    }
}
