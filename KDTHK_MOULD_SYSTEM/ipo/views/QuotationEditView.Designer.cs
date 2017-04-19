namespace KDTHK_MOULD_SYSTEM.ipo.views
{
    partial class QuotationEditView
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
            this.pnlMain = new CustomUtil.controls.panel.CustomPanel();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.cchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmouldno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdiv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmouldcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmodify = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cpcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caccountcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccostcenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlMain.BorderColor = System.Drawing.Color.Silver;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.BorderWidth = 1;
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.dgvInput);
            this.pnlMain.Curvature = 3;
            this.pnlMain.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1212, 641);
            this.pnlMain.TabIndex = 57;
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
            this.dgvInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvInput.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cchaseno,
            this.cstatus,
            this.cmouldno,
            this.cpartno,
            this.crev,
            this.cvendor,
            this.cGroup,
            this.cmodel,
            this.cdiv,
            this.cmouldcode,
            this.camount,
            this.cremarks,
            this.cmodify,
            this.cpcs,
            this.coem,
            this.cbase,
            this.caccountcode,
            this.ccostcenter});
            this.dgvInput.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInput.Location = new System.Drawing.Point(3, 3);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.RowHeadersVisible = false;
            this.dgvInput.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvInput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInput.Size = new System.Drawing.Size(1206, 603);
            this.dgvInput.TabIndex = 99;
            // 
            // cchaseno
            // 
            this.cchaseno.HeaderText = "Chase No.";
            this.cchaseno.Name = "cchaseno";
            this.cchaseno.ReadOnly = true;
            this.cchaseno.Width = 86;
            // 
            // cstatus
            // 
            this.cstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Items.AddRange(new object[] {
            "---",
            "初始狀態"});
            this.cstatus.Name = "cstatus";
            this.cstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cstatus.Width = 66;
            // 
            // cmouldno
            // 
            this.cmouldno.HeaderText = "Mould";
            this.cmouldno.Name = "cmouldno";
            this.cmouldno.Width = 68;
            // 
            // cpartno
            // 
            this.cpartno.HeaderText = "Part No.";
            this.cpartno.Name = "cpartno";
            this.cpartno.Width = 76;
            // 
            // crev
            // 
            this.crev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.crev.HeaderText = "Rev";
            this.crev.Name = "crev";
            this.crev.Width = 51;
            // 
            // cvendor
            // 
            this.cvendor.HeaderText = "Vendor";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            this.cvendor.Width = 70;
            // 
            // cGroup
            // 
            this.cGroup.HeaderText = "PurG.";
            this.cGroup.Name = "cGroup";
            this.cGroup.Width = 62;
            // 
            // cmodel
            // 
            this.cmodel.HeaderText = "Model";
            this.cmodel.Name = "cmodel";
            this.cmodel.Width = 67;
            // 
            // cdiv
            // 
            this.cdiv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cdiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdiv.HeaderText = "Div.";
            this.cdiv.Items.AddRange(new object[] {
            "New",
            "Modify",
            "TM"});
            this.cdiv.Name = "cdiv";
            this.cdiv.Width = 33;
            // 
            // cmouldcode
            // 
            this.cmouldcode.HeaderText = "Mould Code";
            this.cmouldcode.Name = "cmouldcode";
            this.cmouldcode.Width = 98;
            // 
            // camount
            // 
            this.camount.HeaderText = "Amount";
            this.camount.Name = "camount";
            this.camount.Width = 74;
            // 
            // cremarks
            // 
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            this.cremarks.Width = 79;
            // 
            // cmodify
            // 
            this.cmodify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cmodify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmodify.HeaderText = "Modify";
            this.cmodify.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmodify.Name = "cmodify";
            this.cmodify.Width = 52;
            // 
            // cpcs
            // 
            this.cpcs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cpcs.HeaderText = "Pcs";
            this.cpcs.Name = "cpcs";
            this.cpcs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cpcs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cpcs.Width = 32;
            // 
            // coem
            // 
            this.coem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.coem.HeaderText = "OEM";
            this.coem.Name = "coem";
            this.coem.Width = 58;
            // 
            // cbase
            // 
            this.cbase.HeaderText = "Base";
            this.cbase.Name = "cbase";
            this.cbase.Visible = false;
            this.cbase.Width = 58;
            // 
            // caccountcode
            // 
            this.caccountcode.HeaderText = "Account Code";
            this.caccountcode.Name = "caccountcode";
            this.caccountcode.Width = 106;
            // 
            // ccostcenter
            // 
            this.ccostcenter.HeaderText = "Cost Center";
            this.ccostcenter.Name = "ccostcenter";
            this.ccostcenter.Width = 94;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(1206, 28);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // QuotationEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuotationEditView";
            this.Size = new System.Drawing.Size(1212, 641);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUtil.controls.panel.CustomPanel pnlMain;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchaseno;
        private System.Windows.Forms.DataGridViewComboBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmodel;
        private System.Windows.Forms.DataGridViewComboBoxColumn cdiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn camount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmodify;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn coem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbase;
        private System.Windows.Forms.DataGridViewTextBoxColumn caccountcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccostcenter;
        private System.Windows.Forms.Button btnSave;
    }
}
