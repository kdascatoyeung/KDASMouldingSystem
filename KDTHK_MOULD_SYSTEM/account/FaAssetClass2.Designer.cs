namespace KDTHK_MOULD_SYSTEM.account
{
    partial class FaAssetClass2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaAssetClass2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tstxtAssetClass = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.capproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cassetclass = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.tsbtnRefresh,
            this.tsbtnApprove,
            this.tsbtnDownload,
            this.tsbtnDelete,
            this.tsbtnSave,
            this.tsbtnSearch,
            this.tstxtAssetClass,
            this.toolStripLabel1,
            this.tstxtSearch,
            this.toolStripLabel2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1190, 25);
            this.toolStrip1.TabIndex = 15;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton1.Text = "Apply All";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.AllowUserToResizeRows = false;
            this.dgvInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInput.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.cid,
            this.cchaseno});
            this.dgvInput.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInput.Location = new System.Drawing.Point(0, 25);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInput.Size = new System.Drawing.Size(1190, 599);
            this.dgvInput.TabIndex = 16;
            this.dgvInput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellContentClick);
            this.dgvInput.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInput_ColumnHeaderMouseClick);
            this.dgvInput.SelectionChanged += new System.EventHandler(this.dgvInput_SelectionChanged);
            this.dgvInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvInput_MouseDown);
            // 
            // capproval
            // 
            this.capproval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.capproval.DataPropertyName = "approval";
            this.capproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capproval.HeaderText = "Approval";
            this.capproval.Items.AddRange(new object[] {
            "Please select",
            "Approve"});
            this.capproval.Name = "capproval";
            this.capproval.Width = 63;
            // 
            // cassetclass
            // 
            this.cassetclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cassetclass.DataPropertyName = "AssetClass";
            this.cassetclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cassetclass.HeaderText = "Asset Class";
            this.cassetclass.Items.AddRange(new object[] {
            "Please select",
            "Z1110",
            "Z1120",
            "Z1310",
            "Z1320",
            "Z1330",
            "Z1400",
            "Z1500",
            "Z1600",
            "Z1710",
            "Z1720",
            "Z2510",
            "Z2520",
            "Z2710",
            "Z2720",
            "Z2730",
            "Z2800",
            "Z2900",
            "Z3010",
            "Z3020",
            "Z4000",
            "Z4200"});
            this.cassetclass.Name = "cassetclass";
            this.cassetclass.Width = 68;
            // 
            // ccreatedby
            // 
            this.ccreatedby.DataPropertyName = "CreatedBy";
            this.ccreatedby.HeaderText = "Created by";
            this.ccreatedby.Name = "ccreatedby";
            this.ccreatedby.ReadOnly = true;
            this.ccreatedby.Width = 200;
            // 
            // cmould
            // 
            this.cmould.DataPropertyName = "Mould";
            this.cmould.HeaderText = "Mould";
            this.cmould.Name = "cmould";
            this.cmould.ReadOnly = true;
            this.cmould.Width = 120;
            // 
            // cmgtno
            // 
            this.cmgtno.DataPropertyName = "MgtNo";
            this.cmgtno.HeaderText = "管理No.";
            this.cmgtno.Name = "cmgtno";
            this.cmgtno.ReadOnly = true;
            this.cmgtno.Width = 120;
            // 
            // cdesc
            // 
            this.cdesc.DataPropertyName = "Description";
            this.cdesc.HeaderText = "Description";
            this.cdesc.Name = "cdesc";
            this.cdesc.ReadOnly = true;
            this.cdesc.Width = 220;
            // 
            // cmpa
            // 
            this.cmpa.DataPropertyName = "MPA";
            this.cmpa.HeaderText = "MPA (50%)";
            this.cmpa.Name = "cmpa";
            this.cmpa.ReadOnly = true;
            // 
            // ccostcenter
            // 
            this.ccostcenter.DataPropertyName = "CostCenter";
            this.ccostcenter.HeaderText = "Cost Center";
            this.ccostcenter.Name = "ccostcenter";
            this.ccostcenter.ReadOnly = true;
            this.ccostcenter.Width = 130;
            // 
            // crespcostcenter
            // 
            this.crespcostcenter.DataPropertyName = "RespCostCenter";
            this.crespcostcenter.HeaderText = "Resp. Cost Center";
            this.crespcostcenter.Name = "crespcostcenter";
            this.crespcostcenter.ReadOnly = true;
            this.crespcostcenter.Width = 130;
            // 
            // clocation
            // 
            this.clocation.DataPropertyName = "Location";
            this.clocation.HeaderText = "Location";
            this.clocation.Name = "clocation";
            this.clocation.ReadOnly = true;
            this.clocation.Width = 130;
            // 
            // cringino
            // 
            this.cringino.DataPropertyName = "Ringi";
            this.cringino.HeaderText = "Ringi No.";
            this.cringino.Name = "cringino";
            this.cringino.ReadOnly = true;
            this.cringino.Width = 110;
            // 
            // cfile
            // 
            this.cfile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cfile.DataPropertyName = "link";
            this.cfile.HeaderText = "Ref Link";
            this.cfile.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.cfile.Name = "cfile";
            this.cfile.ReadOnly = true;
            this.cfile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cfile.Width = 69;
            // 
            // cadditional
            // 
            this.cadditional.DataPropertyName = "AdditionalAssetDescription";
            this.cadditional.HeaderText = "Additional Asset Description";
            this.cadditional.Name = "cadditional";
            this.cadditional.ReadOnly = true;
            this.cadditional.Width = 250;
            // 
            // cpath
            // 
            this.cpath.DataPropertyName = "path";
            this.cpath.HeaderText = "path";
            this.cpath.Name = "cpath";
            this.cpath.ReadOnly = true;
            this.cpath.Visible = false;
            this.cpath.Width = 57;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id";
            this.cid.HeaderText = "id";
            this.cid.Name = "cid";
            this.cid.Visible = false;
            this.cid.Width = 43;
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.HeaderText = "chaseno";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.Visible = false;
            this.cchaseno.Width = 78;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(3, 627);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 18);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "Unknown";
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(131, 627);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(79, 18);
            this.lblSelected.TabIndex = 20;
            this.lblSelected.Text = "Selected : 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveToolStripMenuItem,
            this.rejectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("approveToolStripMenuItem.Image")));
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Image = global::KDTHK_MOULD_SYSTEM.Properties.Resources.cross;
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.rejectToolStripMenuItem_Click);
            // 
            // FaAssetClass2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvInput);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaAssetClass2";
            this.Size = new System.Drawing.Size(1190, 646);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnApprove;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox tstxtAssetClass;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.DataGridViewComboBoxColumn capproval;
        private System.Windows.Forms.DataGridViewComboBoxColumn cassetclass;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
    }
}
