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
using CustomUtil.utils.export;
using CustomUtil.utils.import;
using CustomUtil.utils.buffer;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.forms.po
{
    public partial class PoView : UserControl
    {
        public PoView()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvIssuePO, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            dgvIssuePO.Rows.Clear();

            string query = string.Format("select m_chaseno, m_mouldno, m_itemcode, m_rev, m_div" +
                ", m_vendor, mv_name, m_po from TB_MOULD_MAIN, TB_MASTER_VENDOR where" +
                " m_vendor = mv_code and (m_status = 'D' or m_status = 'T') and (m_chaseno like '%{0}%' or m_mouldno like '%{0}%'" +
                " or m_itemcode like '%{0}%' or m_vendor like '%{0}%' or mv_name like '%{0}%')", source);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string chaseno = GlobalService.Reader.GetString(0);
                    string mouldno = GlobalService.Reader.GetString(1);
                    string partno = GlobalService.Reader.GetString(2);
                    string rev = GlobalService.Reader.GetString(3);
                    string div = GlobalService.Reader.GetString(4);
                    string vendor = GlobalService.Reader.GetString(5);
                    string vendorname = GlobalService.Reader.GetString(6);
                    string po = GlobalService.Reader.GetString(7);

                    dgvIssuePO.Rows.Add(new object[] { chaseno, mouldno, partno, rev, div, vendor, vendorname, po });
                }
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

        private void tsbtnTemplate_Click(object sender, EventArgs e)
        {
            DataTable template = new DataTable();
            string[] headers = { "Chase No.", "Mould No.", "Part No.", "Rev", "Div", "Vendor", "Vendor Name", "Request No.", "PO" };
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
                    string chaseNo = row.ItemArray[0].ToString();
                    string requestNo = row.ItemArray[6].ToString();
                    string po = row.ItemArray[7].ToString();

                    if (po != "")
                    {
                        string today = DateTime.Today.ToString("yyyy/MM/dd");
                        string query = string.Format("update TB_MOULD_MAIN set mm_requestno = '{0}', mm_po = '{1}', mm_poissued = '{2}', mm_status_code = 'P' where mm_chaseno = '{3}'", requestNo, po, today, chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(query);
                    }
                }
                MessageBox.Show("Record has been saved.");
                this.LoadData(txtSearch.Text);
            }
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = new DataTable();
            string[] headers = { "Chase No.", "Mould No.", "Part No.", "Rev", "Div", "Vendor", "Vendor Name", "Request No.", "PO" };
            foreach (string header in headers)
                output.Columns.Add(header);

            foreach (DataGridViewRow row in dgvIssuePO.Rows)
            {
                string chaseNo = row.Cells[0].Value.ToString();
                string mouldNo = row.Cells[1].Value.ToString();
                string partNo = row.Cells[2].Value.ToString();
                string rev = row.Cells[3].Value.ToString();
                string div = row.Cells[4].Value.ToString();
                string vendor = row.Cells[5].Value.ToString().Length == 9 ? "0" + row.Cells[5].Value.ToString() : row.Cells[5].Value.ToString();
                string vendorName = row.Cells[6].Value.ToString();
                string requestNo = row.Cells[7].Value.ToString();

                output.Rows.Add(chaseNo, mouldNo, partNo, rev, div, vendor, vendorName, requestNo, "");
            }

            ExcelUtil.SaveExcel(output, "PO");
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvIssuePO.Rows)
            {
                string chaseNo = row.Cells[0].Value.ToString();
                string requestNo = row.Cells[7].Value.ToString();
                string po = row.Cells[8].Value.ToString();

                if (po != "")
                {
                    string today = DateTime.Today.ToString("yyyy/MM/dd");
                    string query = string.Format("update TB_MOULD_MAIN set mm_requestno = '{0}', mm_po = '{1}', mm_poissued = '{2}', mm_status_code = 'P' where mm_chaseno = '{3}'", requestNo, po, today, chaseNo);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }
            MessageBox.Show("Record has been saved.");
            this.LoadData(txtSearch.Text);
        }
    }
}
