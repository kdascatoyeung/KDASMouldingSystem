namespace KDTHK_MOULD_SYSTEM.forms.fixedasset
{
    partial class FaCancelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaCancelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnTransfer = new System.Windows.Forms.RadioButton();
            this.rbtnChange = new System.Windows.Forms.RadioButton();
            this.rbtnCancel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpValidFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFa = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new CustomUtil.controls.button.CustomButton();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAttachment = new System.Windows.Forms.ListBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCancel);
            this.panel1.Controls.Add(this.rbtnChange);
            this.panel1.Controls.Add(this.rbtnTransfer);
            this.panel1.Location = new System.Drawing.Point(65, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 28);
            this.panel1.TabIndex = 0;
            // 
            // rbtnTransfer
            // 
            this.rbtnTransfer.AutoSize = true;
            this.rbtnTransfer.Location = new System.Drawing.Point(3, 3);
            this.rbtnTransfer.Name = "rbtnTransfer";
            this.rbtnTransfer.Size = new System.Drawing.Size(70, 19);
            this.rbtnTransfer.TabIndex = 0;
            this.rbtnTransfer.TabStop = true;
            this.rbtnTransfer.Text = "Transfer";
            this.rbtnTransfer.UseVisualStyleBackColor = true;
            // 
            // rbtnChange
            // 
            this.rbtnChange.AutoSize = true;
            this.rbtnChange.Location = new System.Drawing.Point(79, 3);
            this.rbtnChange.Name = "rbtnChange";
            this.rbtnChange.Size = new System.Drawing.Size(65, 19);
            this.rbtnChange.TabIndex = 1;
            this.rbtnChange.TabStop = true;
            this.rbtnChange.Text = "Change";
            this.rbtnChange.UseVisualStyleBackColor = true;
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.AutoSize = true;
            this.rbtnCancel.Location = new System.Drawing.Point(150, 3);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(62, 19);
            this.rbtnCancel.TabIndex = 2;
            this.rbtnCancel.TabStop = true;
            this.rbtnCancel.Text = "Cancel";
            this.rbtnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valid From Date :";
            // 
            // dtpValidFrom
            // 
            this.dtpValidFrom.Location = new System.Drawing.Point(118, 45);
            this.dtpValidFrom.Name = "dtpValidFrom";
            this.dtpValidFrom.Size = new System.Drawing.Size(168, 23);
            this.dtpValidFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fixed Asset No. :";
            // 
            // txtFa
            // 
            this.txtFa.Location = new System.Drawing.Point(118, 77);
            this.txtFa.Name = "txtFa";
            this.txtFa.Size = new System.Drawing.Size(297, 23);
            this.txtFa.TabIndex = 5;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(118, 106);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(297, 23);
            this.txtReason.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reason :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.GlowColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.Location = new System.Drawing.Point(325, 279);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShineColor = System.Drawing.Color.AliceBlue;
            this.btnSubmit.Size = new System.Drawing.Size(90, 23);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(118, 218);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(267, 23);
            this.txtSection.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Section :";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(118, 247);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(267, 23);
            this.txtDivision.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Division :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Attachment :";
            // 
            // lbAttachment
            // 
            this.lbAttachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAttachment.FormattingEnabled = true;
            this.lbAttachment.HorizontalScrollbar = true;
            this.lbAttachment.ItemHeight = 15;
            this.lbAttachment.Location = new System.Drawing.Point(118, 135);
            this.lbAttachment.Name = "lbAttachment";
            this.lbAttachment.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAttachment.Size = new System.Drawing.Size(267, 77);
            this.lbAttachment.TabIndex = 38;
            this.lbAttachment.DoubleClick += new System.EventHandler(this.lbAttachment_DoubleClick);
            this.lbAttachment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAttachment_KeyDown);
            // 
            // btnAttach
            // 
            this.btnAttach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttach.BackgroundImage")));
            this.btnAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAttach.FlatAppearance.BorderSize = 0;
            this.btnAttach.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAttach.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Location = new System.Drawing.Point(391, 135);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(24, 24);
            this.btnAttach.TabIndex = 39;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnSection
            // 
            this.btnSection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSection.BackgroundImage")));
            this.btnSection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSection.FlatAppearance.BorderSize = 0;
            this.btnSection.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSection.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSection.Location = new System.Drawing.Point(391, 217);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(24, 24);
            this.btnSection.TabIndex = 40;
            this.btnSection.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivision.BackgroundImage")));
            this.btnDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivision.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Location = new System.Drawing.Point(391, 246);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(24, 24);
            this.btnDivision.TabIndex = 41;
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // FaCancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(430, 314);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSection);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lbAttachment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpValidFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FaCancelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixed Asset - Transfer / Change / Cancel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnCancel;
        private System.Windows.Forms.RadioButton rbtnChange;
        private System.Windows.Forms.RadioButton rbtnTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpValidFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFa;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label4;
        private CustomUtil.controls.button.CustomButton btnSubmit;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbAttachment;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnDivision;
    }
}