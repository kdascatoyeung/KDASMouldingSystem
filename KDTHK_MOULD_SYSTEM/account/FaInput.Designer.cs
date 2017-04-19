namespace KDTHK_MOULD_SYSTEM.account
{
    partial class FaInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaInput));
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rejectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGenerate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReject = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.capproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cassetclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capptype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmgtno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.AllowUserToResizeRows = false;
            this.dgvInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInput.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capproval,
            this.cfa,
            this.cassetclass,
            this.capptype,
            this.cmgtno,
            this.cdesc,
            this.cmpa,
            this.cfile,
            this.cpath,
            this.cchaseno,
            this.cid});
            this.dgvInput.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInput.Location = new System.Drawing.Point(3, 28);
            this.dgvInput.MultiSelect = false;
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInput.Size = new System.Drawing.Size(1144, 581);
            this.dgvInput.TabIndex = 1;
            this.dgvInput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellContentClick);
            this.dgvInput.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellEndEdit);
            this.dgvInput.SelectionChanged += new System.EventHandler(this.dgvInput_SelectionChanged);
            this.dgvInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvInput_KeyDown);
            this.dgvInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvInput_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveToolStripMenuItem,
            this.rejectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("approveToolStripMenuItem.Image")));
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // rejectToolStripMenuItem
            // 
            this.rejectToolStripMenuItem.Image = global::KDTHK_MOULD_SYSTEM.Properties.Resources.cross;
            this.rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            this.rejectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rejectToolStripMenuItem.Text = "Reject";
            this.rejectToolStripMenuItem.Click += new System.EventHandler(this.rejectToolStripMenuItem_Click);
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
            this.tsbtnGenerate,
            this.tsbtnApprove,
            this.tsbtnReject,
            this.tsbtnDelete,
            this.tsbtnSave,
            this.tsbtnSearch,
            this.tstxtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1150, 25);
            this.toolStrip1.TabIndex = 12;
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
            // tsbtnGenerate
            // 
            this.tsbtnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnGenerate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnGenerate.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGenerate.Image")));
            this.tsbtnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGenerate.Name = "tsbtnGenerate";
            this.tsbtnGenerate.Size = new System.Drawing.Size(70, 22);
            this.tsbtnGenerate.Text = "Generate";
            this.tsbtnGenerate.Click += new System.EventHandler(this.tsbtnGenerate_Click);
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
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(3, 612);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 18);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Unknown";
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(131, 612);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(79, 18);
            this.lblSelected.TabIndex = 20;
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
            this.capproval.ReadOnly = true;
            //this.capproval.ReadOnly = false; /*Added by Cato Yeung 2017/04/13 */
            // 
            // cfa
            // 
            this.cfa.DataPropertyName = "fixedasset";
            this.cfa.HeaderText = "Fixed Asset";
            this.cfa.Name = "cfa";
            // 
            // cassetclass
            // 
            this.cassetclass.DataPropertyName = "assetclass";
            this.cassetclass.HeaderText = "Asset Class";
            this.cassetclass.Name = "cassetclass";
            this.cassetclass.ReadOnly = true;
            this.cassetclass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // capptype
            // 
            this.capptype.DataPropertyName = "apptype";
            this.capptype.HeaderText = "Type";
            this.capptype.Name = "capptype";
            this.capptype.ReadOnly = true;
            // 
            // cmgtno
            // 
            this.cmgtno.DataPropertyName = "pdfid";
            this.cmgtno.HeaderText = "管理No.";
            this.cmgtno.Name = "cmgtno";
            this.cmgtno.ReadOnly = true;
            // 
            // cdesc
            // 
            this.cdesc.DataPropertyName = "desc";
            this.cdesc.HeaderText = "Description";
            this.cdesc.Name = "cdesc";
            this.cdesc.ReadOnly = true;
            // 
            // cmpa
            // 
            this.cmpa.DataPropertyName = "mpa";
            this.cmpa.HeaderText = "MPA (50%)";
            this.cmpa.Name = "cmpa";
            this.cmpa.ReadOnly = true;
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
            // 
            // cpath
            // 
            this.cpath.DataPropertyName = "path";
            this.cpath.HeaderText = "path";
            this.cpath.Name = "cpath";
            this.cpath.ReadOnly = true;
            this.cpath.Visible = false;
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
            // FaInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvInput);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaInput";
            this.Size = new System.Drawing.Size(1150, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnApprove;
        private System.Windows.Forms.ToolStripButton tsbtnGenerate;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripButton tsbtnReject;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rejectToolStripMenuItem;
        private System.Windows.Forms.DataGridViewComboBoxColumn capproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassetclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn capptype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmgtno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpa;
        private System.Windows.Forms.DataGridViewLinkColumn cfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
    }
}
