using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace KDTHK_MOULD_SYSTEM.test
{
    public class CustomCheckBox : CheckBox
    {
        private Color borderColor;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }

        private Color background;
        public Color Background
        {
            get { return background; }
            set { background = value; }
        }

        private Color tickColor;
        public Color TickColor
        {
            get { return tickColor; }
            set { tickColor = value; }
        }

        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                if (value == isChecked) return;
                isChecked = value;
                this.Invalidate();
            }
        }

        public CustomCheckBox(bool isChecked)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            this.IsChecked = isChecked;
            Background = Color.White;
            BorderColor = Color.Black;
            TickColor = Color.Green;
        }

        public CustomCheckBox() : this(false) { }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rc = this.ClientRectangle;
            Graphics g = pevent.Graphics;
            StringFormat format = new StringFormat();
            Font f = new Font("Calibri", (float)rc.Height * 0.5f, FontStyle.Bold, GraphicsUnit.Pixel);
            
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            g.FillEllipse(new SolidBrush(Background), rc.Left + 1.5f, rc.Top + 1.5f, rc.Width - 4.0f, rc.Height - 4.0f);
            g.DrawEllipse(new Pen(new SolidBrush(BorderColor), 3.0f), rc.Left + 1.5f, rc.Top + 1.5f, rc.Width - 4.0f, rc.Height - 4.0f);

            if (IsChecked)
                g.DrawString("\u2713", f, new SolidBrush(tickColor), rc, format);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            IsChecked = isChecked ? false : true;

            Invalidate();
        }
    }
}
