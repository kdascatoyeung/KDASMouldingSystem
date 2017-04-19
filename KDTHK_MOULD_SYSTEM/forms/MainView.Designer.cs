namespace KDTHK_MOULD_SYSTEM.forms
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmouldcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camounthkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyMouldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fixedAssetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnCriteria = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.bdSearch.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cstatus,
            this.cchaseno,
            this.cvendor,
            this.cvendorname,
            this.cpgroup,
            this.cpartno,
            this.crev,
            this.cmould,
            this.cdiv,
            this.ctype,
            this.cmodel,
            this.cmouldcode,
            this.ccurrency,
            this.camounthkd,
            this.cmpa,
            this.cfa,
            this.cpo,
            this.cremarks});
            this.dgvMain.ContextMenuStrip = this.menuStrip;
            this.dgvMain.Location = new System.Drawing.Point(3, 32);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1147, 602);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMain_MouseDown);
            // 
            // cstatus
            // 
            this.cstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cstatus.DataPropertyName = "status";
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            this.cstatus.Width = 66;
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
            // cpgroup
            // 
            this.cpgroup.DataPropertyName = "pgroup";
            this.cpgroup.HeaderText = "PurG";
            this.cpgroup.Name = "cpgroup";
            this.cpgroup.ReadOnly = true;
            this.cpgroup.Width = 59;
            // 
            // cpartno
            // 
            this.cpartno.DataPropertyName = "partno";
            this.cpartno.HeaderText = "PartNo.";
            this.cpartno.Name = "cpartno";
            this.cpartno.ReadOnly = true;
            this.cpartno.Width = 73;
            // 
            // crev
            // 
            this.crev.DataPropertyName = "rev";
            this.crev.HeaderText = "Rev";
            this.crev.Name = "crev";
            this.crev.ReadOnly = true;
            this.crev.Width = 51;
            // 
            // cmould
            // 
            this.cmould.DataPropertyName = "mould";
            this.cmould.HeaderText = "Mould";
            this.cmould.Name = "cmould";
            this.cmould.ReadOnly = true;
            this.cmould.Width = 68;
            // 
            // cdiv
            // 
            this.cdiv.DataPropertyName = "div";
            this.cdiv.HeaderText = "Div";
            this.cdiv.Name = "cdiv";
            this.cdiv.ReadOnly = true;
            this.cdiv.Width = 50;
            // 
            // ctype
            // 
            this.ctype.DataPropertyName = "type";
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            this.ctype.Width = 56;
            // 
            // cmodel
            // 
            this.cmodel.DataPropertyName = "model";
            this.cmodel.HeaderText = "Model";
            this.cmodel.Name = "cmodel";
            this.cmodel.ReadOnly = true;
            this.cmodel.Width = 67;
            // 
            // cmouldcode
            // 
            this.cmouldcode.DataPropertyName = "mouldcode";
            this.cmouldcode.HeaderText = "MouldCode";
            this.cmouldcode.Name = "cmouldcode";
            this.cmouldcode.ReadOnly = true;
            this.cmouldcode.Width = 95;
            // 
            // ccurrency
            // 
            this.ccurrency.DataPropertyName = "currency";
            this.ccurrency.HeaderText = "Currency";
            this.ccurrency.Name = "ccurrency";
            this.ccurrency.ReadOnly = true;
            this.ccurrency.Width = 81;
            // 
            // camounthkd
            // 
            this.camounthkd.DataPropertyName = "hkd";
            this.camounthkd.HeaderText = "HKD";
            this.camounthkd.Name = "camounthkd";
            this.camounthkd.ReadOnly = true;
            this.camounthkd.Width = 55;
            // 
            // cmpa
            // 
            this.cmpa.DataPropertyName = "mpa";
            this.cmpa.HeaderText = "MPA";
            this.cmpa.Name = "cmpa";
            this.cmpa.ReadOnly = true;
            this.cmpa.Visible = false;
            this.cmpa.Width = 55;
            // 
            // cfa
            // 
            this.cfa.DataPropertyName = "fa";
            this.cfa.HeaderText = "FA";
            this.cfa.Name = "cfa";
            this.cfa.ReadOnly = true;
            this.cfa.Width = 44;
            // 
            // cpo
            // 
            this.cpo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cpo.DataPropertyName = "po";
            this.cpo.HeaderText = "PO";
            this.cpo.Name = "cpo";
            this.cpo.ReadOnly = true;
            this.cpo.Width = 48;
            // 
            // cremarks
            // 
            this.cremarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cremarks.DataPropertyName = "remarks";
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            this.cremarks.ReadOnly = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyMouldToolStripMenuItem,
            this.toolStripSeparator1,
            this.fixedAssetToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(153, 120);
            this.menuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.menuStrip_Opening);
            // 
            // modifyMouldToolStripMenuItem
            // 
            this.modifyMouldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifyMouldToolStripMenuItem.Image")));
            this.modifyMouldToolStripMenuItem.Name = "modifyMouldToolStripMenuItem";
            this.modifyMouldToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifyMouldToolStripMenuItem.Text = "Modify Mould";
            this.modifyMouldToolStripMenuItem.Click += new System.EventHandler(this.modifyMouldToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // fixedAssetToolStripMenuItem
            // 
            this.fixedAssetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fixedAssetToolStripMenuItem.Name = "fixedAssetToolStripMenuItem";
            this.fixedAssetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fixedAssetToolStripMenuItem.Text = "Fixed Asset";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transferToolStripMenuItem.Tag = "transfer";
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeToolStripMenuItem.Tag = "change";
            this.changeToolStripMenuItem.Text = "Change";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Tag = "cancel";
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.MenuItemClicked);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
            this.bdSearch.Location = new System.Drawing.Point(953, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 5;
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
            this.tsbtnCriteria,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(950, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnCriteria
            // 
            this.tsbtnCriteria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCriteria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCriteria.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnCriteria.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCriteria.Image")));
            this.tsbtnCriteria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCriteria.Name = "tsbtnCriteria";
            this.tsbtnCriteria.Size = new System.Drawing.Size(67, 22);
            this.tsbtnCriteria.Text = "Criteria";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 22);
            this.toolStripDropDownButton1.Text = "Download";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bdSearch);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1153, 637);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnCriteria;
        private System.Windows.Forms.ToolStripButton toolStripDropDownButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn camounthkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private System.Windows.Forms.ContextMenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem modifyMouldToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixedAssetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;

    }
}
