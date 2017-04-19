namespace KDTHK_MOULD_SYSTEM.forms.data
{
    partial class MasterMouldCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterMouldCode));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.dgvMouldCode = new System.Windows.Forms.DataGridView();
            this.cmouldcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citemgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTemplate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpload = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.bdSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMouldCode)).BeginInit();
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
            this.toolStripButton1,
            this.tsbtnNew,
            this.tsbtnTemplate,
            this.tsbtnUpload,
            this.tsbtnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
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
            this.bdSearch.Location = new System.Drawing.Point(1007, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 14;
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
            // dgvMouldCode
            // 
            this.dgvMouldCode.AllowUserToAddRows = false;
            this.dgvMouldCode.AllowUserToDeleteRows = false;
            this.dgvMouldCode.AllowUserToResizeRows = false;
            this.dgvMouldCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMouldCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMouldCode.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMouldCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMouldCode.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvMouldCode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMouldCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMouldCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmouldcode,
            this.ctype,
            this.cjp,
            this.ceng,
            this.cchin,
            this.citemgroup});
            this.dgvMouldCode.Location = new System.Drawing.Point(3, 26);
            this.dgvMouldCode.MultiSelect = false;
            this.dgvMouldCode.Name = "dgvMouldCode";
            this.dgvMouldCode.ReadOnly = true;
            this.dgvMouldCode.RowHeadersVisible = false;
            this.dgvMouldCode.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvMouldCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMouldCode.Size = new System.Drawing.Size(1201, 601);
            this.dgvMouldCode.TabIndex = 15;
            this.dgvMouldCode.DoubleClick += new System.EventHandler(this.dgvMouldCode_DoubleClick);
            // 
            // cmouldcode
            // 
            this.cmouldcode.DataPropertyName = "mouldcode";
            this.cmouldcode.HeaderText = "Mould Code";
            this.cmouldcode.Name = "cmouldcode";
            this.cmouldcode.ReadOnly = true;
            // 
            // ctype
            // 
            this.ctype.DataPropertyName = "type";
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            // 
            // cjp
            // 
            this.cjp.DataPropertyName = "contentjp";
            this.cjp.HeaderText = "Content (Jp)";
            this.cjp.Name = "cjp";
            this.cjp.ReadOnly = true;
            // 
            // ceng
            // 
            this.ceng.DataPropertyName = "contenteng";
            this.ceng.HeaderText = "Content (Eng)";
            this.ceng.Name = "ceng";
            this.ceng.ReadOnly = true;
            // 
            // cchin
            // 
            this.cchin.DataPropertyName = "contentchin";
            this.cchin.HeaderText = "Content (Chin)";
            this.cchin.Name = "cchin";
            this.cchin.ReadOnly = true;
            // 
            // citemgroup
            // 
            this.citemgroup.DataPropertyName = "itemgroup";
            this.citemgroup.HeaderText = "Item Group";
            this.citemgroup.Name = "citemgroup";
            this.citemgroup.ReadOnly = true;
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorToolStripMenuItem,
            this.oEMToolStripMenuItem});
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Switch";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vendorToolStripMenuItem.BackgroundImage")));
            this.vendorToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.vendorToolStripMenuItem.Text = "Vendor";
            this.vendorToolStripMenuItem.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // oEMToolStripMenuItem
            // 
            this.oEMToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oEMToolStripMenuItem.BackgroundImage")));
            this.oEMToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.oEMToolStripMenuItem.Name = "oEMToolStripMenuItem";
            this.oEMToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.oEMToolStripMenuItem.Text = "OEM";
            this.oEMToolStripMenuItem.Click += new System.EventHandler(this.oEMToolStripMenuItem_Click);
            // 
            // tsbtnNew
            // 
            this.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNew.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnNew.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNew.Image")));
            this.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNew.Name = "tsbtnNew";
            this.tsbtnNew.Size = new System.Drawing.Size(41, 22);
            this.tsbtnNew.Text = "New";
            this.tsbtnNew.Click += new System.EventHandler(this.tsbtnNew_Click);
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
            // MasterMouldCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvMouldCode);
            this.Controls.Add(this.bdSearch);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MasterMouldCode";
            this.Size = new System.Drawing.Size(1207, 630);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMouldCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
        private System.Windows.Forms.ToolStripButton tsbtnTemplate;
        private System.Windows.Forms.ToolStripButton tsbtnUpload;
        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.DataGridView dgvMouldCode;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oEMToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceng;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchin;
        private System.Windows.Forms.DataGridViewTextBoxColumn citemgroup;
        private System.Windows.Forms.ToolStripButton tsbtnNew;
    }
}
