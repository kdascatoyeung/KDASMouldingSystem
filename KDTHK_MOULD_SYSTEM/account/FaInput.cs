using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using System.Diagnostics;
using KDTHK_MOULD_SYSTEM.account.form;
using KDTHK_MOULD_SYSTEM.utils;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class FaInput : UserControl
    {
        bool isSaved = false;
        bool isClicked = false;

        bool isInputOK = false;

        public FaInput()
        {
            InitializeComponent();

            this.LoadData("");

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            tsbtnGenerate.Enabled = dgvInput.Rows.Count > 0 ? true : false;
            tsbtnDelete.Enabled = dgvInput.Rows.Count > 0 ? true : false;
            //tsbtnSave.Enabled = dgvInput.SelectedRows.Count > 0 ? true : false;
        }

        private void LoadData(string source)
        {
            DataTable table = new DataTable();
            string[] headers = { "approval", "fixedasset", "assetclass", "apptype", "pdfid", "desc", "mpa", "link", "path", "chaseno", "id" };
            foreach (string header in headers)
                table.Columns.Add(header);

            string query = string.Format("select f_pdfid, f_desc, f_mpa, f_assetclass, f_attachment, f_chaseno, f_id, f_apptype from TB_FA_APPROVAL where f_status = 'Fixed Asset Input'" +
                " and (f_pdfid like '%{0}%' or f_desc like '%{0}%' or f_mpa like '%{0}%' or f_assetclass like '%{0}%')", source);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string mgtno = GlobalService.Reader.GetString(0);
                    string desc = GlobalService.Reader.GetString(1);
                    string mpa = GlobalService.Reader.GetString(2);
                    string assetClass = GlobalService.Reader.GetString(3);
                    string attachment = GlobalService.Reader.GetString(4);
                    string chaseNo = GlobalService.Reader.GetString(5);
                    int id = GlobalService.Reader.GetInt32(6);
                    string type = GlobalService.Reader.GetString(7);

                    table.Rows.Add("Please select", "", assetClass, type, mgtno, desc, mpa, "Attachment", attachment, chaseNo, id);
                }
            }

            dgvInput.DataSource = table;

            lblCount.Text = "Total: " + dgvInput.Rows.Count;
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            isSaved = false;
            this.LoadData("");
        }

        private void tsbtnApprove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                string fa = row.Cells[1].Value.ToString();

                if (!row.Cells[0].ReadOnly)
                    row.Cells[0].Value = "Approve";
                //if (fa.Length == 9 && !DataUtil.IsFixedAssetCodeExists(fa))
                   // row.Cells[0].Value = "Approve";
            }
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            isSaved = true;
            dgvInput.EndEdit();

            List<string> errorlist = new List<string>();

            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                string fa = row.Cells[1].Value.ToString().Trim();

                if (fa != "")
                    if (DataUtil.IsFixedAssetCodeExists(fa))
                        errorlist.Add(fa);
            }

            if (errorlist.Count > 0)
            {
                string error = string.Join(",", errorlist);
                MessageBox.Show("Repeat Fixed Asset Code found\n" + error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvInput.Rows)
                {
                    string approval = row.Cells[0].Value.ToString();
                    string fixedAsset = row.Cells[1].Value.ToString();
                    string chaseno = row.Cells[9].Value.ToString().Trim();
                    string id = row.Cells[10].Value.ToString();

                    string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                    if (approval == "Reject")
                    {
                        string text = string.Format("update TB_FA_APPROVAL set f_status = 'Asset Class Input', f_cm1stapp = '---', f_cm1stdate = '---', f_cm2ndapp = '---', f_cm2andate = '---' where f_id = '{0}'", id);
                        DataService.GetInstance().ExecuteNonQuery(text);
                    }

                    if (approval != "Approve")
                        continue;

                    if (fixedAsset == "")
                        continue;

                    string query = string.Format("update TB_FA_APPROVAL set f_status = 'Data Check', f_fixedasset = '{0}', f_cm1stapp = 'Approve'" +
                        ", f_cm1stdate = '{1}' where f_id = '{2}'", fixedAsset, now, id);
                    DataService.GetInstance().ExecuteNonQuery(query);

                    if (fixedAsset.StartsWith("16"))
                    {
                        string text = string.Format("update TB_FA_APPROVAL set f_faref = '{0}' where f_fixedasset like '4%' and f_chaseno = '{1}'", fixedAsset, chaseno);
                        DataService.GetInstance().ExecuteNonQuery(text);
                    }

                    if (fixedAsset.StartsWith("4"))
                    {
                        string text = string.Format("update TB_FA_APPROVAL set f_faref = '{0}' where f_fixedasset like '16%' and f_chaseno = '{1}'", fixedAsset, chaseno);
                        DataService.GetInstance().ExecuteNonQuery(text);
                    }
                }
            }
            this.LoadData("");
        }

        private void dgvInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
                Process.Start(dgvInput.CurrentRow.Cells[7].Value.ToString());
        }

        private void tsbtnGenerate_Click(object sender, EventArgs e)
        {
            FixedAssetGenerate form = new FixedAssetGenerate();
            if (form.ShowDialog() == DialogResult.OK)
            {
                int number = int.Parse(GlobalService.FixedAssetCode);

                List<int> tmplist = new List<int>();
                List<string> errorlist = new List<string>();

                number -= 1;

                foreach (DataGridViewRow row in dgvInput.Rows)
                {
                    number += 1;
                    Debug.WriteLine(number);
                    tmplist.Add(number);
                    //row.Cells[1].Value = number++;
                }

                foreach (int item in tmplist)
                {
                    if (DataUtil.IsFixedAssetCodeExists(item.ToString()))
                        errorlist.Add(item.ToString());
                }

                if (errorlist.Count > 0)
                {
                    string msg = string.Join(",\n", errorlist.ToArray());
                    MessageBox.Show("Repeat Fixed Asset Code found!\n" + msg);
                }
                else
                {
                    number = int.Parse(GlobalService.FixedAssetCode);

                    number -= 1;
                    foreach (DataGridViewRow row in dgvInput.Rows)
                    {
                        number += 1;
                        row.Cells[0].ReadOnly = false;
                        row.Cells[1].Value = number;
                    }
                }
            }
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            this.LoadData(tstxtSearch.Text);
        }

        private void tstxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.LoadData(tstxtSearch.Text);
        }

        private void tsbtnReject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInput.Rows)
                row.Cells[0].Value = "Reject";
        }

        private void dgvInput_SelectionChanged(object sender, EventArgs e)
        {
            SetText("Selected: " + "1");
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (InvokeRequired)
            {
                SetTextCallback callback = new SetTextCallback(SetText);
                this.Invoke(callback, new object[] { text });
            }
            else
                lblSelected.Text = text;
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure to delete selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    string chaseno = dgvInput.CurrentRow.Cells[9].Value.ToString();
                    AccountUtil.DeleteRecord(chaseno);
                    
                    MessageBox.Show("Record has been deleted.");
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void dgvInput_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvInput.Rows.Count > 0)
            {
                if (((dgvInput.Rows[0].Height * dgvInput.Rows.Count) + dgvInput.ColumnHeadersHeight) < e.Location.Y)
                    dgvInput.ClearSelection();
                else
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        var hti = dgvInput.HitTest(e.X, e.Y);

                        if (dgvInput.SelectedRows.Count == 1)
                        {
                            dgvInput.ClearSelection();

                            if (((dgvInput.Rows[0].Height * dgvInput.Rows.Count) + dgvInput.ColumnHeadersHeight) >= e.Location.Y)
                                dgvInput.Rows[hti.RowIndex].Selected = true;
                        }
                        else
                        {
                            if (((dgvInput.Rows[0].Height * dgvInput.Rows.Count) + dgvInput.ColumnHeadersHeight) >= e.Location.Y)
                                dgvInput.Rows[hti.RowIndex].Selected = true;
                        }
                    }
                }
            }
        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInput.SelectedRows)
                row.Cells[0].Value = "Approve";
        }

        private void rejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInput.SelectedRows)
                row.Cells[0].Value = "Reject";
        }

        private void dgvInput_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Debug.WriteLine("End Edit");
                string fa = dgvInput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                dgvInput.Rows[e.RowIndex].Cells[0].ReadOnly = false;
                if (fa.Length > 0)
                {
                    if (fa.Length != 9)
                    {
                        MessageBox.Show("Fixed Asset Code MUST be 9 digits. Current Input: " + fa);
                        dgvInput.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                        return;
                    }

                    _errorlist = new List<string>();
                    dgvInput.CellValidating += new DataGridViewCellValidatingEventHandler(dgvInput_CellValidating);
                    //Debug.WriteLine(isSaved);

                    if (!isValid)
                    {
                        MessageBox.Show("Repeat Fixed Asset Code found!\n" + fa);
                        dgvInput.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                        return;
                    }
                    else
                    {
                        if (!isSaved)
                        {
                            if (DataUtil.IsFixedAssetCodeExists(fa))
                            {
                                MessageBox.Show("Repeat Fixed Asset Code found!\n" + fa);
                                dgvInput.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                                return;
                            }
                        }
                    }
                }
            }
        }

        string _fa = "";
        bool isValid = true;
        List<string> _errorlist = new List<string>();

        private void dgvInput_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            isValid = true;
            
            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                if (row.Index != e.RowIndex & !row.IsNewRow)
                {
                    if (row.Cells[1].Value.ToString() == e.FormattedValue.ToString())
                    {
                        isValid = false;
                        _fa = row.Cells[1].Value.ToString();
                        _errorlist.Add(_fa);
                    }
                }
            }
        }

        private void dgvInput_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
