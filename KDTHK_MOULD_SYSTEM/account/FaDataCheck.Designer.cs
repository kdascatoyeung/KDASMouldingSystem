namespace KDTHK_MOULD_SYSTEM.account
{
    partial class FaDataCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaDataCheck));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReject = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.dgvDataCheck = new System.Windows.Forms.DataGridView();
            this.capproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmgtno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cassetclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCheck)).BeginInit();
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
            this.tsbtnDownload,
            this.tsbtnSearch,
            this.tstxtSearch,
            this.tsbtnApprove,
            this.tsbtnReject,
            this.tsbtnDelete,
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1191, 25);
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
            this.tsbtnDownload.Visible = false;
            this.tsbtnDownload.Click += new System.EventHandler(this.tsbtnDownload_Click);
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
            // tstxtSearch
            // 
            this.tstxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstxtSearch.Name = "tstxtSearch";
            this.tstxtSearch.Size = new System.Drawing.Size(100, 25);
            this.tstxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstxtSearch_KeyDown);
            this.tstxtSearch.Click += new System.EventHandler(this.tstxtSearch_Click);
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
            // dgvDataCheck
            // 
            this.dgvDataCheck.AllowUserToAddRows = false;
            this.dgvDataCheck.AllowUserToDeleteRows = false;
            this.dgvDataCheck.AllowUserToResizeRows = false;
            this.dgvDataCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataCheck.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDataCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDataCheck.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvDataCheck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDataCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capproval,
            this.cStatus,
            this.cmgtno,
            this.cassetclass,
            this.cFa,
            this.cdesc,
            this.cmpa,
            this.cchaseno,
            this.cid});
            this.dgvDataCheck.Location = new System.Drawing.Point(6, 26);
            this.dgvDataCheck.Name = "dgvDataCheck";
            this.dgvDataCheck.RowHeadersVisible = false;
            this.dgvDataCheck.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvDataCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataCheck.Size = new System.Drawing.Size(1191, 582);
            this.dgvDataCheck.TabIndex = 16;
            this.dgvDataCheck.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDataCheck_ColumnHeaderMouseClick);
            this.dgvDataCheck.SelectionChanged += new System.EventHandler(this.dgvDataCheck_SelectionChanged);
            // 
            // capproval
            // 
            this.capproval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.capproval.DataPropertyName = "app";
            this.capproval.FillWeight = 17.7665F;
            this.capproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capproval.HeaderText = "Approval";
            this.capproval.Items.AddRange(new object[] {
            "Please select",
            "Approve",
            "Reject"});
            this.capproval.Name = "capproval";
            this.capproval.Width = 63;
            // 
            // cStatus
            // 
            this.cStatus.DataPropertyName = "apptype";
            this.cStatus.FillWeight = 17.7665F;
            this.cStatus.HeaderText = "Type";
            this.cStatus.Name = "cStatus";
            this.cStatus.ReadOnly = true;
            // 
            // cmgtno
            // 
            this.cmgtno.DataPropertyName = "pdf";
            this.cmgtno.FillWeight = 17.7665F;
            this.cmgtno.HeaderText = "管理No.";
            this.cmgtno.Name = "cmgtno";
            this.cmgtno.ReadOnly = true;
            // 
            // cassetclass
            // 
            this.cassetclass.DataPropertyName = "assetclass";
            this.cassetclass.FillWeight = 17.7665F;
            this.cassetclass.HeaderText = "Asset Class";
            this.cassetclass.Name = "cassetclass";
            this.cassetclass.ReadOnly = true;
            this.cassetclass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cFa
            // 
            this.cFa.DataPropertyName = "fa";
            this.cFa.FillWeight = 17.7665F;
            this.cFa.HeaderText = "Fixed Asset No.";
            this.cFa.Name = "cFa";
            this.cFa.ReadOnly = true;
            // 
            // cdesc
            // 
            this.cdesc.DataPropertyName = "desc";
            this.cdesc.FillWeight = 70F;
            this.cdesc.HeaderText = "Description";
            this.cdesc.Name = "cdesc";
            this.cdesc.ReadOnly = true;
            // 
            // cmpa
            // 
            this.cmpa.DataPropertyName = "mpa";
            this.cmpa.FillWeight = 17.7665F;
            this.cmpa.HeaderText = "MPA (50%)";
            this.cmpa.Name = "cmpa";
            this.cmpa.ReadOnly = true;
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.HeaderText = "chaseno";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.Visible = false;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "id";
            this.cid.HeaderText = "id";
            this.cid.Name = "cid";
            this.cid.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(3, 611);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 18);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "Unknown";
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(131, 611);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(79, 18);
            this.lblSelected.TabIndex = 18;
            this.lblSelected.Text = "Selected : 0";
            // 
            // FaDataCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dgvDataCheck);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaDataCheck";
            this.Size = new System.Drawing.Size(1191, 629);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.DataGridView dgvDataCheck;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripButton tsbtnApprove;
        private System.Windows.Forms.ToolStripButton tsbtnReject;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn capproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmgtno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassetclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
    }
}
