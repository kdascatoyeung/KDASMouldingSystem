namespace KDTHK_MOULD_SYSTEM.forms.fixedasset
{
    partial class FaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaView));
            this.bdSearch = new CustomUtil.controls.panel.CustomPanel();
            this.txtSearch = new CustomUtil.controls.textbox.WatermarkTextbox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvFa = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmould = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citemtext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFa)).BeginInit();
            this.SuspendLayout();
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
            this.bdSearch.Location = new System.Drawing.Point(977, 3);
            this.bdSearch.Name = "bdSearch";
            this.bdSearch.Size = new System.Drawing.Size(197, 22);
            this.bdSearch.TabIndex = 15;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvFa
            // 
            this.dgvFa.AllowUserToAddRows = false;
            this.dgvFa.AllowUserToDeleteRows = false;
            this.dgvFa.AllowUserToResizeRows = false;
            this.dgvFa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvFa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctype,
            this.cstatus,
            this.cchaseno,
            this.cmould,
            this.cpartno,
            this.citemtext,
            this.clink,
            this.cref});
            this.dgvFa.Location = new System.Drawing.Point(3, 26);
            this.dgvFa.MultiSelect = false;
            this.dgvFa.Name = "dgvFa";
            this.dgvFa.ReadOnly = true;
            this.dgvFa.RowHeadersVisible = false;
            this.dgvFa.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvFa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFa.Size = new System.Drawing.Size(1171, 607);
            this.dgvFa.TabIndex = 21;
            this.dgvFa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFa_CellContentClick);
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
            // ctype
            // 
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            // 
            // cstatus
            // 
            this.cstatus.HeaderText = "Status";
            this.cstatus.Name = "cstatus";
            this.cstatus.ReadOnly = true;
            // 
            // cchaseno
            // 
            this.cchaseno.HeaderText = "Chase No.";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            // 
            // cmould
            // 
            this.cmould.HeaderText = "Mould No.";
            this.cmould.Name = "cmould";
            this.cmould.ReadOnly = true;
            // 
            // cpartno
            // 
            this.cpartno.HeaderText = "Part No.";
            this.cpartno.Name = "cpartno";
            this.cpartno.ReadOnly = true;
            // 
            // citemtext
            // 
            this.citemtext.HeaderText = "Item Text";
            this.citemtext.Name = "citemtext";
            this.citemtext.ReadOnly = true;
            // 
            // clink
            // 
            this.clink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clink.HeaderText = "Attachment";
            this.clink.Name = "clink";
            this.clink.ReadOnly = true;
            this.clink.Width = 75;
            // 
            // cref
            // 
            this.cref.HeaderText = "ref";
            this.cref.Name = "cref";
            this.cref.ReadOnly = true;
            this.cref.Visible = false;
            // 
            // FaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvFa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bdSearch);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaView";
            this.Size = new System.Drawing.Size(1177, 636);
            this.bdSearch.ResumeLayout(false);
            this.bdSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel bdSearch;
        private System.Windows.Forms.Button btnSearch;
        private CustomUtil.controls.textbox.WatermarkTextbox txtSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvFa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmould;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn citemtext;
        private System.Windows.Forms.DataGridViewLinkColumn clink;
        private System.Windows.Forms.DataGridViewTextBoxColumn cref;
    }
}
