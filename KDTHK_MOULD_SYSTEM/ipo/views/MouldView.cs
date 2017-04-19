using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.utils;

namespace KDTHK_MOULD_SYSTEM.ipo.views
{
    public partial class MouldView : UserControl
    {
        public event EventHandler EditEvent;

        DataTable table = new DataTable();

        public MouldView()
        {
            InitializeComponent();

            table = InitialTable();

            this.LoadCriteria();

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            msMain.Enabled = dgvMain.SelectedRows.Count > 0 ? true : false;
        }

        private List<string> CriteriaList()
        {
            List<string> list = new List<string>();

            string query = "select distinct c_criteria from TB_CRITERIA";
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                    list.Add(GlobalService.Reader.GetString(0));
            }

            return list;
        }

        private void LoadCriteria()
        {
            foreach (string criteria in CriteriaList())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(criteria);
                item.BackgroundImage = Properties.Resources.temp;
                item.Tag = criteria;
                item.Click += new EventHandler(item_Click);
                tsbtnCriteria.DropDownItems.Add(item);
            }
        }

        private List<string> ColumnList(string criteria)
        {
            List<string> list = new List<string>();

            string query = string.Format("select c_column from TB_CRITERIA where c_criteria = N'{0}' group by c_criteria, c_column", criteria);

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    list.Add(reader.GetString(0).Trim());
            }

            return list;
        }

        private void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            tsbtnCriteria.Text = item.Tag.ToString();

            List<string> list = ColumnList(item.Tag.ToString());

            foreach (DataGridViewColumn column in dgvMain.Columns)
            {
                if (list.Contains(column.DataPropertyName.ToString()))
                    column.Visible = true;
                else
                    column.Visible = false;
            }
        }

        private DataTable InitialTable()
        {
            DataTable table = new DataTable();
            string[] headers = {"st", "chaseno", "vendor", "vendorname", "pgroup", "partno", "rev", "mouldno", "div", "type", "currency", "amount", "amounthkd",
                                   "mpa", "fa", "fatmp", "ringi", "itemtext", "projecttext", "model", "mouldcode", "po", "issued", "category", "pcs", "modify", "remarks",
                                   "oem", "accountcode", "costcenter", "instock50", "instock", "checkdate", "cav", "weight", "accessory", "shot", "length", "width", "height",
                                   "instockremarks", "created", "createdby"};

            foreach (string header in headers)
                table.Columns.Add(header);

            return table;
        }

        private void LoadData(string source)
        {
            table = InitialTable();

            string query = string.Format("select st_namechin as st, m_chaseno as chaseno, m_vendor as vendor, mv_name as vendorname, mv_group as pgroup" +
                ", m_itemcode as partno, m_rev as rev, m_mouldno as mouldno, m_div as div, m_type as type, m_currency as currency, m_amount as amount" +
                ", m_amounthkd as amounthkd, m_mpa as mpa, m_fixedasset as fa, m_tmpfixedasset as fatmp, m_ringi as ringi, m_itemtext as itemtext" +
                ", m_projecttext as projecttext, m_model as model, m_mouldcode as mouldcode, m_po as po, m_poissued as issued, m_category as category" +
                ", m_pcs as pcs, m_modify as modify, m_remarks as remarks, m_oem as oem, m_accountcode as accountcode, m_costcenter as costcenter" +
                ", m_instock50 as instock50, m_instock as instock, m_checkdate as checkdate, m_cav as cav, m_weight as weight, m_accessory as accessory" +
                ", m_camera as shot, m_vertical as vertical, m_horizontal as horizontal, m_height as height, m_instockremarks as instockremarks, m_created as created" +
                ", m_createdby as createdby from TB_MOULD_MAIN, TB_STATUS, TB_MASTER_VENDOR where m_vendor = mv_code and m_status = st_code" +
                " and (m_itemcode like '%{0}%' or m_mouldno like '%{0}%' or mv_name like '%{0}%' or m_po like '%{0}%')", source);

            SqlDataAdapter sda = new SqlDataAdapter(query, DataService.GetInstance().Connection);
            sda.Fill(table);

            dgvMain.DataSource = table;
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

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalService.EditList = new List<lists.QuotationEditList>();

            foreach (DataGridViewRow row in dgvMain.SelectedRows)
            {
                string chaseNo = row.Cells[1].Value.ToString().Trim();
                string status = row.Cells[2].Value.ToString().Trim();
                string mouldNo = row.Cells[7].Value.ToString().Trim();
                string partNo = row.Cells[5].Value.ToString().Trim();
                string rev = row.Cells[6].Value.ToString().Trim();
                string div = row.Cells[8].Value.ToString().Trim();
                string amount = row.Cells[12].Value.ToString().Trim();
                string model = row.Cells[19].Value.ToString().Trim();
                string itemText = row.Cells[17].Value.ToString().Trim();
                string modify = row.Cells[25].Value.ToString().Trim();
                string pcs = row.Cells[24].Value.ToString().Trim();
                string pbase = DataUtil.GetProductionBase(chaseNo);
                string remarks = row.Cells[26].Value.ToString();
                string mouldCode = row.Cells[20].Value.ToString().Trim();
                string vendor = row.Cells[2].Value.ToString().Trim();
                string pgroup = row.Cells[4].Value.ToString().Trim();
                string oem = row.Cells[27].Value.ToString().Trim();
                string accountCode = row.Cells[28].Value.ToString().Trim();
                string costCenter = row.Cells[29].Value.ToString().Trim();

                GlobalService.EditList.Add(new lists.QuotationEditList
                {
                    ChaseNo = chaseNo,
                    MouldNo = mouldNo,
                    PartNo = partNo,
                    Rev = rev,
                    Div = div,
                    Amount = amount,
                    Model = model,
                    Modify = modify,
                    Pcs = pcs,
                    Base = pbase,
                    Remarks = remarks,
                    MouldCode = mouldCode,
                    Vendor = vendor,
                    PurGroup = pgroup,
                    Oem = oem,
                    AccountCode = accountCode,
                    CostCenter = costCenter
                });
            }

            if (EditEvent != null)
                EditEvent(this, new EventArgs());
        }

        private void dgvMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvMain.Rows.Count > 0)
            {
                if (((dgvMain.Rows[0].Height * dgvMain.Rows.Count) + dgvMain.ColumnHeadersHeight) < e.Location.Y)
                    dgvMain.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvMain.HitTest(e.X, e.Y);

                        if (dgvMain.SelectedRows.Count == 1)
                        {
                            dgvMain.ClearSelection();

                            if (((dgvMain.Rows[0].Height * dgvMain.Rows.Count) + dgvMain.ColumnHeadersHeight) >= e.Location.Y)
                                dgvMain.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvMain.Rows[0].Height * dgvMain.Rows.Count) + dgvMain.ColumnHeadersHeight) >= e.Location.Y)
                                dgvMain.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }


    }
}
