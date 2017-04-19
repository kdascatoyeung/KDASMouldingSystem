using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.utils;
using CustomUtil.utils.export;
using KDTHK_MOULD_SYSTEM.output;
using CustomUtil.utils.import;
using CustomUtil.utils.buffer;

namespace KDTHK_MOULD_SYSTEM.forms.data
{
    public partial class MasterOem : UserControl
    {
        public event EventHandler MouldCodeSwitchEvent;
        public event EventHandler VendorSwitchEvent;

        public MasterOem()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvOem, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            DataTable tb = new DataTable();

            string query = string.Format("select mo_code as code, mo_content as content, mo_accountcode as accountcode" +
                ", mo_costcentre as costcentre, mo_remarks as remarks from TB_MASTER_OEM" +
                " where (mo_code like N'%{0}%' or mo_content like N'%{0}%' or mo_remarks like '%{0}%')", source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(tb);

            dgvOem.DataSource = tb;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
                this.LoadData(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData(txtSearch.Text);
        }

        private void dgvOem_DoubleClick(object sender, EventArgs e)
        {
            if (dgvOem.SelectedRows == null)
                return;

            string code = dgvOem.SelectedRows[0].Cells[0].Value.ToString();
            string content = dgvOem.SelectedRows[0].Cells[1].Value.ToString();
            string accountCode = dgvOem.SelectedRows[0].Cells[2].Value.ToString();
            string costCentre = dgvOem.SelectedRows[0].Cells[3].Value.ToString();
            string remarks = dgvOem.SelectedRows[0].Cells[4].Value.ToString();

            MasterOemInput input = new MasterOemInput("edit", code, content, accountCode, costCentre, remarks);
            if (input.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
        }

        private void mouldCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MouldCodeSwitchEvent != null)
                MouldCodeSwitchEvent(this, new EventArgs());
        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VendorSwitchEvent != null)
                VendorSwitchEvent(this, new EventArgs());
        }

        private void tsbtnNew_Click(object sender, EventArgs e)
        {
            MasterOemInput input = new MasterOemInput("new", "", "", "", "", "");
            if (input.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
        }

        private void tsbtnTemplate_Click(object sender, EventArgs e)
        {
            DataTable template = new DataTable();
            string[] headers = { "Code", "Content", "Account Code", "Cost Centre", "Remarks" };
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
                    string code = row.ItemArray[0].ToString();
                    string content = row.ItemArray[1].ToString();
                    string accountCode = row.ItemArray[2].ToString();
                    string costCentre = row.ItemArray[3].ToString();
                    string remarks = row.ItemArray[4].ToString();

                    string query = string.Format("if not exists (select * from TB_MASTER_OEM where mo_code = '{0}')" +
                        " insert into TB_MASTER_OEM (mo_code, mo_content, mo_accountcode, mo_costcentre, mo_remarks)" +
                        " values ('{0}', N'{1}', '{2}', '{3}', N'{4}') else update TB_MASTER_OEM set mo_content = N'{1}', mo_accountcode = '{2}'" +
                        ", mo_costcentre = '{3}', mo_remarks = N'{4}' where mo_code = '{0}'", code, content, accountCode, costCentre, remarks);

                    DataService.GetInstance().ExecuteNonQuery(query);
                }
            }

            this.LoadData(txtSearch.Text);
        }

        private void tsbtnDownload_Click(object sender, EventArgs e)
        {
            DataTable output = (DataTable)dgvOem.DataSource;
            ExcelUtil.SaveExcel(output, "OEM");
        }

        private void dgvOem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                switch (MessageBox.Show("Are you sure to delete selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:

                        string code = dgvOem.SelectedRows[0].Cells[0].Value.ToString();
                        string delText = string.Format("delete from TB_MASTER_OEM where mo_code = '{0}'", code);
                        DataService.GetInstance().ExecuteNonQuery(delText);

                        LogUtils.SaveLog("OEM", "-", GlobalService.Owner, "Delete record " + code);
            
                        MessageBox.Show("Record has been deleted.");
                        this.LoadData(txtSearch.Text);
                        break;

                    case DialogResult.No:
                        break;
                }
            }
        }

        
    }
}
