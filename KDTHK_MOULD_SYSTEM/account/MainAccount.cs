using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.import;

namespace KDTHK_MOULD_SYSTEM.account
{
    public partial class MainAccount : Form
    {
        //FaAssetClass faAssetClass = new FaAssetClass();
        FaAssetClass2 faAssetClass = new FaAssetClass2();
        FaDownload faDownload;
        FaInput fainput;
        FaReview fareview;
        FaApproval faapproval;
        FaOverview faoverview = new FaOverview();
        FaDataCheck fadatacheck;
        FaRingi ringi;

        public MainAccount()
        {
            InitializeComponent();

            //faoverview = new FaOverview();
            this.LoadControl(faoverview);

            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            
        }

        private void LoadControl(UserControl control)
        {
            this.pnlMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(control);
        }

        private void LabelClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string tag = label.Tag.ToString();

            foreach (Control control in gbAcquis.Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.DimGray;
                    lbl.Font = new Font("Calibri", lbl.Font.Size, FontStyle.Regular);
                }
            }

            foreach (Control control in gbDisposal.Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.DimGray;
                    lbl.Font = new Font("Calibri", lbl.Font.Size, FontStyle.Regular);
                }
            }

            foreach (Control control in gbTransfer.Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.DimGray;
                    lbl.Font = new Font("Calibri", lbl.Font.Size, FontStyle.Regular);
                }
            }

            label.BackColor = Color.AliceBlue;
            label.ForeColor = Color.DodgerBlue;
            label.Font = new Font("Calibri", label.Font.Size, FontStyle.Bold);

            if (tag == "overview")
                this.LoadControl(faoverview);

            if (tag == "assetclass")
                this.LoadControl(faAssetClass);

            if (tag == "download")
            {
                faDownload = new FaDownload();
                this.LoadControl(faDownload);
            }

            if (tag == "fainput")
            {
                fainput = new FaInput();
                this.LoadControl(fainput);
            }

            if (tag == "fareview")
            {
                fareview = new FaReview();
                this.LoadControl(fareview);
            }

            if (tag == "datacheck")
            {
                fadatacheck = new FaDataCheck();
                this.LoadControl(fadatacheck);
            }

            if (tag == "faapproval")
            {
                faapproval = new FaApproval();
                this.LoadControl(faapproval);
            }

            if (tag == "ringi")
            {
                ringi = new FaRingi();
                this.LoadControl(ringi);
            }
        }

        private void tsbtnReset_Click(object sender, EventArgs e)
        {
            /*string query = "update TB_FA_APPROVAL set f_status = 'Asset Class Input', f_fixedasset = '', f_assetclass = 'Z1600', f_cm1stapp = '---', f_cm1stdate = '---', f_cm2ndapp = '---', f_cm2nddate = '---', f_cm3rdapp = '---', f_cm3rddate = '---', f_st = 'A'  where f_chaseno like 'MS%' and f_mpa != 'Temp'";
            DataService.GetInstance().ExecuteNonQuery(query);

            string query2 = "update TB_FA_APPROVAL set f_status = 'Asset Class Input', f_fixedasset = '', f_assetclass = 'Z4000', f_cm1stapp = '---', f_cm1stdate = '---', f_cm2ndapp = '---', f_cm2nddate = '---', f_cm3rdapp = '---', f_cm3rddate = '---', f_st = 'A'  where f_chaseno like 'MS%' and f_mpa = 'Temp'";
            DataService.GetInstance().ExecuteNonQuery(query2);

            string text = "update TB_FA_APPROVAL set f_status = 'Ringi Approval', f_fixedasset = '', f_assetclass = '', f_ringi1stapp = '---', f_ringi1stdate = '---', f_cm1stapp = '---', f_cm1stdate = '---', f_cm2ndapp = '---', f_cm2nddate = '---', f_cm3rdapp = '---', f_cm3rddate = '---', f_st = 'A'  where f_chaseno like 'TMS%'";
            DataService.GetInstance().ExecuteNonQuery(text);

            MessageBox.Show("Record has been reset");*/
            /* Commented by Cato Yeung 2017/04/13 */
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string request = row.ItemArray[0].ToString().Trim();
                    string applicant = row.ItemArray[1].ToString().Trim();
                    string type = row.ItemArray[2].ToString().Trim();
                    string chaseno = row.ItemArray[3].ToString().Trim();
                    string pdfid = row.ItemArray[4].ToString().Trim();
                    string partno = row.ItemArray[5].ToString().Trim();
                    string fixedasset = row.ItemArray[6].ToString().Trim();
                    string tmpfa = row.ItemArray[7].ToString().Trim();
                    string desc = row.ItemArray[8].ToString().Trim();
                    string mpa = row.ItemArray[9].ToString().Trim();
                    string assetclass = row.ItemArray[10].ToString().Trim();
                    string vendor = row.ItemArray[11].ToString().Trim();
                    if (vendor.Length == 9)
                        vendor = "0" + vendor;
                    string mould = row.ItemArray[12].ToString().Trim();
                    string ringi = row.ItemArray[13].ToString().Trim();
                    string model = row.ItemArray[14].ToString().Trim();
                    string currency = row.ItemArray[15].ToString().Trim();
                    string amount = row.ItemArray[16].ToString().Trim();
                    string assetdesc = vendor + "Test Vendor";

                    string attachment = @"\\kdthk-dm1\moss$\cm\fixedasset\"+pdfid+".pdf";

                    string query = string.Format("insert into TB_FA_APPROVAL (f_request, f_applicant, f_type, f_chaseno, f_pdfid, f_status, f_partno, f_fixedasset, f_desc, f_mpa, f_assetclass" +
                        ", f_vendor, f_attachment, f_mould, f_costcenter, f_resp, f_location, f_ringi, f_model, f_currency, f_amount, f_assetdesc) values ('{0}', N'{1}', '{2}'" +
                        ", '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}')", request, applicant, "Acquisition", chaseno, pdfid,
                        "Finish", partno, fixedasset, desc, mpa, assetclass, vendor, attachment, mould, "1404000029", "1404000029", "1404000000", ringi, model, currency, amount, assetdesc);

                    DataService.GetInstance().ExecuteNonQuery(query);

                    if (tmpfa != "")
                    {
                        string text = string.Format("insert into TB_FA_APPROVAL (f_request, f_applicant, f_type, f_chaseno, f_pdfid, f_status, f_partno, f_fixedasset, f_desc, f_mpa, f_assetclass" +
                        ", f_vendor, f_attachment, f_mould, f_costcenter, f_resp, f_location, f_ringi, f_model, f_currency, f_amount, f_assetdesc) values ('{0}', N'{1}', '{2}'" +
                        ", '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}')", request, applicant, "Acquisition", chaseno, pdfid,
                        "Finish", partno, tmpfa, desc, mpa, assetclass, vendor, attachment, mould, "1404000029", "1404000029", "1404000000", ringi, model, currency, amount, assetdesc);

                        DataService.GetInstance().ExecuteNonQuery(text);
                    }
                }
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FaSetup app = new FaSetup();
            LoadControl(app);
        }
    }
}
