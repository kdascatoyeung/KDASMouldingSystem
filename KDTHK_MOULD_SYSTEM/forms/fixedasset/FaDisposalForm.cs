using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.data;

namespace KDTHK_MOULD_SYSTEM.forms.fixedasset
{
    public partial class FaDisposalForm : Form
    {
        List<string> lstAttachment;

        string _fixedAsset = "";
        string _vendor = "";
        string _chaseNo = "";
        string _itemText = "";
        string _mpa = "";

        public FaDisposalForm(string fixedAsset, string vendor, string chaseNo)
        {
            InitializeComponent();

            _fixedAsset = fixedAsset;
            _vendor = vendor;
            _chaseNo = chaseNo;
            _itemText = Mould.GetItemText(chaseNo);
            _mpa = Mould.GetMpa(chaseNo);

            lstAttachment = new List<string>();

            txtSection.Text = GlobalService.IPO1st;
            txtDivision.Text = GlobalService.IPO2nd;
        }

        private void txtFa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BrowseAttachment()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    if (!lstAttachment.Contains(filename))
                    {
                        lstAttachment.Add(filename);
                        lbAttachment.Items.Add(Path.GetFileName(filename));
                    }
                }
            }
        }

        private void lbAttachment_DoubleClick(object sender, EventArgs e)
        {
            this.BrowseAttachment();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            this.BrowseAttachment();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<string> tmplist = new List<string>();

            foreach (string item in lstAttachment)
            {
                File.Copy(item, @"\\kdthk-dm1\moss$\cm\Attachments\" + Path.GetFileName(item), true);
                tmplist.Add(@"\\kdthk-dm1\moss$\cm\Attachments\" + Path.GetFileName(item));
            }

            string attachments = string.Join(";", tmplist.ToArray());

            string query = string.Format("insert into TB_FA_APPROVAL (f_type, f_chaseno, f_pdfid, f_status" +
                ", f_fixedasset, f_desc, f_mpa, f_vendor, f_attachment, f_ipo1st, f_ipo2nd, f_cm1st, f_cm2nd" +
                ", f_cm3rd, f_cm4th, f_validfrom, f_reason) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', N'{8}', N'{9}', N'{10}', N'{11}'" +
                ", N'{12}', N'{13}', N'{14}', '{15}', N'{16}')", "Disposal", _chaseNo, "-", "IPO 1st Approval", _fixedAsset, _itemText, _mpa, _vendor,
                attachments, txtSection.Text, txtDivision.Text, GlobalService.CM1st, GlobalService.CM2nd, GlobalService.CM3rd, GlobalService.CM4th, dtpValidFrom.Value.ToString("yyyy/MM/dd"), "-");

            DataService.GetInstance().ExecuteNonQuery(query);

            MessageBox.Show("Record has been saved.");

            this.DialogResult = DialogResult.OK;
        }

        private void lbAttachment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = lbAttachment.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstAttachment.RemoveAll(x => x.EndsWith(lbAttachment.Items[i].ToString()));
                    lbAttachment.Items.RemoveAt(lbAttachment.SelectedIndices[i]);
                }
            }
        }
    }
}
