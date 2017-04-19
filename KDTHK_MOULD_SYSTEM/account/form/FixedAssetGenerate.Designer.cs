namespace KDTHK_MOULD_SYSTEM.account.form
{
    partial class FixedAssetGenerate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFixedAssetCode = new System.Windows.Forms.TextBox();
            this.btnSave = new CustomUtil.controls.button.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start From";
            // 
            // txtFixedAssetCode
            // 
            this.txtFixedAssetCode.Location = new System.Drawing.Point(82, 19);
            this.txtFixedAssetCode.Name = "txtFixedAssetCode";
            this.txtFixedAssetCode.Size = new System.Drawing.Size(219, 23);
            this.txtFixedAssetCode.TabIndex = 1;
            this.txtFixedAssetCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFixedAssetCode_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnSave.Location = new System.Drawing.Point(226, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 70;
            this.btnSave.Tag = "";
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FixedAssetGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(315, 75);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFixedAssetCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FixedAssetGenerate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Fixed Asset Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFixedAssetCode;
        private CustomUtil.controls.button.CustomButton btnSave;
    }
}