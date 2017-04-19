using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.utils;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.data;
using KDTHK_MOULD_SYSTEM.forms.fixedasset;
using KDTHK_MOULD_SYSTEM.forms.quotation;

namespace KDTHK_MOULD_SYSTEM.forms
{
    public partial class MainView : UserControl
    {
        public event EventHandler NewItemEvent;

        public MainView()
        {
            InitializeComponent();

            SystemUtil.DoubleBuffered(dgvMain, true);

            this.LoadData(txtSearch.Text);

            this.LoadCriteria();
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();

            string query = string.Format("select st_namechin as status, m_chaseno as chaseno, m_vendor as vendor" +
                ", mv_name as vendorname, m_group as pgroup, m_itemcode as partno, m_rev as rev, m_mouldno as mould" +
                ", m_div as div, m_type as type, m_model as model, m_mouldcode as mouldcode, m_currency as currency" +
                ", m_amounthkd as hkd, m_mpa as mpa, m_fixedasset as fa, m_po as po, m_remarks as remarks " +
                " from TB_MOULD_MAIN, TB_STATUS, TB_MASTER_VENDOR where m_status = st_code" +
                " and m_vendor = mv_code and (mv_name like '%{0}%' or m_group like '%{0}%' or m_itemcode like '%{0}%'" +
                " or m_mouldno like '%{0}%' or m_po like '%{0}%' or m_remarks like N'%{0}%')", source);

            GlobalService.Adapter = new System.Data.SqlClient.SqlDataAdapter(query, DataService.GetInstance().Connection);
            GlobalService.Adapter.Fill(table);

            dgvMain.DataSource = table;
        }

        private void LoadCriteria()
        {
            foreach (string criteria in Criteria.CriteriaList())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(criteria);
                item.BackgroundImage = Properties.Resources.temp;
                item.Tag = criteria;
                item.Click += new EventHandler(item_Click);
                tsbtnCriteria.DropDownItems.Add(item);
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            tsbtnCriteria.Text = item.Tag.ToString();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(txtSearch.Text);
        }

        private void dgvMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvMain.SelectedRows.Count == 1)
                {
                    var hti = dgvMain.HitTest(e.X, e.Y);
                    dgvMain.ClearSelection();
                    if (((dgvMain.Rows[0].Height * dgvMain.Rows.Count) + dgvMain.ColumnHeadersHeight) >= e.Location.Y)
                        dgvMain.Rows[hti.RowIndex].Selected = true;
                }
                else
                {
                    var hti = dgvMain.HitTest(e.X, e.Y);
                    if (((dgvMain.Rows[0].Height * dgvMain.Rows.Count) + dgvMain.ColumnHeadersHeight) >= e.Location.Y)
                        dgvMain.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void menuStrip_Opening(object sender, CancelEventArgs e)
        {
            menuStrip.Items[0].Enabled = dgvMain.SelectedRows.Count > 1 ? false : true;
            menuStrip.Items[2].Enabled = dgvMain.SelectedRows.Count > 1 ? false : true;
            menuStrip.Items[3].Enabled = dgvMain.SelectedRows.Count > 1 ? false : true;

            if (dgvMain.SelectedRows.Count == 1)
            {
                string fa = dgvMain.SelectedRows[0].Cells[15].Value.ToString();
                menuStrip.Items[2].Enabled = fa != "" ? true : false;
            }
        }

        private void modifyMouldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chaseNo = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            string mouldNo = dgvMain.SelectedRows[0].Cells[7].Value.ToString();
            string partNo = dgvMain.SelectedRows[0].Cells[5].Value.ToString();
            string rev = dgvMain.SelectedRows[0].Cells[6].Value.ToString();
            string div = dgvMain.SelectedRows[0].Cells[8].Value.ToString();
            string model = dgvMain.SelectedRows[0].Cells[10].Value.ToString();
            string amount = dgvMain.SelectedRows[0].Cells[13].Value.ToString();
            string status = dgvMain.SelectedRows[0].Cells[0].Value.ToString();
            string remarks = dgvMain.SelectedRows[0].Cells[17].Value.ToString();
            string vendor = dgvMain.SelectedRows[0].Cells[2].Value.ToString();
            string mouldCode = dgvMain.SelectedRows[0].Cells[11].Value.ToString();

            QuotationEdit formEdit = new QuotationEdit(chaseNo, mouldNo, partNo, rev, div, model, amount, status, remarks, vendor, mouldCode, "Modify");
            if (formEdit.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chaseNo = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            string mouldNo = dgvMain.SelectedRows[0].Cells[7].Value.ToString();
            string partNo = dgvMain.SelectedRows[0].Cells[5].Value.ToString();
            string rev = dgvMain.SelectedRows[0].Cells[6].Value.ToString();
            string div = dgvMain.SelectedRows[0].Cells[8].Value.ToString();
            string model = dgvMain.SelectedRows[0].Cells[10].Value.ToString();
            string amount = dgvMain.SelectedRows[0].Cells[13].Value.ToString();
            string status = dgvMain.SelectedRows[0].Cells[0].Value.ToString();
            string remarks = dgvMain.SelectedRows[0].Cells[17].Value.ToString();
            string vendor = dgvMain.SelectedRows[0].Cells[2].Value.ToString();
            string mouldCode = dgvMain.SelectedRows[0].Cells[11].Value.ToString();

            QuotationEdit formEdit = new QuotationEdit(chaseNo, mouldNo, partNo, rev, div, model, amount, status, remarks, vendor, mouldCode, "Edit");
            if (formEdit.ShowDialog() == DialogResult.OK)
                this.LoadData(txtSearch.Text);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected records?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    foreach (DataGridViewRow row in dgvMain.SelectedRows)
                    {
                        string chaseNo = row.Cells[1].Value.ToString();

                        string delText = string.Format("delete from TB_MOULD_MAIN where mm_chaseno = '{0}'", chaseNo);
                        DataService.GetInstance().ExecuteNonQuery(delText);

                        LogUtils.SaveLog("Mould", chaseNo, GlobalService.Owner, "Record deleted");
                    }
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void MenuItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string tag = item.Tag.ToString();

            string chaseNo = dgvMain.SelectedRows[0].Cells[1].Value.ToString();
            string vendor = dgvMain.SelectedRows[0].Cells[2].Value.ToString();
            string mpa = dgvMain.SelectedRows[0].Cells[14].Value.ToString();
            string fixedAsset = dgvMain.SelectedRows[0].Cells[15].Value.ToString();
            string itemText = Mould.GetItemText(chaseNo);

            FaCancelForm form = new FaCancelForm(tag, fixedAsset, vendor, chaseNo, itemText, mpa);
            form.ShowDialog();
        }
    }
}
