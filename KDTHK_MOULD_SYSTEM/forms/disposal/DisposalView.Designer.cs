namespace KDTHK_MOULD_SYSTEM.forms.disposal
{
    partial class DisposalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisposalView));
            this.dgvDisposal = new System.Windows.Forms.DataGridView();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmouldno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel5 = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnRequest = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisposal)).BeginInit();
            this.customPanel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisposal
            // 
            this.dgvDisposal.AllowUserToAddRows = false;
            this.dgvDisposal.AllowUserToDeleteRows = false;
            this.dgvDisposal.AllowUserToResizeRows = false;
            this.dgvDisposal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisposal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisposal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDisposal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisposal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvDisposal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDisposal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisposal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cvendor,
            this.cto,
            this.cpchaseno,
            this.cmouldno,
            this.cpartno,
            this.crev});
            this.dgvDisposal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDisposal.Location = new System.Drawing.Point(3, 28);
            this.dgvDisposal.Name = "dgvDisposal";
            this.dgvDisposal.ReadOnly = true;
            this.dgvDisposal.RowHeadersVisible = false;
            this.dgvDisposal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvDisposal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisposal.Size = new System.Drawing.Size(1164, 601);
            this.dgvDisposal.TabIndex = 3;
            // 
            // cvendor
            // 
            this.cvendor.DataPropertyName = "vendor";
            this.cvendor.HeaderText = "Vendor";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            // 
            // cto
            // 
            this.cto.DataPropertyName = "name";
            this.cto.HeaderText = "Vendor Name";
            this.cto.Name = "cto";
            this.cto.ReadOnly = true;
            // 
            // cpchaseno
            // 
            this.cpchaseno.DataPropertyName = "chaseno";
            this.cpchaseno.HeaderText = "Chase No.";
            this.cpchaseno.Name = "cpchaseno";
            this.cpchaseno.ReadOnly = true;
            this.cpchaseno.Visible = false;
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
            // crev
            // 
            this.crev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.crev.DataPropertyName = "rev";
            this.crev.HeaderText = "Rev";
            this.crev.Name = "crev";
            this.crev.ReadOnly = true;
            this.crev.Width = 51;
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
            this.customPanel5.Location = new System.Drawing.Point(970, 3);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(197, 22);
            this.customPanel5.TabIndex = 8;
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
            this.tsbtnRequest});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(967, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn
            // 
            this.tsbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.tsbtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtn.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn.Image")));
            this.tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn.Name = "tsbtn";
            this.tsbtn.Size = new System.Drawing.Size(62, 22);
            this.tsbtn.Text = "Switch";
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
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.BackgroundImage")));
            this.historyToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // tsbtnRequest
            // 
            this.tsbtnRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRequest.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnRequest.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnRequest.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRequest.Image")));
            this.tsbtnRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRequest.Name = "tsbtnRequest";
            this.tsbtnRequest.Size = new System.Drawing.Size(63, 22);
            this.tsbtnRequest.Text = "Request";
            this.tsbtnRequest.Click += new System.EventHandler(this.tsbtnRequest_Click);
            // 
            // DisposalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.dgvDisposal);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DisposalView";
            this.Size = new System.Drawing.Size(1170, 632);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisposal)).EndInit();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisposal;
        private CustomUtil.controls.panel.CustomPanel customPanel5;
        private System.Windows.Forms.Button btnSearchItem;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRequest;
        private System.Windows.Forms.ToolStripDropDownButton tsbtn;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}
