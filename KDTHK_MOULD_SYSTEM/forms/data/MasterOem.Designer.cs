namespace KDTHK_MOULD_SYSTEM.forms.data
{
    partial class MasterOem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterOem));
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvOem = new System.Windows.Forms.DataGridView();
            this.ccode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccontent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mouldCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bdSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOem)).BeginInit();
            this.SuspendLayout();
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
            this.bdSearch.Location = new System.Drawing.Point(974, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 18;
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
            this.toolStripButton1,
            this.tsbtnNew,
            this.tsbtnTemplate,
            this.tsbtnUpload,
            this.tsbtnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(971, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvOem
            // 
            this.dgvOem.AllowUserToAddRows = false;
            this.dgvOem.AllowUserToDeleteRows = false;
            this.dgvOem.AllowUserToResizeRows = false;
            this.dgvOem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvOem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvOem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccode,
            this.ccontent,
            this.caccount,
            this.ccost,
            this.cremarks});
            this.dgvOem.Location = new System.Drawing.Point(3, 26);
            this.dgvOem.MultiSelect = false;
            this.dgvOem.Name = "dgvOem";
            this.dgvOem.ReadOnly = true;
            this.dgvOem.RowHeadersVisible = false;
            this.dgvOem.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvOem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOem.Size = new System.Drawing.Size(1168, 607);
            this.dgvOem.TabIndex = 20;
            this.dgvOem.DoubleClick += new System.EventHandler(this.dgvOem_DoubleClick);
            this.dgvOem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOem_KeyDown);
            // 
            // ccode
            // 
            this.ccode.DataPropertyName = "code";
            this.ccode.HeaderText = "Code";
            this.ccode.Name = "ccode";
            this.ccode.ReadOnly = true;
            // 
            // ccontent
            // 
            this.ccontent.DataPropertyName = "content";
            this.ccontent.HeaderText = "Content";
            this.ccontent.Name = "ccontent";
            this.ccontent.ReadOnly = true;
            // 
            // caccount
            // 
            this.caccount.DataPropertyName = "accountcode";
            this.caccount.HeaderText = "Account Code";
            this.caccount.Name = "caccount";
            this.caccount.ReadOnly = true;
            // 
            // ccost
            // 
            this.ccost.DataPropertyName = "costcentre";
            this.ccost.HeaderText = "Cost Centre";
            this.ccost.Name = "ccost";
            this.ccost.ReadOnly = true;
            // 
            // cremarks
            // 
            this.cremarks.DataPropertyName = "remarks";
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            this.cremarks.ReadOnly = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouldCodeToolStripMenuItem,
            this.vendorToolStripMenuItem});
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Switch";
            // 
            // mouldCodeToolStripMenuItem
            // 
            this.mouldCodeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mouldCodeToolStripMenuItem.BackgroundImage")));
            this.mouldCodeToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.mouldCodeToolStripMenuItem.Name = "mouldCodeToolStripMenuItem";
            this.mouldCodeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mouldCodeToolStripMenuItem.Text = "MouldCode";
            this.mouldCodeToolStripMenuItem.Click += new System.EventHandler(this.mouldCodeToolStripMenuItem_Click);
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vendorToolStripMenuItem.BackgroundImage")));
            this.vendorToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vendorToolStripMenuItem.Text = "Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNew.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnNew.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(41, 22);
            this.tsbtnNew.Text = "New";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
            // 
            // tsbtnTemplate
            // 
            this.tsbtnTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTemplate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnTemplate.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTemplate.Image")));
            this.tsbtnTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTemplate.Name = "tsbtnTemplate";
            this.tsbtnTemplate.Size = new System.Drawing.Size(70, 22);
            this.tsbtnTemplate.Text = "Template";
            this.tsbtnTemplate.Click += new System.EventHandler(this.tsbtnTemplate_Click);
            // 
            // tsbtnUpload
            // 
            this.tsbtnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUpload.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnUpload.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnUpload.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpload.Image")));
            this.tsbtnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpload.Name = "tsbtnUpload";
            this.tsbtnUpload.Size = new System.Drawing.Size(56, 22);
            this.tsbtnUpload.Text = "Upload";
            this.tsbtnUpload.Click += new System.EventHandler(this.tsbtnUpload_Click);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MasterOem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvOem);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bdSearch);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterOem";
            this.Size = new System.Drawing.Size(1174, 636);
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mouldCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnTemplate;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.DataGridView dgvOem;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccontent;
        private System.Windows.Forms.DataGridViewTextBoxColumn caccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccost;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
    }
}
