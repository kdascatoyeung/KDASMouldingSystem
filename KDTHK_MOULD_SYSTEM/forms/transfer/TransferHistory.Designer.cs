namespace KDTHK_MOULD_SYSTEM.forms.transfer
{
    partial class TransferHistory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferHistory));
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.ctmno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmouldno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel5 = new CustomUtil.controls.panel.CustomPanel();
            this.btnSearchItem = new System.Windows.Forms.Button();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnDownload = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.customPanel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctmno,
            this.cmouldno,
            this.cpartno,
            this.crev,
            this.cvendor,
            this.cto,
            this.cdate,
            this.cremarks});
            this.dgvHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvHistory.Location = new System.Drawing.Point(3, 29);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHistory.Size = new System.Drawing.Size(815, 571);
            this.dgvHistory.TabIndex = 3;
            // 
            // ctmno
            // 
            this.ctmno.DataPropertyName = "tmno";
            this.ctmno.HeaderText = "TM No.";
            this.ctmno.Name = "ctmno";
            // 
            // cmouldno
            // 
            this.cmouldno.DataPropertyName = "mould";
            this.cmouldno.HeaderText = "Mould";
            this.cmouldno.Name = "cmouldno";
            this.cmouldno.ReadOnly = true;
            // 
            // cpartno
            // 
            this.cpartno.DataPropertyName = "partno";
            this.cpartno.HeaderText = "Part No.";
            this.cpartno.Name = "cpartno";
            this.cpartno.ReadOnly = true;
            // 
            // crev
            // 
            this.crev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.crev.DataPropertyName = "rev";
            this.crev.HeaderText = "Rev";
            this.crev.Name = "crev";
            this.crev.ReadOnly = true;
            this.crev.Width = 51;
            // 
            // cvendor
            // 
            this.cvendor.DataPropertyName = "fromv";
            this.cvendor.HeaderText = "From";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            // 
            // cto
            // 
            this.cto.DataPropertyName = "tov";
            this.cto.HeaderText = "To";
            this.cto.Name = "cto";
            this.cto.ReadOnly = true;
            // 
            // cdate
            // 
            this.cdate.DataPropertyName = "dt";
            this.cdate.HeaderText = "Date";
            this.cdate.Name = "cdate";
            // 
            // cremarks
            // 
            this.cremarks.DataPropertyName = "remarks";
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
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
            this.customPanel5.Location = new System.Drawing.Point(621, 4);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(197, 22);
            this.customPanel5.TabIndex = 7;
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
            this.tsbtnDownload});
            this.toolStrip1.Location = new System.Drawing.Point(3, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(615, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
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
            // TransferHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(822, 603);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.customPanel5);
            this.Controls.Add(this.dgvHistory);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransferHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History - Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctmno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private CustomUtil.controls.panel.CustomPanel customPanel5;
        private System.Windows.Forms.Button btnSearchItem;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnDownload;
    }
}