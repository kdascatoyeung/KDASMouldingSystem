namespace KDTHK_MOULD_SYSTEM.forms.data
{
    partial class MasterVendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterVendor));
            this.dgvVendor = new System.Windows.Forms.DataGridView();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mouldCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cterms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).BeginInit();
            this.bdSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVendor
            // 
            this.dgvVendor.AllowUserToAddRows = false;
            this.dgvVendor.AllowUserToDeleteRows = false;
            this.dgvVendor.AllowUserToResizeRows = false;
            this.dgvVendor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVendor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVendor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvVendor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cvendor,
            this.cname,
            this.cpgroup,
            this.cpay,
            this.cterms,
            this.crequest,
            this.cedi,
            this.cremarks});
            this.dgvVendor.Location = new System.Drawing.Point(3, 26);
            this.dgvVendor.MultiSelect = false;
            this.dgvVendor.Name = "dgvVendor";
            this.dgvVendor.ReadOnly = true;
            this.dgvVendor.RowHeadersVisible = false;
            this.dgvVendor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvVendor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendor.Size = new System.Drawing.Size(1152, 610);
            this.dgvVendor.TabIndex = 18;
            this.dgvVendor.DoubleClick += new System.EventHandler(this.dgvVendor_DoubleClick);
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
            this.bdSearch.Location = new System.Drawing.Point(958, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 17;
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
            this.toolStrip1.Size = new System.Drawing.Size(955, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouldCodeToolStripMenuItem,
            this.oEMToolStripMenuItem});
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
            // oEMToolStripMenuItem
            // 
            this.oEMToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oEMToolStripMenuItem.BackgroundImage")));
            this.oEMToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.oEMToolStripMenuItem.Name = "oEMToolStripMenuItem";
            this.oEMToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.oEMToolStripMenuItem.Text = "OEM";
            this.oEMToolStripMenuItem.Click += new System.EventHandler(this.oEMToolStripMenuItem_Click);
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
            this.cname.HeaderText = "Name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Width = 63;
            // 
            // cpgroup
            // 
            this.cpgroup.DataPropertyName = "pgroup";
            this.cpgroup.HeaderText = "Pur.G";
            this.cpgroup.Name = "cpgroup";
            this.cpgroup.ReadOnly = true;
            // 
            // cpay
            // 
            this.cpay.DataPropertyName = "cur";
            this.cpay.HeaderText = "Pay Cur.";
            this.cpay.Name = "cpay";
            this.cpay.ReadOnly = true;
            // 
            // cterms
            // 
            this.cterms.DataPropertyName = "terms";
            this.cterms.HeaderText = "Pay Terms";
            this.cterms.Name = "cterms";
            this.cterms.ReadOnly = true;
            // 
            // crequest
            // 
            this.crequest.DataPropertyName = "request";
            this.crequest.HeaderText = "Request";
            this.crequest.Name = "crequest";
            this.crequest.ReadOnly = true;
            // 
            // cedi
            // 
            this.cedi.DataPropertyName = "edi";
            this.cedi.HeaderText = "EDI";
            this.cedi.Name = "cedi";
            this.cedi.ReadOnly = true;
            // 
            // cremarks
            // 
            this.cremarks.DataPropertyName = "remarks";
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            this.cremarks.ReadOnly = true;
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
            // MasterVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvVendor);
            this.Controls.Add(this.bdSearch);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterVendor";
            this.Size = new System.Drawing.Size(1158, 639);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendor)).EndInit();
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendor;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mouldCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnTemplate;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cterms;
        private System.Windows.Forms.DataGridViewTextBoxColumn crequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
    }
}
