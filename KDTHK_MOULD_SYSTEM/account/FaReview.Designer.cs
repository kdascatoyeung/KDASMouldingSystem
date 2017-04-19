namespace KDTHK_MOULD_SYSTEM.account
{
    partial class FaReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaReview));
            this.dgvReviewer = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReject = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tstxtAssetClass = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.capproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cassetclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmgtno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccostcenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crespcostcenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cringino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cadditional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewer)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReviewer
            // 
            this.dgvReviewer.AllowUserToAddRows = false;
            this.dgvReviewer.AllowUserToDeleteRows = false;
            this.dgvReviewer.AllowUserToResizeRows = false;
            this.dgvReviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReviewer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReviewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReviewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvReviewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReviewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capproval,
            this.cassetclass,
            this.ccreatedby,
            this.cmould,
            this.cmgtno,
            this.cdesc,
            this.cmpa,
            this.ccostcenter,
            this.crespcostcenter,
            this.clocation,
            this.cringino,
            this.cfile,
            this.cadditional,
            this.cpath,
            this.cchaseno,
            this.cid});
            this.dgvReviewer.Location = new System.Drawing.Point(3, 28);
            this.dgvReviewer.Name = "dgvReviewer";
            this.dgvReviewer.RowHeadersVisible = false;
            this.dgvReviewer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvReviewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReviewer.Size = new System.Drawing.Size(1151, 588);
            this.dgvReviewer.TabIndex = 3;
            this.dgvReviewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReviewer_CellContentClick);
            this.dgvReviewer.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReviewer_ColumnHeaderMouseClick);
            this.dgvReviewer.SelectionChanged += new System.EventHandler(this.dgvReviewer_SelectionChanged);
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
            this.tsbtnRefresh,
            this.tsbtnApprove,
            this.tsbtnReject,
            this.tsbtnDownload,
            this.tsbtnDelete,
            this.tsbtnSave,
            this.tsbtnSearch,
            this.tstxtAssetClass,
            this.toolStripLabel1,
            this.tstxtSearch,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1157, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnRefresh
            // 
            this.tsbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnRefresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnRefresh.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRefresh.Image")));
            this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRefresh.Name = "tsbtnRefresh";
            this.tsbtnRefresh.Size = new System.Drawing.Size(60, 22);
            this.tsbtnRefresh.Text = "Refresh";
            this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
            // 
            // tsbtnApprove
            // 
            this.tsbtnApprove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnApprove.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnApprove.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnApprove.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnApprove.Image")));
            this.tsbtnApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnApprove.Name = "tsbtnApprove";
            this.tsbtnApprove.Size = new System.Drawing.Size(85, 22);
            this.tsbtnApprove.Text = "Approve All";
            this.tsbtnApprove.Click += new System.EventHandler(this.tsbtnApprove_Click);
            // 
            // tsbtnReject
            // 
            this.tsbtnReject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnReject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnReject.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnReject.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReject.Image")));
            this.tsbtnReject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReject.Name = "tsbtnReject";
            this.tsbtnReject.Size = new System.Drawing.Size(71, 22);
            this.tsbtnReject.Text = "Reject All";
            this.tsbtnReject.Click += new System.EventHandler(this.tsbtnReject_Click);
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
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnDelete.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(54, 22);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
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
            // tsbtnSearch
            // 
            this.tsbtnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(53, 22);
            this.tsbtnSearch.Text = "Search";
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // tstxtAssetClass
            // 
            this.tstxtAssetClass.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstxtAssetClass.Name = "tstxtAssetClass";
            this.tstxtAssetClass.Size = new System.Drawing.Size(100, 25);
            this.tstxtAssetClass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstxtAssetClass_KeyDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel1.Text = "   Asset Class";
            // 
            // tstxtSearch
            // 
            this.tstxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstxtSearch.Name = "tstxtSearch";
            this.tstxtSearch.Size = new System.Drawing.Size(100, 25);
            this.tstxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstxtSearch_KeyDown);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel2.Text = "管理No.";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(3, 619);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 18);
            this.lblCount.TabIndex = 14;
            this.lblCount.Text = "Unknown";
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(131, 619);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(79, 18);
            this.lblSelected.TabIndex = 19;
            this.lblSelected.Text = "Selected : 0";
            // 
            // capproval
            // 
            this.capproval.DataPropertyName = "approval";
            this.capproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capproval.HeaderText = "Approval";
            this.capproval.Items.AddRange(new object[] {
            "Please select",
            "Approve",
            "Reject"});
            this.capproval.Name = "capproval";
            this.capproval.Width = 63;
            // 
            // cassetclass
            // 
            this.cassetclass.DataPropertyName = "assetclass";
            this.cassetclass.HeaderText = "Asset Class";
            this.cassetclass.Name = "cassetclass";
            this.cassetclass.ReadOnly = true;
            this.cassetclass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cassetclass.Width = 94;
            // 
            // ccreatedby
            // 
            this.ccreatedby.DataPropertyName = "createdby";
            this.ccreatedby.HeaderText = "Created by";
            this.ccreatedby.Name = "ccreatedby";
            this.ccreatedby.ReadOnly = true;
            this.ccreatedby.Width = 180;
            // 
            // cmould
            // 
            this.cmould.DataPropertyName = "mould";
            this.cmould.HeaderText = "Mould";
            this.cmould.Name = "cmould";
            this.cmould.ReadOnly = true;
            this.cmould.Width = 110;
            // 
            // cmgtno
            // 
            this.cmgtno.DataPropertyName = "pdfid";
            this.cmgtno.HeaderText = "管理No.";
            this.cmgtno.Name = "cmgtno";
            this.cmgtno.ReadOnly = true;
            this.cmgtno.Width = 110;
            // 
            // cdesc
            // 
            this.cdesc.DataPropertyName = "desc";
            this.cdesc.HeaderText = "Description";
            this.cdesc.Name = "cdesc";
            this.cdesc.ReadOnly = true;
            this.cdesc.Width = 220;
            // 
            // cmpa
            // 
            this.cmpa.DataPropertyName = "mpa";
            this.cmpa.HeaderText = "MPA (50%)";
            this.cmpa.Name = "cmpa";
            this.cmpa.ReadOnly = true;
            this.cmpa.Width = 90;
            // 
            // ccostcenter
            // 
            this.ccostcenter.DataPropertyName = "costcenter";
            this.ccostcenter.HeaderText = "Cost Center";
            this.ccostcenter.Name = "ccostcenter";
            this.ccostcenter.ReadOnly = true;
            this.ccostcenter.Width = 94;
            // 
            // crespcostcenter
            // 
            this.crespcostcenter.DataPropertyName = "resp";
            this.crespcostcenter.HeaderText = "Resp. Cost Center";
            this.crespcostcenter.Name = "crespcostcenter";
            this.crespcostcenter.ReadOnly = true;
            this.crespcostcenter.Width = 115;
            // 
            // clocation
            // 
            this.clocation.DataPropertyName = "location";
            this.clocation.HeaderText = "Location";
            this.clocation.Name = "clocation";
            this.clocation.ReadOnly = true;
            // 
            // cringino
            // 
            this.cringino.DataPropertyName = "ringi";
            this.cringino.HeaderText = "Ringi No.";
            this.cringino.Name = "cringino";
            this.cringino.ReadOnly = true;
            // 
            // cfile
            // 
            this.cfile.DataPropertyName = "link";
            this.cfile.HeaderText = "Ref Link";
            this.cfile.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.cfile.Name = "cfile";
            this.cfile.ReadOnly = true;
            this.cfile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cfile.Width = 90;
            // 
            // cadditional
            // 
            this.cadditional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cadditional.DataPropertyName = "assetdesc";
            this.cadditional.HeaderText = "Asset Description";
            this.cadditional.Name = "cadditional";
            this.cadditional.ReadOnly = true;
            this.cadditional.Width = 116;
            // 
            // cpath
            // 
            this.cpath.DataPropertyName = "path";
            this.cpath.HeaderText = "path";
            this.cpath.Name = "cpath";
            this.cpath.Visible = false;
            this.cpath.Width = 57;
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.HeaderText = "chaseno";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.Visible = false;
            this.cchaseno.Width = 78;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id";
            this.cid.HeaderText = "id";
            this.cid.Name = "cid";
            this.cid.Visible = false;
            this.cid.Width = 43;
            // 
            // FaReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvReviewer);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaReview";
            this.Size = new System.Drawing.Size(1157, 637);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewer)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReviewer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnApprove;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripButton tsbtnReject;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripTextBox tstxtAssetClass;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.DataGridViewComboBoxColumn capproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassetclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreatedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmgtno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccostcenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn crespcostcenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cringino;
        private System.Windows.Forms.DataGridViewLinkColumn cfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadditional;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
    }
}
