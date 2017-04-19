namespace KDTHK_MOULD_SYSTEM.forms.po
{
    partial class PoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoView));
            this.dgvIssuePO = new System.Windows.Forms.DataGridView();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuePO)).BeginInit();
            this.bdSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIssuePO
            // 
            this.dgvIssuePO.AllowUserToAddRows = false;
            this.dgvIssuePO.AllowUserToDeleteRows = false;
            this.dgvIssuePO.AllowUserToResizeRows = false;
            this.dgvIssuePO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIssuePO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIssuePO.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvIssuePO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIssuePO.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvIssuePO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIssuePO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuePO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cchaseno,
            this.cmould,
            this.cpartno,
            this.crev,
            this.cdiv,
            this.cvendor,
            this.cvendorname,
            this.cremarks,
            this.cpo});
            this.dgvIssuePO.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvIssuePO.Location = new System.Drawing.Point(3, 26);
            this.dgvIssuePO.Name = "dgvIssuePO";
            this.dgvIssuePO.RowHeadersVisible = false;
            this.dgvIssuePO.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvIssuePO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIssuePO.Size = new System.Drawing.Size(1131, 597);
            this.dgvIssuePO.TabIndex = 1;
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
            this.bdSearch.Location = new System.Drawing.Point(937, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 6;
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
            this.tsbtnTemplate,
            this.tsbtnUpload,
            this.tsbtnDownload,
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSave.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(41, 22);
            this.tsbtnSave.Text = "Save";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
            // 
            // cchaseno
            // 
            this.cchaseno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.HeaderText = "ChaseNo.";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            this.cchaseno.Width = 83;
            // 
            // cmould
            // 
            this.cmould.DataPropertyName = "mould";
            this.cmould.HeaderText = "Mould";
            this.cmould.Name = "cmould";
            this.cmould.ReadOnly = true;
            // 
            // cpartno
            // 
            this.cpartno.DataPropertyName = "partno";
            this.cpartno.HeaderText = "PartNo.";
            this.cpartno.Name = "cpartno";
            this.cpartno.ReadOnly = true;
            // 
            // crev
            // 
            this.crev.DataPropertyName = "rev";
            this.crev.HeaderText = "Rev";
            this.crev.Name = "crev";
            this.crev.ReadOnly = true;
            // 
            // cdiv
            // 
            this.cdiv.DataPropertyName = "div";
            this.cdiv.HeaderText = "Div";
            this.cdiv.Name = "cdiv";
            this.cdiv.ReadOnly = true;
            // 
            // cvendor
            // 
            this.cvendor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cvendor.DataPropertyName = "vendor";
            this.cvendor.HeaderText = "Vendor";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            this.cvendor.Width = 70;
            // 
            // cvendorname
            // 
            this.cvendorname.DataPropertyName = "vendorname";
            this.cvendorname.HeaderText = "VendorName";
            this.cvendorname.Name = "cvendorname";
            this.cvendorname.ReadOnly = true;
            // 
            // cremarks
            // 
            this.cremarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cremarks.DataPropertyName = "request";
            this.cremarks.HeaderText = "RequestNo.";
            this.cremarks.Name = "cremarks";
            // 
            // cpo
            // 
            this.cpo.DataPropertyName = "po";
            this.cpo.HeaderText = "PO";
            this.cpo.Name = "cpo";
            // 
            // PoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bdSearch);
            this.Controls.Add(this.dgvIssuePO);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PoView";
            this.Size = new System.Drawing.Size(1137, 626);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuePO)).EndInit();
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssuePO;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnTemplate;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpo;
    }
}
