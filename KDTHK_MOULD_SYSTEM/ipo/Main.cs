using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.ipo.views;
using KDTHK_MOULD_SYSTEM.services;
using KDTHK_MOULD_SYSTEM.ipo.views.approval;
using KDTHK_MOULD_SYSTEM.utils;

namespace KDTHK_MOULD_SYSTEM.ipo
{
    public partial class Main : Form
    {
        MouldView mouldview = new MouldView();
        QuotationView quotationview;

        public Main()
        {
            InitializeComponent();

            tsbtnViewer.Margin = new Padding(btnMould.Location.X, 1, 0, 2);

            mouldview.EditEvent += new EventHandler(mouldview_EditEvent);
            this.LoadControl(mouldview);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            tsbtnViewer.Margin = new Padding(btnMould.Location.X, 1, 0, 2);
            tsbtnInStockInput.Margin = new Padding(btnInstock.Location.X, 1, 0, 2);
            tsbtnTransferInput.Margin = new Padding(btnTransfer.Location.X, 1, 0, 2);
            tsbtnDisposalInput.Margin = new Padding(btnDisposal.Location.X, 1, 0, 2);
            tsbtnReportCd.Margin = new Padding(btnReport.Location.X, 1, 0, 2);
            tsbtnDataVendor.Margin = new Padding(btnData.Location.X, 1, 0, 2);
            tsbtnSettingRate.Margin = new Padding(btnSetting.Location.X, 1, 0, 2);
        }

        private void LoadControl(UserControl control)
        {
            this.pnlMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(control);
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string tag = button.Tag.ToString();

            foreach (Button btn in pnlTop.Controls)
            {
                btn.BackColor = Color.DimGray;
                btn.Font = new Font("Calibri", btn.Font.Size, FontStyle.Regular);
            }

            button.BackColor = Color.DodgerBlue;
            button.Font = new Font("Calibri", button.Font.Size, FontStyle.Bold);

            if (tag == "approval")
            {
                foreach (ToolStripButton tsbtn in tsSubMenu.Items)
                    tsbtn.Visible = false;

                ApprovalView approval = new ApprovalView();
                this.LoadControl(approval);
            }
            else
            {
                string started = tag == "mould" ? "m"
                    : tag == "instock" ? "i"
                    : tag == "transfer" ? "t"
                    : tag == "disposal" ? "d"
                    : tag == "report" ? "r"
                    : tag == "data" ? "o" : "s";

                foreach (ToolStripButton tsbtn in tsSubMenu.Items)
                {
                    string tsTag = tsbtn.Tag.ToString();
                    if (tsTag.StartsWith(started))
                        tsbtn.Visible = true;
                    else
                        tsbtn.Visible = false;
                }

                tsbtnViewer.Margin = new Padding(btnMould.Location.X, 1, 0, 2);
                tsbtnInStockInput.Margin = new Padding(btnInstock.Location.X, 1, 0, 2);
                tsbtnTransferInput.Margin = new Padding(btnTransfer.Location.X, 1, 0, 2);
                tsbtnDisposalInput.Margin = new Padding(btnDisposal.Location.X, 1, 0, 2);
                tsbtnReportCd.Margin = new Padding(btnReport.Location.X, 1, 0, 2);
                tsbtnDataVendor.Margin = new Padding(btnData.Location.X, 1, 0, 2);
                tsbtnSettingRate.Margin = new Padding(btnSetting.Location.X, 1, 0, 2);
            }
        }

        private void ToolStripButtonClicked(object sender, EventArgs e)
        {
            ToolStripButton tsbtn = (ToolStripButton)sender;
            string tag = tsbtn.Tag.ToString();

            foreach (ToolStripButton btn in tsSubMenu.Items)
            {
                btn.Font = new Font("Calibri", btn.Font.Size, FontStyle.Regular);
                btn.BackColor = Color.WhiteSmoke;
            }

            tsbtn.Font = new Font("Calibri", tsbtn.Font.Size, FontStyle.Bold);
            tsbtn.BackColor = Color.Gold;

            UserControl uc = new UserControl();

            switch (tag)
            {
                case "mViewer": uc = mouldview; 
                    break;

                case "mQuotation":
                    quotationview = new QuotationView();
                    quotationview.SavedEvent += new EventHandler(quotationview_SavedEvent);
                    uc = quotationview;
                    break;
                    
            }

            this.LoadControl(uc);
        }

        private void mouldview_EditEvent(object sender, EventArgs e)
        {
            QuotationEditView view = new QuotationEditView(GlobalService.EditList);
            this.LoadControl(view);
        }

        private void quotationview_SavedEvent(object sender, EventArgs e)
        {
            quotationview = new QuotationView();
            quotationview.SavedEvent += new EventHandler(quotationview_SavedEvent);
            this.LoadControl(quotationview);
        }
    }
}
