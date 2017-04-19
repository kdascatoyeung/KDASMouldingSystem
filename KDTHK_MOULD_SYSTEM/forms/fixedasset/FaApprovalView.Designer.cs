namespace KDTHK_MOULD_SYSTEM.forms.fixedasset
{
    partial class FaApprovalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaApprovalView));
            this.dgvApproval = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnApproveAll = new System.Windows.Forms.ToolStripButton();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camounthkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cattach = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cattpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.creject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvApproval
            // 
            this.dgvApproval.AllowUserToAddRows = false;
            this.dgvApproval.AllowUserToDeleteRows = false;
            this.dgvApproval.AllowUserToResizeRows = false;
            this.dgvApproval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApproval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApproval.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvApproval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvApproval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvApproval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvApproval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApproval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctype,
            this.cstatus,
            this.cchaseno,
            this.cvendor,
            this.cvendorname,
            this.cmould,
            this.cpartno,
            this.crev,
            this.cmodel,
            this.ccurrency,
            this.camounthkd,
            this.cattach,
            this.cattpath,
            this.capp,
            this.creject});
            this.dgvApproval.Location = new System.Drawing.Point(3, 28);
            this.dgvApproval.Name = "dgvApproval";
            this.dgvApproval.ReadOnly = true;
            this.dgvApproval.RowHeadersVisible = false;
            this.dgvApproval.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvApproval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApproval.Size = new System.Drawing.Size(1154, 610);
            this.dgvApproval.TabIndex = 1;
            this.dgvApproval.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApproval_CellContentClick);
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
            this.tsbtnApproveAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1160, 25);
            this.toolStrip1.TabIndex = 11;
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
            // tsbtnApproveAll
            // 
            this.tsbtnApproveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnApproveAll.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnApproveAll.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnApproveAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnApproveAll.Image")));
            this.tsbtnApproveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnApproveAll.Name = "tsbtnApproveAll";
            this.tsbtnApproveAll.Size = new System.Drawing.Size(85, 22);
            this.tsbtnApproveAll.Text = "Approve All";
            this.tsbtnApproveAll.Click += new System.EventHandler(this.tsbtnApproveAll_Click);
            // 
            // ctype
            // 
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "status";
            this.cstatus.HeaderText = "status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Visible = false;
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
            this.cvendorname.DataPropertyName = "vendorname";
            this.cvendorname.HeaderText = "VendorName";
            this.cvendorname.Name = "cvendorname";
            this.cvendorname.ReadOnly = true;
            this.cvendorname.Width = 101;
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
            // cmodel
            // 
            this.cmodel.DataPropertyName = "model";
            this.cmodel.HeaderText = "Model";
            this.cmodel.Name = "cmodel";
            this.cmodel.ReadOnly = true;
            // 
            // ccurrency
            // 
            this.ccurrency.DataPropertyName = "currency";
            this.ccurrency.HeaderText = "Currency";
            this.ccurrency.Name = "ccurrency";
            this.ccurrency.ReadOnly = true;
            this.ccurrency.Visible = false;
            // 
            // camounthkd
            // 
            this.camounthkd.DataPropertyName = "hkd";
            this.camounthkd.HeaderText = "HKD";
            this.camounthkd.Name = "camounthkd";
            this.camounthkd.ReadOnly = true;
            this.camounthkd.Visible = false;
            // 
            // cattach
            // 
            this.cattach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cattach.HeaderText = "Attachment";
            this.cattach.LinkColor = System.Drawing.Color.Blue;
            this.cattach.Name = "cattach";
            this.cattach.ReadOnly = true;
            this.cattach.Text = "";
            this.cattach.Width = 75;
            // 
            // cattpath
            // 
            this.cattpath.HeaderText = "path";
            this.cattpath.Name = "cattpath";
            this.cattpath.ReadOnly = true;
            this.cattpath.Visible = false;
            // 
            // capp
            // 
            this.capp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.capp.FillWeight = 50F;
            this.capp.HeaderText = "Approve";
            this.capp.Name = "capp";
            this.capp.ReadOnly = true;
            this.capp.Text = "Approve";
            this.capp.UseColumnTextForButtonValue = true;
            this.capp.Width = 58;
            // 
            // creject
            // 
            this.creject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.creject.HeaderText = "Reject";
            this.creject.Name = "creject";
            this.creject.ReadOnly = true;
            this.creject.Text = "Reject";
            this.creject.UseColumnTextForButtonValue = true;
            this.creject.Width = 46;
            // 
            // FaApprovalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvApproval);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaApprovalView";
            this.Size = new System.Drawing.Size(1160, 641);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApproval)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApproval;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnApproveAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn camounthkd;
        private System.Windows.Forms.DataGridViewLinkColumn cattach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cattpath;
        private System.Windows.Forms.DataGridViewButtonColumn capp;
        private System.Windows.Forms.DataGridViewButtonColumn creject;
    }
}
