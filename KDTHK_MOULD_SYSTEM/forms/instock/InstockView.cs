using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.data;
using CustomUtil.utils.buffer;
using KDTHK_MOULD_SYSTEM.utils;

namespace KDTHK_MOULD_SYSTEM.forms.instock
{
    public partial class InstockView : UserControl
    {
        public event EventHandler SaveEvent;

        string _po = "";

        bool isChecked = false;

        public InstockView()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvInstock, true);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            btnCheck.Enabled = dgvInstock.Rows.Count > 0 ? true : false;
            btnReceive.Enabled = isChecked ? true : false;
            btnNext.Enabled = ckb1po.Checked || ckb1st50.Checked || ckb2nd50.Checked
                || ckb2po.Checked || ckbNormal.Checked || ckbTransfer.Checked ? true : false;
            btnSave.Enabled = _po != "" ? true : false;
        }

        private void LoadMouldSpec(string po)
        {
            string query = string.Format("select mm_checkdate, mm_cav, mm_weight, mm_accessory, mm_camera" +
                ", mm_vertical, mm_horizontal, mm_height, mm_instockremarks from TB_MOULD_MAIN" +
                " where mm_po = '{0}'", po);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    txtCheckDate.Text = GlobalService.Reader.GetString(0);
                    txtCav.Text = GlobalService.Reader.GetString(1);
                    txtWeight.Text = GlobalService.Reader.GetString(2);
                    txtEquipment.Text = GlobalService.Reader.GetString(3);
                    txtCamera.Text = GlobalService.Reader.GetString(4);
                    txtLength.Text = GlobalService.Reader.GetString(5);
                    txtWidth.Text = GlobalService.Reader.GetString(6);
                    txtHeight.Text = GlobalService.Reader.GetString(7);
                    txtRemarks.Text = GlobalService.Reader.GetString(8);
                }
            }
        }

        bool isExtended = true;

        private void btnUpDown_Click(object sender, EventArgs e)
        {
            if (isExtended)
            {
                pnlSpec.Height = 30;
                btnUpDown.BackgroundImage = Properties.Resources.arrow_down;
                isExtended = false;
            }
            else
            {
                pnlSpec.Height = 118;
                btnUpDown.BackgroundImage = Properties.Resources.arrow_up;
                isExtended = true;
            }
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string checkDate = txtCheckDate.Text;
            string cav = txtCav.Text;
            string weight = txtWeight.Text;
            string equipment = txtEquipment.Text;
            string camera = txtCamera.Text;
            string length = txtLength.Text;
            string width = txtWidth.Text;
            string height = txtHeight.Text;
            string remarks = txtRemarks.Text;

            string query = string.Format("update TB_MOULD_MAIN set mm_checkdate = '{0}', mm_cav = '{1}', mm_weight = '{2}'" +
               ", mm_accessory = '{3}', mm_camera = '{4}', mm_vertical = '{5}', mm_horizontal = '{6}', mm_height = '{7}', mm_instockremarks = N'{8}'" +
               " where mm_po = '{9}'", checkDate, cav, weight, equipment, camera, length, width, height, remarks, _po);

            DataService.GetInstance().ExecuteNonQuery(query);
        }

        bool isValid = true;

        private void InputPO()
        {
            isValid = true;

            if (!PO.IsPOValid(txtInputPO.Text))
            {
                isValid = false;
                this.Refresh();
                MessageBox.Show("Invalid PO.");
                return;
            }

            this.Refresh();

            _po = txtInputPO.Text;

            this.LoadMouldSpec(txtInputPO.Text);

            if (PO.IsPOMpa(txtInputPO.Text))
            {
                ckbNormal.Enabled = false;
                ckbTransfer.Enabled = false;

                string stock50 = PO.GetInStock50ByPo(txtInputPO.Text);

                ckb1st50.Enabled = stock50 == "Yes" ? true : false;
                ckb2nd50.Enabled = stock50 == "Yes" ? false : true;
                ckb1po.Enabled = stock50 == "Yes" ? true : false;
                ckb2po.Enabled = stock50 == "Yes" ? true : false;
            }
            else
            {
                string division = PO.GetDivByPo(txtInputPO.Text);

                ckbNormal.Enabled = division != "New" && division != "Modify" ? false : true;
                ckbTransfer.Enabled = division != "New" && division != "Modify" ? false : true;

                ckb1st50.Enabled = false;
                ckb2nd50.Enabled = false;
                ckb1po.Enabled = false;
                ckb2po.Enabled = false;
            }
        }

        private void txtInputPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                InputPO();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InputPO();
        }

        private void InstockView_Paint(object sender, PaintEventArgs e)
        {
            if (isValid)
            {
                bdSearch.BorderWidth = 1;
                bdSearch.BorderColor = Color.Silver;
            }
            else
            {
                bdSearch.BorderWidth = 2;
                bdSearch.BorderColor = Color.Red;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string option = ckbNormal.Checked ? ckbNormal.Text :
                ckb1st50.Checked ? ckb1st50.Text :
                ckb2nd50.Checked ? ckb2nd50.Text :
                ckb1po.Checked ? ckb1po.Text :
                ckb2po.Checked ? ckb2po.Text :
                ckbTransfer.Text;

            string vendor = PO.GetVendorCodeByPo(_po);
            string name = Vendor.GetVendorName(vendor);

            string inStock50 = ckbNormal.Checked ? "-----" :
                ckb1st50.Checked ? "Received" :
                ckb2nd50.Checked ? PO.GetInStock50ByPo(_po) :
                ckb1po.Checked ? "一回合格入庫" :
                ckb2po.Checked ? "已拆單、以合格同時入庫" :
                "-----";
            string inStockDate = ckbNormal.Checked ? "Received" :
                ckb1st50.Checked ? "#N/A" :
                ckb2nd50.Checked ? "Received" :
                ckb1po.Checked ? "Received" :
                ckb2po.Checked ? "Received" :
                DateTime.Today.ToString("yyyy/MM/dd");

            dgvInstock.Rows.Add(Properties.Resources.cross, _po, vendor, name, option, inStock50, inStockDate, "---");
        }

        private void dgvInstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                dgvInstock.Rows.Remove(dgvInstock.CurrentRow);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInstock.Rows)
            {
                string po = row.Cells[1].Value.ToString();
                string vendor = row.Cells[2].Value.ToString();
                string inStock50 = row.Cells[5].Value.ToString();
                string inStock = row.Cells[6].Value.ToString();

                string payTerm = Vendor.GetVendorPayTerm(vendor);

                string query = "";

                if (SystemUtil.IsDateFormat(inStock))
                {
                    string payMonth = payTerm == "HK01" ? Convert.ToDateTime(inStock).AddMonths(1).ToString("yyyy/MM/dd")
                        : Convert.ToDateTime(inStock).AddMonths(2).ToString("yyyy/MM/dd");

                    query = string.Format("update TB_MOULD_MAIN set mm_status_code = 'S', mm_instockdate50 = '{0}'" +
                        ", mm_instockdate = '{1}', mm_paydate = '{2}' where mm_po = '{3}'", inStock50, inStock, payMonth, po);
                }

                else if (!SystemUtil.IsDateFormat(inStock) && SystemUtil.IsDateFormat(inStock50))
                {
                    string payMonth = payTerm == "HK01" ? Convert.ToDateTime(inStock50).AddMonths(1).ToString("yyyy/MM/dd")
                        : Convert.ToDateTime(inStock50).AddMonths(2).ToString("yyyy/MM/dd");
                    
                    query = string.Format("update TB_MOULD_MAIN set mm_status_code = 'HS', mm_instockdate50 = '{0}'" +
                        ", mm_paydate = '{1}' where mm_po = '{2}'", inStock50, payMonth, po);
                }

                else
                {
                    query = string.Format("update TB_MOULD_MAIN set mm_status_code = 'PR', mm_instockdate50 = '{0}'" +
                        ", mm_instockdate = '{1}' where mm_po = '{2}'", inStock50, inStock, po);
                }

                DataService.GetInstance().ExecuteNonQuery(query);

                if (SaveEvent != null)
                    SaveEvent(this, new EventArgs());
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            isChecked = true;

            foreach (DataGridViewRow row in dgvInstock.Rows)
            {
                string inStock50 = row.Cells[5].Value.ToString();
                string inStock = row.Cells[6].Value.ToString();

                if (SystemUtil.IsDateFormat(inStock))
                    row.Cells[7].Value = "入庫済";

                else if (!SystemUtil.IsDateFormat(inStock) && SystemUtil.IsDateFormat(inStock50))
                    row.Cells[7].Value = "已付 50% MPA";

                else
                    row.Cells[7].Value = "已回收";
            }
        }
    }
}
