namespace KDTHK_MOULD_SYSTEM.forms.disposal
{
    partial class DisposalHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisposalHistory));
            this.customPanel5 = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.tsbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmouldno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel5
            // 
            this.customPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel5.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel5.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel5.BorderColor = System.Drawing.Color.Silver;
            this.customPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel5.BorderWidth = 1;
            this.customPanel5.Controls.Add(this.btnSearchItem);
            this.customPanel5.Controls.Add(this.txtSearch);
            this.customPanel5.Curvature = 2;
            this.customPanel5.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel5.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel5.Location = new System.Drawing.Point(963, 3);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(197, 22);
            this.customPanel5.TabIndex = 9;
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
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn,
            this.tsbtnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(960, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctype,
            this.cstatus,
            this.cmouldno,
            this.cpartno,
            this.cvendor,
            this.cname});
            this.dgvHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvHistory.Location = new System.Drawing.Point(3, 26);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1157, 610);
            this.dgvHistory.TabIndex = 25;
            // 
            // tsbtn
            // 
            this.tsbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.processToolStripMenuItem});
            this.tsbtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtn.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn.Image")));
            this.tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn.Name = "tsbtn";
            this.tsbtn.Size = new System.Drawing.Size(62, 22);
            this.tsbtn.Text = "Switch";
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestToolStripMenuItem.BackgroundImage")));
            this.requestToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.requestToolStripMenuItem.Text = "Request";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("processToolStripMenuItem.BackgroundImage")));
            this.processToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.processToolStripMenuItem.Text = "Processing";
            this.processToolStripMenuItem.Click += new System.EventHandler(this.processToolStripMenuItem_Click);
            // 
            // tsbtnDownload
            // 
            this.tsbtnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDownload.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnDownload.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnDownload.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDownload.Image")));
            this.tsbtnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDownload.Name = "tsbtnDownload";
            this.tsbtnDownload.Size = new System.Drawing.Size(75, 22);
            this.tsbtnDownload.Text = "Download";
            this.tsbtnDownload.Click += new System.EventHandler(this.tsbtnDownload_Click);
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchItem.BackgroundImage")));
            this.btnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchItem.FlatAppearance.BorderSize = 0;
            this.btnSearchItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSearchItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItem.Location = new System.Drawing.Point(177, 3);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(16, 16);
            this.btnSearchItem.TabIndex = 13;
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
            // 
            // ctype
            // 
            this.ctype.DataPropertyName = "type";
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "status";
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            // 
            // cmouldno
            // 
            this.cmouldno.DataPropertyName = "mould";
            this.cmouldno.HeaderText = "Mould";
            this.cmouldno.Name = "cmouldno";
            this.cmouldno.ReadOnly = true;
            // 
            // cpartno
            // 
            this.cpartno.DataPropertyName = "partno";
            this.cpartno.HeaderText = "Part No.";
            this.cpartno.Name = "cpartno";
            this.cpartno.ReadOnly = true;
            // 
            // cvendor
            // 
            this.cvendor.DataPropertyName = "vendor";
            this.cvendor.HeaderText = "Vendor";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cname.DataPropertyName = "name";
            this.cname.HeaderText = "Vendor Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Width = 104;
            // 
            // DisposalHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.customPanel5);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DisposalHistory";
            this.Size = new System.Drawing.Size(1163, 639);
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel5;
        private System.Windows.Forms.Button btnSearchItem;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtn;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
    }
}
