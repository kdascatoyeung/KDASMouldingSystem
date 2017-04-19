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
    public partial class ReportPayment : UserControl
    {
        public event EventHandler ToCdReportEvent;
        public event EventHandler ToModifyRecordEvent;
        public event EventHandler ToCollectionEvent;
        public event EventHandler ToBaseEvent;

        public ReportPayment()
        {
            InitializeComponent();
        }
    }
}
