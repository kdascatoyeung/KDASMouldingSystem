using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KDTHK_MOULD_SYSTEM.forms.report
{
    public partial class ReportView : UserControl
    {
        public event EventHandler ToCdReportEvent;
        public event EventHandler ToModifyRecordEvent;
        public event EventHandler ToPaymentEvent;
        public event EventHandler ToPoCollectionEvent;
        public event EventHandler ToBaseEvent;

        public ReportView()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (ToCdReportEvent != null)
                ToCdReportEvent(this, new EventArgs());
        }

        private void btnModifyRecord_Click(object sender, EventArgs e)
        {
            if (ToModifyRecordEvent != null)
                ToModifyRecordEvent(this, new EventArgs());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (ToPaymentEvent != null)
                ToPaymentEvent(this, new EventArgs());
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            if (ToPoCollectionEvent != null)
                ToPoCollectionEvent(this, new EventArgs());
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            if (ToBaseEvent != null)
                ToBaseEvent(this, new EventArgs());
        }
    }
}
