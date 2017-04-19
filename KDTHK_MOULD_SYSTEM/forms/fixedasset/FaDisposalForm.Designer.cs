namespace KDTHK_MOULD_SYSTEM.forms.fixedasset
{
    partial class FaDisposalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaDisposalForm));
            this.txtFa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpValidFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAttachment = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSubmit = new CustomUtil.controls.button.CustomButton();
            this.SuspendLayout();
            // 
            // txtFa
            // 
            this.txtFa.Location = new System.Drawing.Point(126, 56);
            this.txtFa.Name = "txtFa";
            this.txtFa.Size = new System.Drawing.Size(297, 23);
            this.txtFa.TabIndex = 7;
            this.txtFa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fixed Asset No. :";
            // 
            // dtpValidFrom
            // 
            this.dtpValidFrom.Location = new System.Drawing.Point(126, 27);
            this.dtpValidFrom.Name = "dtpValidFrom";
            this.dtpValidFrom.Size = new System.Drawing.Size(168, 23);
            this.dtpValidFrom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Disposal Date :";
            // 
            // lbAttachment
            // 
            this.lbAttachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAttachment.FormattingEnabled = true;
            this.lbAttachment.HorizontalScrollbar = true;
            this.lbAttachment.ItemHeight = 15;
            this.lbAttachment.Location = new System.Drawing.Point(126, 85);
            this.lbAttachment.Name = "lbAttachment";
            this.lbAttachment.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAttachment.Size = new System.Drawing.Size(267, 77);
            this.lbAttachment.TabIndex = 47;
            this.lbAttachment.DoubleClick += new System.EventHandler(this.lbAttachment_DoubleClick);
            this.lbAttachment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAttachment_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Attachment :";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(126, 197);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(267, 23);
            this.txtDivision.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Division :";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(126, 168);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(267, 23);
            this.txtSection.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "Section :";
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
            this.btnDivision.Location = new System.Drawing.Point(399, 196);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(24, 24);
            this.btnDivision.TabIndex = 50;
            this.btnDivision.UseVisualStyleBackColor = true;
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
            this.btnSection.Location = new System.Drawing.Point(399, 167);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(24, 24);
            this.btnSection.TabIndex = 49;
            this.btnSection.UseVisualStyleBackColor = true;
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
            this.btnAttach.Location = new System.Drawing.Point(399, 85);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(24, 24);
            this.btnAttach.TabIndex = 48;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.GlowColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.Location = new System.Drawing.Point(333, 226);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShineColor = System.Drawing.Color.AliceBlue;
            this.btnSubmit.Size = new System.Drawing.Size(90, 23);
            this.btnSubmit.TabIndex = 51;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FaDisposalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(434, 254);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSection);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lbAttachment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpValidFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFa);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FaDisposalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fixed Asset - Disposal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpValidFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ListBox lbAttachment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label5;
        private CustomUtil.controls.button.CustomButton btnSubmit;
    }
}