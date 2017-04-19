namespace KDTHK_MOULD_SYSTEM.forms.ringi
{
    partial class RingiAssign
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RingiAssign));
            this.customPanel12 = new CustomUtil.controls.panel.CustomPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.dgvRingi = new System.Windows.Forms.DataGridView();
            this.cringi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuRingi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.lblRingi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new CustomUtil.controls.button.CustomButton();
            this.btnSave = new CustomUtil.controls.button.CustomButton();
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearchItem = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crcurr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cramount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crringi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel12.SuspendLayout();
            this.bdSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRingi)).BeginInit();
            this.menuRingi.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel12
            // 
            this.customPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customPanel12.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel12.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel12.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel12.BorderWidth = 1;
            this.customPanel12.Controls.Add(this.button2);
            this.customPanel12.Controls.Add(this.bdSearch);
            this.customPanel12.Controls.Add(this.dgvRingi);
            this.customPanel12.Curvature = 2;
            this.customPanel12.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel12.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel12.Location = new System.Drawing.Point(3, 3);
            this.customPanel12.Name = "customPanel12";
            this.customPanel12.Size = new System.Drawing.Size(389, 620);
            this.customPanel12.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bdSearch
            // 
            this.bdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bdSearch.BackColor = System.Drawing.SystemColors.Window;
            this.bdSearch.BackColor2 = System.Drawing.SystemColors.Window;
            this.bdSearch.BorderColor = System.Drawing.Color.Silver;
            this.bdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bdSearch.BorderWidth = 1;
            this.bdSearch.Controls.Add(this.btnSearch);
            this.bdSearch.Controls.Add(this.txtSearch);
            this.bdSearch.Curvature = 2;
            this.bdSearch.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.bdSearch.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.bdSearch.Location = new System.Drawing.Point(189, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 16;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.FocusSelect = true;
            this.txtSearch.Location = new System.Drawing.Point(4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PromptFont = new System.Drawing.Font("Calibri", 9F);
            this.txtSearch.PromptForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.PromptText = "Search here";
            this.txtSearch.Size = new System.Drawing.Size(167, 16);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvRingi
            // 
            this.dgvRingi.AllowUserToAddRows = false;
            this.dgvRingi.AllowUserToDeleteRows = false;
            this.dgvRingi.AllowUserToResizeRows = false;
            this.dgvRingi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRingi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRingi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRingi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRingi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvRingi.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvRingi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRingi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRingi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cringi,
            this.ccontent,
            this.cbalance});
            this.dgvRingi.ContextMenuStrip = this.menuRingi;
            this.dgvRingi.Location = new System.Drawing.Point(3, 28);
            this.dgvRingi.MultiSelect = false;
            this.dgvRingi.Name = "dgvRingi";
            this.dgvRingi.RowHeadersVisible = false;
            this.dgvRingi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvRingi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRingi.Size = new System.Drawing.Size(383, 589);
            this.dgvRingi.TabIndex = 15;
            this.dgvRingi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRingi_KeyDown);
            this.dgvRingi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvRingi_MouseDown);
            this.dgvRingi.MouseHover += new System.EventHandler(this.dgvRingi_MouseHover);
            // 
            // cringi
            // 
            this.cringi.HeaderText = "Ringi";
            this.cringi.Name = "cringi";
            // 
            // ccontent
            // 
            this.ccontent.HeaderText = "Content";
            this.ccontent.Name = "ccontent";
            // 
            // cbalance
            // 
            this.cbalance.HeaderText = "Balance";
            this.cbalance.Name = "cbalance";
            // 
            // menuRingi
            // 
            this.menuRingi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.menuRingi.Name = "menuRingi";
            this.menuRingi.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel2.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.BorderWidth = 1;
            this.customPanel2.Controls.Add(this.lblRingi);
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Controls.Add(this.btnCheck);
            this.customPanel2.Controls.Add(this.btnSave);
            this.customPanel2.Controls.Add(this.customPanel1);
            this.customPanel2.Controls.Add(this.dgvResult);
            this.customPanel2.Curvature = 2;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(395, 3);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(737, 620);
            this.customPanel2.TabIndex = 13;
            // 
            // lblRingi
            // 
            this.lblRingi.AutoSize = true;
            this.lblRingi.Location = new System.Drawing.Point(98, 7);
            this.lblRingi.Name = "lblRingi";
            this.lblRingi.Size = new System.Drawing.Size(58, 15);
            this.lblRingi.TabIndex = 36;
            this.lblRingi.Text = "Unknown";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Selected Ringi :";
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.BackColor = System.Drawing.Color.LightGray;
            this.btnCheck.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.GlowColor = System.Drawing.Color.DodgerBlue;
            this.btnCheck.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.btnCheck.Location = new System.Drawing.Point(548, 587);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.ShineColor = System.Drawing.Color.AliceBlue;
            this.btnCheck.Size = new System.Drawing.Size(90, 23);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "Check";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.GlowColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(644, 587);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShineColor = System.Drawing.Color.AliceBlue;
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel1.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel1.BorderColor = System.Drawing.Color.Silver;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.BorderWidth = 1;
            this.customPanel1.Controls.Add(this.button1);
            this.customPanel1.Controls.Add(this.txtSearchItem);
            this.customPanel1.Curvature = 2;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(537, 3);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(197, 22);
            this.customPanel1.TabIndex = 17;
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchItem.FocusSelect = true;
            this.txtSearchItem.Location = new System.Drawing.Point(4, 3);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PromptFont = new System.Drawing.Font("Calibri", 9F);
            this.txtSearchItem.PromptForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearchItem.PromptText = "Search here";
            this.txtSearchItem.Size = new System.Drawing.Size(167, 16);
            this.txtSearchItem.TabIndex = 2;
            this.txtSearchItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchItem_KeyDown);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToResizeRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cchaseno,
            this.crmould,
            this.crpartno,
            this.cvendor,
            this.crcurr,
            this.cramount,
            this.crringi});
            this.dgvResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvResult.Location = new System.Drawing.Point(3, 28);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(731, 553);
            this.dgvResult.TabIndex = 16;
            this.dgvResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResult_KeyDown);
            this.dgvResult.MouseHover += new System.EventHandler(this.dgvResult_MouseHover);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(177, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(177, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(16, 16);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cchaseno
            // 
            this.cchaseno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cchaseno.HeaderText = "ChaseNo.";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            this.cchaseno.Width = 83;
            // 
            // crmould
            // 
            this.crmould.DataPropertyName = "mouldno";
            this.crmould.HeaderText = "MouldNo.";
            this.crmould.Name = "crmould";
            this.crmould.ReadOnly = true;
            // 
            // crpartno
            // 
            this.crpartno.DataPropertyName = "partno";
            this.crpartno.HeaderText = "PartNo.";
            this.crpartno.Name = "crpartno";
            this.crpartno.ReadOnly = true;
            // 
            // cvendor
            // 
            this.cvendor.DataPropertyName = "vendor";
            this.cvendor.HeaderText = "Vendor";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            // 
            // crcurr
            // 
            this.crcurr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.crcurr.DataPropertyName = "currency";
            this.crcurr.HeaderText = "Currency";
            this.crcurr.Name = "crcurr";
            this.crcurr.ReadOnly = true;
            this.crcurr.Width = 81;
            // 
            // cramount
            // 
            this.cramount.DataPropertyName = "amount";
            this.cramount.HeaderText = "Amount";
            this.cramount.Name = "cramount";
            this.cramount.ReadOnly = true;
            // 
            // crringi
            // 
            this.crringi.DataPropertyName = "ringi";
            this.crringi.HeaderText = "Ringi";
            this.crringi.Name = "crringi";
            // 
            // RingiAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel12);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RingiAssign";
            this.Size = new System.Drawing.Size(1135, 626);
            this.customPanel12.ResumeLayout(false);
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRingi)).EndInit();
            this.menuRingi.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel12;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private System.Windows.Forms.DataGridView dgvRingi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cringi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbalance;
        private System.Windows.Forms.DataGridView dgvResult;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private System.Windows.Forms.Button button1;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearchItem;
        private CustomUtil.controls.button.CustomButton btnCheck;
        private CustomUtil.controls.button.CustomButton btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip menuRingi;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Label lblRingi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn crpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn crcurr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cramount;
        private System.Windows.Forms.DataGridViewTextBoxColumn crringi;
    }
}
