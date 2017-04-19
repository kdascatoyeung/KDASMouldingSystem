namespace KDTHK_MOULD_SYSTEM.forms.report
{
    partial class ReportBaseSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCN = new CustomUtil.controls.button.CustomButton();
            this.btnVN = new CustomUtil.controls.button.CustomButton();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCN
            // 
            this.btnCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCN.BackColor = System.Drawing.Color.LightGray;
            this.btnCN.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.ForeColor = System.Drawing.Color.Black;
            this.btnCN.GlowColor = System.Drawing.Color.DodgerBlue;
            this.btnCN.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.btnCN.Location = new System.Drawing.Point(15, 23);
            this.btnCN.Name = "btnCN";
            this.btnCN.ShineColor = System.Drawing.Color.AliceBlue;
            this.btnCN.Size = new System.Drawing.Size(116, 23);
            this.btnCN.TabIndex = 32;
            this.btnCN.Text = "CN";
            // 
            // btnVN
            // 
            this.btnVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVN.BackColor = System.Drawing.Color.LightGray;
            this.btnVN.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnVN.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVN.ForeColor = System.Drawing.Color.Black;
            this.btnVN.GlowColor = System.Drawing.Color.DodgerBlue;
            this.btnVN.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.btnVN.Location = new System.Drawing.Point(137, 23);
            this.btnVN.Name = "btnVN";
            this.btnVN.ShineColor = System.Drawing.Color.AliceBlue;
            this.btnVN.Size = new System.Drawing.Size(116, 23);
            this.btnVN.TabIndex = 33;
            this.btnVN.Text = "VN";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel1.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.BorderWidth = 2;
            this.customPanel1.Controls.Add(this.btnCN);
            this.customPanel1.Controls.Add(this.btnVN);
            this.customPanel1.Curvature = 4;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(265, 66);
            this.customPanel1.TabIndex = 34;
            // 
            // ReportBaseSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(265, 66);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportBaseSelection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Base to view";
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.button.CustomButton btnCN;
        private CustomUtil.controls.button.CustomButton btnVN;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
    }
}