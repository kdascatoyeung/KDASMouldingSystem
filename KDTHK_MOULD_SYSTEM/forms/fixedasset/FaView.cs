using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomUtil.utils.buffer;
using KDTHK_MOULD_SYSTEM.services;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.forms.fixedasset
{
    public partial class FaView : UserControl
    {
        public FaView()
        {
            InitializeComponent();

            BufferUtil.DoubleBuffered(dgvFa, true);

            this.LoadData("");
        }

        private void LoadData(string source)
        {
            string query = string.Format("select f_type, f_status, f_chaseno, mm_mouldno, mm_itemcode" +
                ", mm_itemtext, f_pdfid, f_attachment from TB_FA_APPROVAL, TB_MOULD_MAIN where" +
                " f_chaseno = mm_chaseno and (f_chaseno like '%{0}%'" +
                " or mm_mouldno like '%{0}%' or mm_itemcode like '%{0}%' or mm_itemtext like '%{0}%'" +
                " or f_pdfid like '%{0}%')", source);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string type = GlobalService.Reader.GetString(0);
                    string status = GlobalService.Reader.GetString(1);
                    string chaseNo = GlobalService.Reader.GetString(2);
                    string mouldNo = GlobalService.Reader.GetString(3);
                    string partNo = GlobalService.Reader.GetString(4);
                    string itemText = GlobalService.Reader.GetString(5);
                    string pdfId = GlobalService.Reader.GetString(6);
                    string attachment = GlobalService.Reader.GetString(7);
                    string display = pdfId.StartsWith("FA") ? pdfId : "Attachments";
                    string path = pdfId.StartsWith("FA") ? @"\\kdthk-dm1\MOSS$\CM\FixedAssets\test\" + pdfId + ".pdf" : attachment;

                    dgvFa.Rows.Add(type, status, chaseNo, mouldNo, partNo, itemText, display, path);
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

        private void dgvFa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string data = dgvFa.CurrentRow.Cells[7].Value.ToString();
                if (data.Contains(";"))
                {
                    string[] strs = data.Split(';');
                    foreach (string str in strs)
                        Process.Start(str);
                }
                else
                    Process.Start(dgvFa.CurrentRow.Cells[7].Value.ToString());
            }
        }
    }
}
