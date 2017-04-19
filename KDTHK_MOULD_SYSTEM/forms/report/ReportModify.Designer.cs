namespace KDTHK_MOULD_SYSTEM.forms.report
{
    partial class ReportModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportModify));
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnTemplate = new System.Windows.Forms.ToolStripDropDownButton();
            this.modifyRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.dgvModifyRecord = new System.Windows.Forms.DataGridView();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyRecord)).BeginInit();
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
            this.bdSearch.Location = new System.Drawing.Point(967, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 7;
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
            this.tsbtnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnTemplate
            // 
            this.tsbtnTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTemplate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyRecordToolStripMenuItem,
            this.paymentListToolStripMenuItem,
            this.pOCollectionToolStripMenuItem,
            this.baseToolStripMenuItem});
            this.tsbtnTemplate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnTemplate.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTemplate.Image")));
            this.tsbtnTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTemplate.Name = "tsbtnTemplate";
            this.tsbtnTemplate.Size = new System.Drawing.Size(62, 22);
            this.tsbtnTemplate.Text = "Switch";
            // 
            // modifyRecordToolStripMenuItem
            // 
            this.modifyRecordToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifyRecordToolStripMenuItem.BackgroundImage")));
            this.modifyRecordToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.modifyRecordToolStripMenuItem.Name = "modifyRecordToolStripMenuItem";
            this.modifyRecordToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.modifyRecordToolStripMenuItem.Tag = "cdreport";
            this.modifyRecordToolStripMenuItem.Text = "CD Report";
            this.modifyRecordToolStripMenuItem.Click += new System.EventHandler(this.SwitchView);
            // 
            // paymentListToolStripMenuItem
            // 
            this.paymentListToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paymentListToolStripMenuItem.BackgroundImage")));
            this.paymentListToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.paymentListToolStripMenuItem.Name = "paymentListToolStripMenuItem";
            this.paymentListToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.paymentListToolStripMenuItem.Tag = "payment";
            this.paymentListToolStripMenuItem.Text = "Payment List";
            this.paymentListToolStripMenuItem.Click += new System.EventHandler(this.SwitchView);
            // 
            // pOCollectionToolStripMenuItem
            // 
            this.pOCollectionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pOCollectionToolStripMenuItem.BackgroundImage")));
            this.pOCollectionToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.pOCollectionToolStripMenuItem.Name = "pOCollectionToolStripMenuItem";
            this.pOCollectionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.pOCollectionToolStripMenuItem.Tag = "collection";
            this.pOCollectionToolStripMenuItem.Text = "PO Collection";
            this.pOCollectionToolStripMenuItem.Click += new System.EventHandler(this.SwitchView);
            // 
            // baseToolStripMenuItem
            // 
            this.baseToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("baseToolStripMenuItem.BackgroundImage")));
            this.baseToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            this.baseToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.baseToolStripMenuItem.Tag = "pbase";
            this.baseToolStripMenuItem.Text = "Base";
            this.baseToolStripMenuItem.Click += new System.EventHandler(this.SwitchView);
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
            // dgvModifyRecord
            // 
            this.dgvModifyRecord.AllowUserToAddRows = false;
            this.dgvModifyRecord.AllowUserToDeleteRows = false;
            this.dgvModifyRecord.AllowUserToResizeRows = false;
            this.dgvModifyRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModifyRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModifyRecord.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvModifyRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModifyRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvModifyRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModifyRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModifyRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cvendor,
            this.cvendorname,
            this.cpgroup,
            this.cchaseno,
            this.cmould,
            this.cpartno,
            this.crev,
            this.cdiv,
            this.cmodel,
            this.chkd,
            this.cpo,
            this.cinstock});
            this.dgvModifyRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvModifyRecord.Location = new System.Drawing.Point(3, 26);
            this.dgvModifyRecord.Name = "dgvModifyRecord";
            this.dgvModifyRecord.ReadOnly = true;
            this.dgvModifyRecord.RowHeadersVisible = false;
            this.dgvModifyRecord.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvModifyRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModifyRecord.Size = new System.Drawing.Size(1161, 610);
            this.dgvModifyRecord.TabIndex = 24;
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
            this.cvendorname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cvendorname.DataPropertyName = "name";
            this.cvendorname.HeaderText = "VendorName";
            this.cvendorname.Name = "cvendorname";
            this.cvendorname.ReadOnly = true;
            this.cvendorname.Width = 101;
            // 
            // cpgroup
            // 
            this.cpgroup.DataPropertyName = "pgroup";
            this.cpgroup.HeaderText = "Pur.G";
            this.cpgroup.Name = "cpgroup";
            this.cpgroup.ReadOnly = true;
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
            this.cmould.HeaderText = "Mould No.";
            this.cmould.Name = "cmould";
            this.cmould.ReadOnly = true;
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
            // cmodel
            // 
            this.cmodel.DataPropertyName = "model";
            this.cmodel.HeaderText = "Model";
            this.cmodel.Name = "cmodel";
            this.cmodel.ReadOnly = true;
            // 
            // chkd
            // 
            this.chkd.DataPropertyName = "hkd";
            this.chkd.HeaderText = "AmountHkd";
            this.chkd.Name = "chkd";
            this.chkd.ReadOnly = true;
            // 
            // cpo
            // 
            this.cpo.DataPropertyName = "po";
            this.cpo.HeaderText = "PO";
            this.cpo.Name = "cpo";
            this.cpo.ReadOnly = true;
            // 
            // cinstock
            // 
            this.cinstock.DataPropertyName = "instock";
            this.cinstock.HeaderText = "In-Stock";
            this.cinstock.Name = "cinstock";
            this.cinstock.ReadOnly = true;
            // 
            // ReportModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvModifyRecord);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bdSearch);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportModify";
            this.Size = new System.Drawing.Size(1167, 639);
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModifyRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnTemplate;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.DataGridView dgvModifyRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinstock;
    }
}
