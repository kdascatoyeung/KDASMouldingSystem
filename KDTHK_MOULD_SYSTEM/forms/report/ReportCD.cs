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
    public partial class ReportCD : UserControl
    {
        public event EventHandler ToModifyRecordEvent;
        public event EventHandler ToPaymentEvent;
        public event EventHandler ToCollectionEvent;
        public event EventHandler ToBaseEvent;

        public ReportCD()
        {
            InitializeComponent();
        }

        private void SwitchView(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string tag = item.Tag.ToString();

            switch (tag)
            {
                case "modify":
                    if (ToModifyRecordEvent != null)
                        ToModifyRecordEvent(this, new EventArgs());
                    break;

                case "payment":
                    if (ToPaymentEvent != null)
                        ToPaymentEvent(this, new EventArgs());
                    break;

                case "collection":
                    if (ToCollectionEvent != null)
                        ToCollectionEvent(this, new EventArgs());
                    break;

                case "pbase":
                    if (ToBaseEvent != null)
                        ToBaseEvent(this, new EventArgs());
                    break;
            }
        }
    }
}
