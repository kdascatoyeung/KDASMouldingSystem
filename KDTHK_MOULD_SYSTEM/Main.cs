using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.forms;
using KDTHK_MOULD_SYSTEM.forms.quotation;
using KDTHK_MOULD_SYSTEM.forms.po;
using KDTHK_MOULD_SYSTEM.forms.instock;
using KDTHK_MOULD_SYSTEM.forms.ringi;
using KDTHK_MOULD_SYSTEM.forms.fixedasset;
using KDTHK_MOULD_SYSTEM.forms.data;
using KDTHK_MOULD_SYSTEM.forms.transfer;
using KDTHK_MOULD_SYSTEM.forms.disposal;
using KDTHK_MOULD_SYSTEM.forms.report;
using CustomUtil.utils.import;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM
{
    public partial class Main : Form
    {
        MainView mainview;

        QuotationInput quoInput;

        FaView faview;

        PoView poview;

        InstockView instockview;

        RingiAssign ringiassign;

        FaApprovalView faapproval;

        TransferView transferview;

        DisposalView disposalview = new DisposalView();
        DisposalProcessing disposalProcessing = new DisposalProcessing();
        DisposalHistory disposalHistory = new DisposalHistory();

        ReportView reportview;
        ReportCD reportCd = new ReportCD();
        ReportModify reportModify = new ReportModify();
        ReportPayment reportPayment = new ReportPayment();
        ReportCollection reportCollection = new ReportCollection();
        ReportBase reportBase = new ReportBase();

        MasterMouldCode masterMouldCode;
        MasterVendor masterVendor;
        MasterOem masterOem;

        public Main()
        {
            InitializeComponent();

            poview = new PoView();
            quoInput = new QuotationInput();
            ringiassign = new RingiAssign();
            transferview = new TransferView();
            disposalProcessing = new DisposalProcessing();

            mainview = new MainView();
            mainview.NewItemEvent -= new EventHandler(mainview_NewItemEvent);
            mainview.NewItemEvent += new EventHandler(mainview_NewItemEvent);
            this.LoadControl(mainview);

            lblMain.BackColor = Color.AliceBlue;
            lblMain.ForeColor = Color.DodgerBlue;
            lblMain.Font = new Font("Calibri", lblMain.Font.Size, FontStyle.Bold);
        }

        bool isExtended = true;

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (isExtended)
            {
                pnlLeft.Width = 41;
                btnExtend.BackgroundImage = Properties.Resources.right_button_basic_blue;
                isExtended = false;
            }
            else
            {
                pnlLeft.Width = 200;
                btnExtend.BackgroundImage = Properties.Resources.left_button_basic_blue;
                isExtended = true;
            }
        }

        private void LoadControl(UserControl control)
        {
            this.pnlMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(control);
        }

        private void MenuClicked(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            string tag = btn.Tag.ToString();

            if (tag == "home")
                this.LoadMain();

            if (tag == "quotation")
                this.LoadQuotation();

            if (tag == "transfer")
                this.LoadTransfer();

            if (tag == "disposal")
                this.LoadDisposal();

            if (tag == "report")
                this.LoadReport();

            if (tag == "data")
            {
                masterMouldCode = new MasterMouldCode();
                masterMouldCode.VendorSwitchEvent += new EventHandler(VendorSwitchEvent);
                masterMouldCode.OemSwitchEvent += new EventHandler(OemSwitchEvent);
                this.LoadControl(masterMouldCode);
            }

            if (tag == "setting")
            {

            }
        }

        private void LabelClicked(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            string tag = label.Tag.ToString();

            foreach (Control control in pnlMenu.Controls)
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

            if(tag=="mainview")
                this.LoadControl(mainview);

            if (tag == "quotation")
                this.LoadQuotation();

            if (tag == "ringi")
                this.LoadControl(ringiassign);

            if (tag == "fa")
            {
                faview = new FaView();
                this.LoadControl(faview);
            }

            if (tag == "po")
            {
                this.LoadControl(poview);
            }

            if (tag == "instock")
                this.LoadInStock();

            if (tag == "transfer")
                this.LoadTransfer();

            if (tag == "disposal")
                this.LoadDisposal();

            if (tag == "report")
                this.LoadReport();

            if (tag == "setting")
            {

            }

            if (tag == "approval")
            {
                faapproval = new FaApprovalView();
                this.LoadControl(faapproval);
            }
        }

        private void ClearLabelSelection()
        {
            foreach (Control control in pnlMenu.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.Transparent;
                    control.ForeColor = Color.DimGray;
                    control.Font = new Font("Calibri", lblQuotation.Font.Size, FontStyle.Regular);
                }
            }
        }

        private void SetLabelSelection(Label label)
        {
            label.BackColor = Color.AliceBlue;
            label.ForeColor = Color.DodgerBlue;
            label.Font = new Font("Calibri", label.Font.Size, FontStyle.Bold);
        }

        private void LoadMain()
        {
            this.LoadControl(mainview);

            this.ClearLabelSelection();

            this.SetLabelSelection(lblMain);
        }

        private void LoadQuotation()
        {
            quoInput.SaveEvent -= new EventHandler(quoInput_SaveEvent);
            quoInput.SaveEvent += new EventHandler(quoInput_SaveEvent);
            quoInput.CancelEvent -= new EventHandler(quoInput_CancelEvent);
            quoInput.CancelEvent += new EventHandler(quoInput_CancelEvent);
            this.LoadControl(quoInput);

            this.ClearLabelSelection();

            this.SetLabelSelection(lblQuotation);
        }

        private void LoadInStock()
        {
            instockview = new InstockView();
            instockview.SaveEvent += new EventHandler(instockview_SaveEvent);
            this.LoadControl(instockview);
        }

        private void LoadTransfer()
        {
            this.LoadControl(transferview);

            this.ClearLabelSelection();

            this.SetLabelSelection(lblTransfer);
        }

        private void LoadDisposal()
        {
            disposalProcessing.SwitchRequestEvent += new EventHandler(disposalProcessing_SwitchRequestEvent);
            disposalProcessing.SwitchHistoryEvent += new EventHandler(disposalProcessing_SwitchHistoryEvent);
            this.LoadControl(disposalProcessing);

            this.ClearLabelSelection();

            this.SetLabelSelection(lblDisposal);
        }

        private void LoadReport()
        {
            reportview = new ReportView();
            reportview.ToCdReportEvent += new EventHandler(reportview_ToCdReportEvent);
            reportview.ToModifyRecordEvent += new EventHandler(reportview_ToModifyRecordEvent);
            reportview.ToPaymentEvent += new EventHandler(reportview_ToPaymentEvent);
            reportview.ToPoCollectionEvent += new EventHandler(reportview_ToPoCollectionEvent);
            reportview.ToBaseEvent += new EventHandler(reportview_ToBaseEvent);

            this.LoadControl(reportview);

            this.ClearLabelSelection();

            this.SetLabelSelection(lblReport);
        }

        private void mainview_NewItemEvent(object sender, EventArgs e)
        {
            this.LoadQuotation();
        }

        private void quoInput_SaveEvent(object sender, EventArgs e)
        {
            quoInput = new QuotationInput();
            quoInput.SaveEvent -= new EventHandler(quoInput_SaveEvent);
            quoInput.SaveEvent += new EventHandler(quoInput_SaveEvent);
            quoInput.CancelEvent -= new EventHandler(quoInput_CancelEvent);
            quoInput.CancelEvent += new EventHandler(quoInput_CancelEvent);
            this.LoadControl(quoInput);
        }

        private void quoInput_CancelEvent(object sender, EventArgs e)
        {
            quoInput = new QuotationInput();
            quoInput.SaveEvent -= new EventHandler(quoInput_SaveEvent);
            quoInput.SaveEvent += new EventHandler(quoInput_SaveEvent);
            quoInput.CancelEvent -= new EventHandler(quoInput_CancelEvent);
            quoInput.CancelEvent += new EventHandler(quoInput_CancelEvent);
            this.LoadMain();
        }

        private void MouldCodeSwitchEvent(object sender, EventArgs e)
        {
            masterMouldCode = new MasterMouldCode();
            masterMouldCode.VendorSwitchEvent += new EventHandler(VendorSwitchEvent);
            masterMouldCode.OemSwitchEvent += new EventHandler(OemSwitchEvent);
            this.LoadControl(masterMouldCode);
        }

        private void VendorSwitchEvent(object sender, EventArgs e)
        {
            masterVendor = new MasterVendor();
            masterVendor.MouldCodeSwitchEvent += new EventHandler(MouldCodeSwitchEvent);
            masterVendor.OemSwitchEvent += new EventHandler(OemSwitchEvent);
            this.LoadControl(masterVendor);
        }

        private void OemSwitchEvent(object sender, EventArgs e)
        {
            masterOem = new MasterOem();
            masterOem.MouldCodeSwitchEvent += new EventHandler(MouldCodeSwitchEvent);
            masterOem.VendorSwitchEvent += new EventHandler(VendorSwitchEvent);
            this.LoadControl(masterOem);
        }

        private void instockview_SaveEvent(object sender, EventArgs e)
        {
            instockview = new InstockView();
            instockview.SaveEvent += new EventHandler(instockview_SaveEvent);
            this.LoadControl(instockview);
        }

        private void disposalview_SwitchProcessingEvent(object sender, EventArgs e)
        {
            disposalProcessing.SwitchRequestEvent += new EventHandler(disposalProcessing_SwitchRequestEvent);
            disposalProcessing.SwitchHistoryEvent += new EventHandler(disposalProcessing_SwitchHistoryEvent);
            this.LoadControl(disposalProcessing);
        }

        private void disposalProcessing_SwitchRequestEvent(object sender, EventArgs e)
        {
            disposalview.SwitchProcessingEvent += new EventHandler(disposalview_SwitchProcessingEvent);
            disposalview.SwitchHistoryEvent += new EventHandler(disposalProcessing_SwitchHistoryEvent);
            this.LoadControl(disposalview);
        }

        private void disposalProcessing_SwitchHistoryEvent(object sender, EventArgs e)
        {
            disposalHistory.SwitchRequestEvent += new EventHandler(disposalProcessing_SwitchRequestEvent);
            disposalHistory.SwitchProcessingEvent += new EventHandler(disposalview_SwitchProcessingEvent);
            this.LoadControl(disposalHistory);
        }

        private void reportview_ToCdReportEvent(object sender, EventArgs e)
        {
            reportCd.ToModifyRecordEvent += new EventHandler(reportview_ToModifyRecordEvent);
            reportCd.ToPaymentEvent += new EventHandler(reportview_ToPaymentEvent);
            reportCd.ToCollectionEvent += new EventHandler(reportview_ToPoCollectionEvent);
            reportCd.ToBaseEvent += new EventHandler(reportview_ToBaseEvent);
            this.LoadControl(reportCd);
        }

        private void reportview_ToModifyRecordEvent(object sender, EventArgs e)
        {
            reportModify.ToCdReportEvent += new EventHandler(reportview_ToCdReportEvent);
            reportModify.ToPaymentEvent += new EventHandler(reportview_ToPaymentEvent);
            reportModify.ToCollectionEvent += new EventHandler(reportview_ToPoCollectionEvent);
            reportModify.ToBaseEvent += new EventHandler(reportview_ToBaseEvent);
            this.LoadControl(reportModify);
        }

        private void reportview_ToPaymentEvent(object sender, EventArgs e)
        {
            reportPayment.ToCdReportEvent += new EventHandler(reportview_ToCdReportEvent);
            reportPayment.ToModifyRecordEvent += new EventHandler(reportview_ToModifyRecordEvent);
            reportPayment.ToCollectionEvent += new EventHandler(reportview_ToPoCollectionEvent);
            reportPayment.ToBaseEvent += new EventHandler(reportview_ToBaseEvent);
            this.LoadControl(reportPayment);
        }

        private void reportview_ToPoCollectionEvent(object sender, EventArgs e)
        {
            reportCollection.ToCdReportEvent += new EventHandler(reportview_ToCdReportEvent);
            reportCollection.ToModifyRecordEvent += new EventHandler(reportview_ToModifyRecordEvent);
            reportCollection.ToPaymentEvent += new EventHandler(reportview_ToPaymentEvent);
            reportCollection.ToBaseEvent += new EventHandler(reportview_ToBaseEvent);
            this.LoadControl(reportCollection);
        }

        private void reportview_ToBaseEvent(object sender, EventArgs e)
        {
            reportBase.ToCdReportEvent += new EventHandler(reportview_ToCdReportEvent);
            reportBase.ToModifyRecordEvent += new EventHandler(reportview_ToModifyRecordEvent);
            reportBase.ToPaymentEvent += new EventHandler(reportview_ToPaymentEvent);
            reportBase.ToCollectionEvent += new EventHandler(reportview_ToPoCollectionEvent);
            this.LoadControl(reportBase);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable table = ImportExcel2007.TranslateToTable(ofd.FileName);

                foreach (DataRow row in table.Rows)
                {
                    string id = row.ItemArray[0].ToString().Trim();
                    string partno = row.ItemArray[2].ToString().Trim();

                    string query = string.Format("update TB_FA_APPROVAL set f_partno = '{0}' where f_id = '{1}'", partno, id);
                    DataService.GetInstance().ExecuteNonQuery(query);
                }

            }
        }
    }
}
