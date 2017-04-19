using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.export;
using KDTHK_MOULD_SYSTEM.output;
using CustomUtil.utils.import;
using CustomUtil.utils.buffer;

namespace KDTHK_MOULD_SYSTEM.forms.data
{
    public partial class MasterMouldCode : UserControl
    {
        public event EventHandler VendorSwitchEvent;
        public event EventHandler OemSwitchEvent;

        public MasterMouldCode()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvMouldCode, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mc_code as mouldcode, mc_type as type, mc_contentjp as contentjp, mc_contenteng as contenteng" +
                ", mc_contentchin as contentchin, mc_itemgroup as itemgroup from TB_MASTER_MOULDCODE where (mc_code like N'%{0}%'" +
                " or mc_type like N'%{0}%' or mc_contentjp like N'%{0}%' or mc_contenteng like N'%{0}%'" +
                " or mc_contentchin like N'%{0}%')", source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(tb);

            dgvMouldCode.DataSource = tb;
        }

        private void dgvMouldCode_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMouldCode.SelectedRows == null)
                return;

            string mouldCode = dgvMouldCode.SelectedRows[0].Cells[0].Value.ToString();
            string type = dgvMouldCode.SelectedRows[0].Cells[1].Value.ToString();
            string jp = dgvMouldCode.SelectedRows[0].Cells[2].Value.ToString();
            string eng = dgvMouldCode.SelectedRows[0].Cells[3].Value.ToString();
            string chin = dgvMouldCode.SelectedRows[0].Cells[4].Value.ToString();
            string itemGroup = dgvMouldCode.SelectedRows[0].Cells[5].Value.ToString();

            MasterMouldCodeInput input = new MasterMouldCodeInput("edit", mouldCode, type, jp, eng, chin, itemGroup);
            if (input.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
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

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            MasterMouldCodeInput input = new MasterMouldCodeInput("new", "", "", "", "", "", "");
            if (input.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
        }

        private void tsbtnTemplate_Click(object sender, EventArgs e)
        {
            DataTable template = new DataTable();
            string[] headers = { "Mould Code", "Type", "Content (Jp)", "Content (Eng)", "Content (Chin)", "Item Group" };
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
                    string mouldCode = row.ItemArray[0].ToString();
                    string type = row.ItemArray[1].ToString();
                    string jp = row.ItemArray[2].ToString();
                    string eng = row.ItemArray[3].ToString();
                    string chin = row.ItemArray[4].ToString();
                    string itemGroup = row.ItemArray[5].ToString();

                    string query = string.Format("if not exists (select * from TB_MASTER_MOULDCODE where mc_code = '{0}')" +
                        " insert into TB_MASTER_MOULDCODE (mc_code, mc_type, mc_contentjp, mc_contenteng, mc_contentchin, mc_itemgroup)" +
                        " values ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}') else update TB_MASTER_MOULDCODE set mc_type = N'{1}'" +
                        ", mc_contentjp = N'{2}', mc_contenteng = N'{3}', mc_contentchin = N'{4}', mc_itemgroup = '{5}' where mc_code = '{0}'",
                        mouldCode, type, jp, eng, chin, itemGroup);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }
                this.LoadData(txtSearch.Text);
            }
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = (DataTable)dgvMouldCode.DataSource;
            ExcelUtil.SaveExcel(output, "Mould Code");
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VendorSwitchEvent != null)
                VendorSwitchEvent(this, new EventArgs());
        }

        private void oEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OemSwitchEvent != null)
                OemSwitchEvent(this, new EventArgs());
        }
    }
}
