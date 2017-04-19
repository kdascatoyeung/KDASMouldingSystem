namespace KDTHK_MOULD_SYSTEM.ipo.views
{
    partial class MouldView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouldView));
            this.pnlMain = new CustomUtil.controls.panel.CustomPanel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.msMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnCriteria = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnDownload = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.ccurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camounthkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfatmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cringi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citemtext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprojecttext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmouldcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cissued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caccountcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccostcenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinstock50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cequipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cshot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinstockremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccreatedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.bdSearch.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.BorderWidth = 1;
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Controls.Add(this.toolStrip1);
            this.pnlMain.Controls.Add(this.bdSearch);
            this.pnlMain.Curvature = 3;
            this.pnlMain.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1180, 644);
            this.pnlMain.TabIndex = 5;
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
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.ccurrency,
            this.camount,
            this.camounthkd,
            this.cmpa,
            this.cfa,
            this.cfatmp,
            this.cringi,
            this.citemtext,
            this.cprojecttext,
            this.cmodel,
            this.cmouldcode,
            this.cpo,
            this.cissued,
            this.ccategory,
            this.cpcs,
            this.cmodify,
            this.cremarks,
            this.coem,
            this.caccountcode,
            this.ccostcenter,
            this.cinstock50,
            this.cinstock,
            this.ccheckdate,
            this.ccav,
            this.cweight,
            this.cequipment,
            this.cshot,
            this.clength,
            this.cwidth,
            this.cheight,
            this.cinstockremarks,
            this.ccreated,
            this.ccreatedby});
            this.dgvMain.ContextMenuStrip = this.msMain;
            this.dgvMain.Location = new System.Drawing.Point(3, 28);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1174, 613);
            this.dgvMain.TabIndex = 14;
            this.dgvMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMain_MouseDown);
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
            this.btnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(974, 24);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
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
            this.bdSearch.Location = new System.Drawing.Point(980, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 6;
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
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.msMain.Name = "contextMenuStrip1";
            this.msMain.Size = new System.Drawing.Size(153, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // tsbtnCriteria
            // 
            this.tsbtnCriteria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCriteria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCriteria.ForeColor = System.Drawing.Color.Black;
            this.tsbtnCriteria.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCriteria.Image")));
            this.tsbtnCriteria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCriteria.Name = "tsbtnCriteria";
            this.tsbtnCriteria.Size = new System.Drawing.Size(67, 21);
            this.tsbtnCriteria.Text = "Criteria";
            // 
            // btnDownload
            // 
            this.btnDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDownload.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Black;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 21);
            this.btnDownload.Text = "Download";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(177, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(16, 16);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cstatus
            // 
            this.cstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cstatus.DataPropertyName = "st";
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
            this.cmould.DataPropertyName = "mouldno";
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
            // ccurrency
            // 
            this.ccurrency.DataPropertyName = "currency";
            this.ccurrency.HeaderText = "Currency";
            this.ccurrency.Name = "ccurrency";
            this.ccurrency.ReadOnly = true;
            this.ccurrency.Width = 81;
            // 
            // camount
            // 
            this.camount.DataPropertyName = "amount";
            this.camount.HeaderText = "Amount";
            this.camount.Name = "camount";
            this.camount.ReadOnly = true;
            this.camount.Width = 74;
            // 
            // camounthkd
            // 
            this.camounthkd.DataPropertyName = "amounthkd";
            this.camounthkd.HeaderText = "Amount (HKD)";
            this.camounthkd.Name = "camounthkd";
            this.camounthkd.ReadOnly = true;
            this.camounthkd.Width = 108;
            // 
            // cmpa
            // 
            this.cmpa.DataPropertyName = "mpa";
            this.cmpa.HeaderText = "MPA";
            this.cmpa.Name = "cmpa";
            this.cmpa.ReadOnly = true;
            this.cmpa.Visible = false;
            this.cmpa.Width = 56;
            // 
            // cfa
            // 
            this.cfa.DataPropertyName = "fa";
            this.cfa.HeaderText = "Fixed Asset";
            this.cfa.Name = "cfa";
            this.cfa.ReadOnly = true;
            this.cfa.Width = 93;
            // 
            // cfatmp
            // 
            this.cfatmp.DataPropertyName = "fatmp";
            this.cfatmp.HeaderText = "Fixed Asset Tmp";
            this.cfatmp.Name = "cfatmp";
            this.cfatmp.ReadOnly = true;
            this.cfatmp.Width = 88;
            // 
            // cringi
            // 
            this.cringi.DataPropertyName = "ringi";
            this.cringi.HeaderText = "Ringi";
            this.cringi.Name = "cringi";
            this.cringi.ReadOnly = true;
            this.cringi.Width = 60;
            // 
            // citemtext
            // 
            this.citemtext.DataPropertyName = "itemtext";
            this.citemtext.HeaderText = "Item Text";
            this.citemtext.Name = "citemtext";
            this.citemtext.ReadOnly = true;
            this.citemtext.Width = 74;
            // 
            // cprojecttext
            // 
            this.cprojecttext.DataPropertyName = "projecttext";
            this.cprojecttext.HeaderText = "Project Text";
            this.cprojecttext.Name = "cprojecttext";
            this.cprojecttext.ReadOnly = true;
            this.cprojecttext.Width = 87;
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
            // cpo
            // 
            this.cpo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cpo.DataPropertyName = "po";
            this.cpo.HeaderText = "PO";
            this.cpo.Name = "cpo";
            this.cpo.ReadOnly = true;
            this.cpo.Width = 48;
            // 
            // cissued
            // 
            this.cissued.DataPropertyName = "issued";
            this.cissued.HeaderText = "Issued";
            this.cissued.Name = "cissued";
            this.cissued.ReadOnly = true;
            this.cissued.Width = 68;
            // 
            // ccategory
            // 
            this.ccategory.DataPropertyName = "category";
            this.ccategory.HeaderText = "Category";
            this.ccategory.Name = "ccategory";
            this.ccategory.ReadOnly = true;
            this.ccategory.Width = 80;
            // 
            // cpcs
            // 
            this.cpcs.DataPropertyName = "pcs";
            this.cpcs.HeaderText = "Pcs";
            this.cpcs.Name = "cpcs";
            this.cpcs.ReadOnly = true;
            this.cpcs.Width = 51;
            // 
            // cmodify
            // 
            this.cmodify.DataPropertyName = "modify";
            this.cmodify.HeaderText = "Modify";
            this.cmodify.Name = "cmodify";
            this.cmodify.ReadOnly = true;
            this.cmodify.Width = 71;
            // 
            // cremarks
            // 
            this.cremarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cremarks.DataPropertyName = "remarks";
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            this.cremarks.ReadOnly = true;
            // 
            // coem
            // 
            this.coem.DataPropertyName = "oem";
            this.coem.HeaderText = "OEM";
            this.coem.Name = "coem";
            this.coem.ReadOnly = true;
            this.coem.Width = 58;
            // 
            // caccountcode
            // 
            this.caccountcode.DataPropertyName = "accountcode";
            this.caccountcode.HeaderText = "Account Code";
            this.caccountcode.Name = "caccountcode";
            this.caccountcode.ReadOnly = true;
            this.caccountcode.Width = 97;
            // 
            // ccostcenter
            // 
            this.ccostcenter.DataPropertyName = "costcenter";
            this.ccostcenter.HeaderText = "Cost Center";
            this.ccostcenter.Name = "ccostcenter";
            this.ccostcenter.ReadOnly = true;
            this.ccostcenter.Width = 87;
            // 
            // cinstock50
            // 
            this.cinstock50.DataPropertyName = "instock50";
            this.cinstock50.HeaderText = "In Stock 50%";
            this.cinstock50.Name = "cinstock50";
            this.cinstock50.ReadOnly = true;
            this.cinstock50.Width = 93;
            // 
            // cinstock
            // 
            this.cinstock.DataPropertyName = "instock";
            this.cinstock.HeaderText = "In Stock";
            this.cinstock.Name = "cinstock";
            this.cinstock.ReadOnly = true;
            this.cinstock.Width = 69;
            // 
            // ccheckdate
            // 
            this.ccheckdate.DataPropertyName = "checkdate";
            this.ccheckdate.HeaderText = "Check Date";
            this.ccheckdate.Name = "ccheckdate";
            this.ccheckdate.ReadOnly = true;
            this.ccheckdate.Width = 85;
            // 
            // ccav
            // 
            this.ccav.DataPropertyName = "cav";
            this.ccav.HeaderText = "Cav";
            this.ccav.Name = "ccav";
            this.ccav.ReadOnly = true;
            this.ccav.Width = 52;
            // 
            // cweight
            // 
            this.cweight.DataPropertyName = "weight";
            this.cweight.HeaderText = "Weight";
            this.cweight.Name = "cweight";
            this.cweight.ReadOnly = true;
            this.cweight.Width = 71;
            // 
            // cequipment
            // 
            this.cequipment.DataPropertyName = "accessory";
            this.cequipment.HeaderText = "Accessory";
            this.cequipment.Name = "cequipment";
            this.cequipment.ReadOnly = true;
            this.cequipment.Width = 87;
            // 
            // cshot
            // 
            this.cshot.DataPropertyName = "shot";
            this.cshot.HeaderText = "Shot";
            this.cshot.Name = "cshot";
            this.cshot.ReadOnly = true;
            this.cshot.Width = 56;
            // 
            // clength
            // 
            this.clength.DataPropertyName = "vertical";
            this.clength.HeaderText = "Length";
            this.clength.Name = "clength";
            this.clength.ReadOnly = true;
            this.clength.Width = 67;
            // 
            // cwidth
            // 
            this.cwidth.DataPropertyName = "horizontal";
            this.cwidth.HeaderText = "Width";
            this.cwidth.Name = "cwidth";
            this.cwidth.ReadOnly = true;
            this.cwidth.Width = 66;
            // 
            // cheight
            // 
            this.cheight.DataPropertyName = "height";
            this.cheight.HeaderText = "Height";
            this.cheight.Name = "cheight";
            this.cheight.ReadOnly = true;
            this.cheight.Width = 67;
            // 
            // cinstockremarks
            // 
            this.cinstockremarks.DataPropertyName = "instockremarks";
            this.cinstockremarks.HeaderText = "In Stock Remarks";
            this.cinstockremarks.Name = "cinstockremarks";
            this.cinstockremarks.ReadOnly = true;
            this.cinstockremarks.Width = 114;
            // 
            // ccreated
            // 
            this.ccreated.DataPropertyName = "created";
            this.ccreated.HeaderText = "Created";
            this.ccreated.Name = "ccreated";
            this.ccreated.ReadOnly = true;
            this.ccreated.Width = 74;
            // 
            // ccreatedby
            // 
            this.ccreatedby.DataPropertyName = "createdby";
            this.ccreatedby.HeaderText = "Created By";
            this.ccreatedby.Name = "ccreatedby";
            this.ccreatedby.ReadOnly = true;
            this.ccreatedby.Width = 83;
            // 
            // MouldView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MouldView";
            this.Size = new System.Drawing.Size(1180, 644);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel pnlMain;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnCriteria;
        private System.Windows.Forms.ToolStripButton btnDownload;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ContextMenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ccurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn camount;
        private System.Windows.Forms.DataGridViewTextBoxColumn camounthkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfatmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cringi;
        private System.Windows.Forms.DataGridViewTextBoxColumn citemtext;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprojecttext;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cissued;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodify;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn coem;
        private System.Windows.Forms.DataGridViewTextBoxColumn caccountcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccostcenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinstock50;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccav;
        private System.Windows.Forms.DataGridViewTextBoxColumn cweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cequipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cshot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clength;
        private System.Windows.Forms.DataGridViewTextBoxColumn cwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinstockremarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccreatedby;
    }
}
