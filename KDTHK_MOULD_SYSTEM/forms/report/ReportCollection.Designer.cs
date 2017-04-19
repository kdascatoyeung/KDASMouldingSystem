namespace KDTHK_MOULD_SYSTEM.forms.report
{
    partial class ReportCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCollection));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.modifyRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.dgvCollection = new System.Windows.Forms.DataGridView();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpassdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccollectdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cqstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cissued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.bdSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollection)).BeginInit();
            this.SuspendLayout();
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
            this.tsbtnUpload,
            this.tsbtnDownload,
            this.tsbtnSave});
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
            this.pOCollectionToolStripMenuItem,
            this.modifyRecordToolStripMenuItem,
            this.paymentListToolStripMenuItem,
            this.baseToolStripMenuItem});
            this.tsbtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtn.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn.Image")));
            this.tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn.Name = "tsbtn";
            this.tsbtn.Size = new System.Drawing.Size(62, 22);
            this.tsbtn.Text = "Switch";
            // 
            // modifyRecordToolStripMenuItem
            // 
            this.modifyRecordToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modifyRecordToolStripMenuItem.BackgroundImage")));
            this.modifyRecordToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.modifyRecordToolStripMenuItem.Name = "modifyRecordToolStripMenuItem";
            this.modifyRecordToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modifyRecordToolStripMenuItem.Tag = "modify";
            this.modifyRecordToolStripMenuItem.Text = "Modify Record";
            this.modifyRecordToolStripMenuItem.Click += new System.EventHandler(this.SwitchView);
            // 
            // paymentListToolStripMenuItem
            // 
            this.paymentListToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paymentListToolStripMenuItem.BackgroundImage")));
            this.paymentListToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.paymentListToolStripMenuItem.Name = "paymentListToolStripMenuItem";
            this.paymentListToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.paymentListToolStripMenuItem.Tag = "payment";
            this.paymentListToolStripMenuItem.Text = "Payment List";
            this.paymentListToolStripMenuItem.Click += new System.EventHandler(this.SwitchView);
            // 
            // pOCollectionToolStripMenuItem
            // 
            this.pOCollectionToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pOCollectionToolStripMenuItem.BackgroundImage")));
            this.pOCollectionToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.pOCollectionToolStripMenuItem.Name = "pOCollectionToolStripMenuItem";
            this.pOCollectionToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.pOCollectionToolStripMenuItem.Tag = "cdreport";
            this.pOCollectionToolStripMenuItem.Text = "CD Report";
            this.pOCollectionToolStripMenuItem.Click += new System.EventHandler(this.SwitchView);
            // 
            // baseToolStripMenuItem
            // 
            this.baseToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("baseToolStripMenuItem.BackgroundImage")));
            this.baseToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
            this.baseToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
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
            this.bdSearch.Location = new System.Drawing.Point(970, 0);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 24;
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
            // dgvCollection
            // 
            this.dgvCollection.AllowUserToAddRows = false;
            this.dgvCollection.AllowUserToDeleteRows = false;
            this.dgvCollection.AllowUserToResizeRows = false;
            this.dgvCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCollection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCollection.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCollection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCollection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvCollection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cstatus,
            this.cpassdate,
            this.ccollectdate,
            this.cqstatus,
            this.cvendor,
            this.cvendorname,
            this.cpgroup,
            this.cmodel,
            this.cmould,
            this.cpartno,
            this.crev,
            this.cdiv,
            this.chkd,
            this.cpo,
            this.cissued});
            this.dgvCollection.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCollection.Location = new System.Drawing.Point(3, 26);
            this.dgvCollection.Name = "dgvCollection";
            this.dgvCollection.ReadOnly = true;
            this.dgvCollection.RowHeadersVisible = false;
            this.dgvCollection.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCollection.Size = new System.Drawing.Size(1164, 614);
            this.dgvCollection.TabIndex = 25;
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
            // cstatus
            // 
            this.cstatus.DataPropertyName = "pstatus";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cstatus.DefaultCellStyle = dataGridViewCellStyle1;
            this.cstatus.HeaderText = "仕樣書狀況";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            // 
            // cpassdate
            // 
            this.cpassdate.DataPropertyName = "pdate";
            this.cpassdate.HeaderText = "合格日";
            this.cpassdate.Name = "cpassdate";
            this.cpassdate.ReadOnly = true;
            // 
            // ccollectdate
            // 
            this.ccollectdate.DataPropertyName = "cdate";
            this.ccollectdate.HeaderText = "予定回收日";
            this.ccollectdate.Name = "ccollectdate";
            this.ccollectdate.ReadOnly = true;
            // 
            // cqstatus
            // 
            this.cqstatus.DataPropertyName = "status";
            this.cqstatus.HeaderText = "Status";
            this.cqstatus.Name = "cqstatus";
            this.cqstatus.ReadOnly = true;
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
            this.cvendorname.DataPropertyName = "name";
            this.cvendorname.HeaderText = "VendorName";
            this.cvendorname.Name = "cvendorname";
            this.cvendorname.ReadOnly = true;
            // 
            // cpgroup
            // 
            this.cpgroup.DataPropertyName = "pgroup";
            this.cpgroup.HeaderText = "Pur.G";
            this.cpgroup.Name = "cpgroup";
            this.cpgroup.ReadOnly = true;
            // 
            // cmodel
            // 
            this.cmodel.DataPropertyName = "model";
            this.cmodel.HeaderText = "Model";
            this.cmodel.Name = "cmodel";
            this.cmodel.ReadOnly = true;
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
            // cissued
            // 
            this.cissued.DataPropertyName = "issued";
            this.cissued.HeaderText = "Issued";
            this.cissued.Name = "cissued";
            this.cissued.ReadOnly = true;
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
            // ReportCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvCollection);
            this.Controls.Add(this.bdSearch);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportCollection";
            this.Size = new System.Drawing.Size(1170, 643);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtn;
        private System.Windows.Forms.ToolStripMenuItem pOCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.DataGridView dgvCollection;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpassdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccollectdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cqstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn chkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cissued;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
    }
}
