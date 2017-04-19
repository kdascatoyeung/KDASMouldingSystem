namespace KDTHK_MOULD_SYSTEM.account
{
    partial class FaAssetClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaAssetClass));
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.capproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cdownload = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
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
            this.dgvInput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInput.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capproval,
            this.cdownload,
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
            this.cchaseno});
            this.dgvInput.Location = new System.Drawing.Point(3, 28);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInput.Size = new System.Drawing.Size(1123, 576);
            this.dgvInput.TabIndex = 2;
            this.dgvInput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellContentClick);
            this.dgvInput.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvInput_CurrentCellDirtyStateChanged);
            // 
            // capproval
            // 
            this.capproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capproval.HeaderText = "Approval";
            this.capproval.Items.AddRange(new object[] {
            "Please select",
            "Approve"});
            this.capproval.Name = "capproval";
            this.capproval.Width = 63;
            // 
            // cdownload
            // 
            this.cdownload.HeaderText = "DL";
            this.cdownload.Name = "cdownload";
            this.cdownload.ReadOnly = true;
            this.cdownload.Width = 45;
            // 
            // cassetclass
            // 
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
            this.ccreatedby.HeaderText = "Created by";
            this.ccreatedby.Name = "ccreatedby";
            this.ccreatedby.ReadOnly = true;
            this.ccreatedby.Width = 83;
            // 
            // cmould
            // 
            this.cmould.HeaderText = "Mould";
            this.cmould.Name = "cmould";
            this.cmould.ReadOnly = true;
            this.cmould.Width = 68;
            // 
            // cmgtno
            // 
            this.cmgtno.HeaderText = "管理No.";
            this.cmgtno.Name = "cmgtno";
            this.cmgtno.ReadOnly = true;
            this.cmgtno.Width = 69;
            // 
            // cdesc
            // 
            this.cdesc.HeaderText = "Description";
            this.cdesc.Name = "cdesc";
            this.cdesc.ReadOnly = true;
            this.cdesc.Width = 95;
            // 
            // cmpa
            // 
            this.cmpa.HeaderText = "MPA (50%)";
            this.cmpa.Name = "cmpa";
            this.cmpa.ReadOnly = true;
            this.cmpa.Width = 83;
            // 
            // ccostcenter
            // 
            this.ccostcenter.HeaderText = "Cost Center";
            this.ccostcenter.Name = "ccostcenter";
            this.ccostcenter.ReadOnly = true;
            this.ccostcenter.Width = 87;
            // 
            // crespcostcenter
            // 
            this.crespcostcenter.HeaderText = "Resp. Cost Center";
            this.crespcostcenter.Name = "crespcostcenter";
            this.crespcostcenter.ReadOnly = true;
            this.crespcostcenter.Width = 115;
            // 
            // clocation
            // 
            this.clocation.HeaderText = "Location";
            this.clocation.Name = "clocation";
            this.clocation.ReadOnly = true;
            this.clocation.Width = 78;
            // 
            // cringino
            // 
            this.cringino.HeaderText = "Ringi No.";
            this.cringino.Name = "cringino";
            this.cringino.ReadOnly = true;
            this.cringino.Width = 75;
            // 
            // cfile
            // 
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
            this.cadditional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cadditional.HeaderText = "Additional Asset Description";
            this.cadditional.Name = "cadditional";
            this.cadditional.ReadOnly = true;
            this.cadditional.Width = 170;
            // 
            // cpath
            // 
            this.cpath.HeaderText = "path";
            this.cpath.Name = "cpath";
            this.cpath.Visible = false;
            this.cpath.Width = 57;
            // 
            // cchaseno
            // 
            this.cchaseno.HeaderText = "chaseno";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.Visible = false;
            this.cchaseno.Width = 78;
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
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1129, 25);
            this.toolStrip1.TabIndex = 14;
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
            // FaAssetClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvInput);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaAssetClass";
            this.Size = new System.Drawing.Size(1129, 607);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnApprove;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn capproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdownload;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
    }
}
