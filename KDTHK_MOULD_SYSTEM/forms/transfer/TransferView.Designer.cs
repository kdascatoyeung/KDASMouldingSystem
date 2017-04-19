namespace KDTHK_MOULD_SYSTEM.forms.transfer
{
    partial class TransferView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferView));
            this.customPanel1 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel5 = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel3 = new CustomUtil.controls.panel.CustomPanel();
            this.txtVendorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel4 = new CustomUtil.controls.panel.CustomPanel();
            this.cbPgroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel2 = new CustomUtil.controls.panel.CustomPanel();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            this.cdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmouldno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new CustomUtil.controls.button.CustomButton();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.customPanel5.SuspendLayout();
            this.bdSearch.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel1.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.customPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel1.BorderWidth = 1;
            this.customPanel1.Controls.Add(this.dgvSearch);
            this.customPanel1.Controls.Add(this.customPanel5);
            this.customPanel1.Curvature = 4;
            this.customPanel1.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel1.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel1.Location = new System.Drawing.Point(3, 164);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(389, 472);
            this.customPanel1.TabIndex = 0;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.cname,
            this.cchaseno});
            this.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSearch.Location = new System.Drawing.Point(3, 28);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(383, 441);
            this.dgvSearch.TabIndex = 7;
            this.dgvSearch.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSearch_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mould";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mould";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partno";
            this.dataGridViewTextBoxColumn2.HeaderText = "Part No.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "rev";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rev";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 51;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vendor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vendor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "name";
            this.cname.HeaderText = "name";
            this.cname.Name = "cname";
            this.cname.ReadOnly = true;
            this.cname.Visible = false;
            // 
            // cchaseno
            // 
            this.cchaseno.DataPropertyName = "chaseno";
            this.cchaseno.HeaderText = "chaseno";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            this.cchaseno.Visible = false;
            // 
            // customPanel5
            // 
            this.customPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel5.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel5.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel5.BorderColor = System.Drawing.Color.Silver;
            this.customPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel5.BorderWidth = 1;
            this.customPanel5.Controls.Add(this.btnSearchItem);
            this.customPanel5.Controls.Add(this.txtSearch);
            this.customPanel5.Curvature = 2;
            this.customPanel5.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel5.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel5.Location = new System.Drawing.Point(189, 3);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(197, 22);
            this.customPanel5.TabIndex = 6;
            // 
            // btnSearchItem
            // 
            this.btnSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchItem.BackgroundImage")));
            this.btnSearchItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchItem.FlatAppearance.BorderSize = 0;
            this.btnSearchItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSearchItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSearchItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItem.Location = new System.Drawing.Point(177, 3);
            this.btnSearchItem.Name = "btnSearchItem";
            this.btnSearchItem.Size = new System.Drawing.Size(16, 16);
            this.btnSearchItem.TabIndex = 13;
            this.btnSearchItem.UseVisualStyleBackColor = true;
            this.btnSearchItem.Click += new System.EventHandler(this.btnSearchItem_Click);
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
            // bdSearch
            // 
            this.bdSearch.BackColor = System.Drawing.SystemColors.Window;
            this.bdSearch.BackColor2 = System.Drawing.SystemColors.Window;
            this.bdSearch.BorderColor = System.Drawing.Color.Silver;
            this.bdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bdSearch.BorderWidth = 1;
            this.bdSearch.Controls.Add(this.txtVendor);
            this.bdSearch.Controls.Add(this.btnSearch);
            this.bdSearch.Curvature = 2;
            this.bdSearch.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.bdSearch.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.bdSearch.Location = new System.Drawing.Point(96, 28);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 12;
            // 
            // txtVendor
            // 
            this.txtVendor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVendor.Location = new System.Drawing.Point(3, 3);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(167, 16);
            this.txtVendor.TabIndex = 7;
            this.txtVendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyDown);
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
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vendor";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel3.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel3.BorderColor = System.Drawing.Color.Silver;
            this.customPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel3.BorderWidth = 1;
            this.customPanel3.Controls.Add(this.txtVendorname);
            this.customPanel3.Curvature = 2;
            this.customPanel3.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel3.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel3.Location = new System.Drawing.Point(96, 56);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(197, 22);
            this.customPanel3.TabIndex = 14;
            // 
            // txtVendorname
            // 
            this.txtVendorname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVendorname.Location = new System.Drawing.Point(3, 3);
            this.txtVendorname.Name = "txtVendorname";
            this.txtVendorname.Size = new System.Drawing.Size(190, 16);
            this.txtVendorname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vendor Name";
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel4.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel4.BorderColor = System.Drawing.Color.Silver;
            this.customPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel4.BorderWidth = 1;
            this.customPanel4.Controls.Add(this.cbPgroup);
            this.customPanel4.Curvature = 2;
            this.customPanel4.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel4.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel4.Location = new System.Drawing.Point(96, 84);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(197, 24);
            this.customPanel4.TabIndex = 16;
            // 
            // cbPgroup
            // 
            this.cbPgroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPgroup.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPgroup.FormattingEnabled = true;
            this.cbPgroup.Location = new System.Drawing.Point(3, 1);
            this.cbPgroup.Name = "cbPgroup";
            this.cbPgroup.Size = new System.Drawing.Size(193, 22);
            this.cbPgroup.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pur. Group";
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.customPanel2.BackColor2 = System.Drawing.SystemColors.Window;
            this.customPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.customPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customPanel2.BorderWidth = 1;
            this.customPanel2.Controls.Add(this.dgvPreview);
            this.customPanel2.Curvature = 4;
            this.customPanel2.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.customPanel2.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.customPanel2.Location = new System.Drawing.Point(494, 37);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(683, 599);
            this.customPanel2.TabIndex = 1;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AllowUserToDeleteRows = false;
            this.dgvPreview.AllowUserToResizeRows = false;
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPreview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvPreview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdel,
            this.cmouldno,
            this.cpartno,
            this.crev,
            this.cvendor,
            this.cto,
            this.cmodel,
            this.camount,
            this.cremarks,
            this.cpcs,
            this.cpchaseno});
            this.dgvPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPreview.Location = new System.Drawing.Point(3, 3);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.RowHeadersVisible = false;
            this.dgvPreview.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPreview.Size = new System.Drawing.Size(677, 593);
            this.dgvPreview.TabIndex = 2;
            this.dgvPreview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreview_CellContentClick);
            // 
            // cdel
            // 
            this.cdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cdel.HeaderText = "";
            this.cdel.Name = "cdel";
            this.cdel.Width = 5;
            // 
            // cmouldno
            // 
            this.cmouldno.HeaderText = "Mould";
            this.cmouldno.Name = "cmouldno";
            this.cmouldno.ReadOnly = true;
            // 
            // cpartno
            // 
            this.cpartno.HeaderText = "Part No.";
            this.cpartno.Name = "cpartno";
            this.cpartno.ReadOnly = true;
            // 
            // crev
            // 
            this.crev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.crev.HeaderText = "Rev";
            this.crev.Name = "crev";
            this.crev.ReadOnly = true;
            this.crev.Width = 51;
            // 
            // cvendor
            // 
            this.cvendor.HeaderText = "From";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            // 
            // cto
            // 
            this.cto.HeaderText = "To";
            this.cto.Name = "cto";
            this.cto.ReadOnly = true;
            // 
            // cmodel
            // 
            this.cmodel.HeaderText = "Model";
            this.cmodel.Name = "cmodel";
            this.cmodel.ReadOnly = true;
            // 
            // camount
            // 
            this.camount.HeaderText = "Amount";
            this.camount.Name = "camount";
            this.camount.ReadOnly = true;
            // 
            // cremarks
            // 
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            // 
            // cpcs
            // 
            this.cpcs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cpcs.HeaderText = "Pcs";
            this.cpcs.Name = "cpcs";
            this.cpcs.ReadOnly = true;
            this.cpcs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cpcs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cpcs.Visible = false;
            // 
            // cpchaseno
            // 
            this.cpchaseno.HeaderText = "chaseno";
            this.cpchaseno.Name = "cpchaseno";
            this.cpchaseno.ReadOnly = true;
            this.cpchaseno.Visible = false;
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
            this.tsbtnUpload,
            this.tsbtnHistory,
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1180, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnTemplate
            // 
            this.tsbtnTemplate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnTemplate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnTemplate.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnTemplate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTemplate.Image")));
            this.tsbtnTemplate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTemplate.Name = "tsbtnTemplate";
            this.tsbtnTemplate.Size = new System.Drawing.Size(70, 22);
            this.tsbtnTemplate.Text = "Template";
            this.tsbtnTemplate.Click += new System.EventHandler(this.tsbtnTemplate_Click);
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
            // tsbtnHistory
            // 
            this.tsbtnHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnHistory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnHistory.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHistory.Image")));
            this.tsbtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHistory.Name = "tsbtnHistory";
            this.tsbtnHistory.Size = new System.Drawing.Size(56, 22);
            this.tsbtnHistory.Text = "History";
            this.tsbtnHistory.Click += new System.EventHandler(this.tsbtnHistory_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bdSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.customPanel3);
            this.groupBox1.Controls.Add(this.customPanel4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 130);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Info";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.LightGray;
            this.btnPreview.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.Black;
            this.btnPreview.GlowColor = System.Drawing.Color.DodgerBlue;
            this.btnPreview.InnerBorderColor = System.Drawing.Color.SteelBlue;
            this.btnPreview.Location = new System.Drawing.Point(398, 263);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ShineColor = System.Drawing.Color.AliceBlue;
            this.btnPreview.Size = new System.Drawing.Size(90, 76);
            this.btnPreview.TabIndex = 31;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // TransferView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TransferView";
            this.Size = new System.Drawing.Size(1180, 639);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel customPanel1;
        private CustomUtil.controls.panel.CustomPanel customPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnTemplate;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private CustomUtil.controls.panel.CustomPanel customPanel3;
        private System.Windows.Forms.TextBox txtVendorname;
        private System.Windows.Forms.Label label2;
        private CustomUtil.controls.panel.CustomPanel customPanel4;
        private System.Windows.Forms.ComboBox cbPgroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton tsbtnHistory;
        private CustomUtil.controls.button.CustomButton btnPreview;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.DataGridView dgvSearch;
        private CustomUtil.controls.panel.CustomPanel customPanel5;
        private System.Windows.Forms.Button btnSearchItem;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewImageColumn cdel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn camount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpchaseno;
    }
}
