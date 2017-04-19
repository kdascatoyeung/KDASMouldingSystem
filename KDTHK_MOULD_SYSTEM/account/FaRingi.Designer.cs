namespace KDTHK_MOULD_SYSTEM.account
{
    partial class FaRingi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaRingi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbtnApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.dgvRingi = new System.Windows.Forms.DataGridView();
            this.capproval = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmgtno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRingi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbtnSend = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRingi)).BeginInit();
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
            this.tsbtnRefresh,
            this.tsbtnApprove,
            this.tsbtnSave,
            this.tsbtnSearch,
            this.tstxtSearch,
            this.tsbtnSend});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1213, 25);
            this.toolStrip1.TabIndex = 15;
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
            // dgvRingi
            // 
            this.dgvRingi.AllowUserToAddRows = false;
            this.dgvRingi.AllowUserToDeleteRows = false;
            this.dgvRingi.AllowUserToResizeRows = false;
            this.dgvRingi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRingi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRingi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRingi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRingi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvRingi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRingi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRingi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.capproval,
            this.cmgtno,
            this.crequest,
            this.cRingi,
            this.cdesc,
            this.cModel,
            this.cCur,
            this.cPrice,
            this.ctype,
            this.cid,
            this.ciid});
            this.dgvRingi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRingi.Location = new System.Drawing.Point(0, 24);
            this.dgvRingi.Name = "dgvRingi";
            this.dgvRingi.RowHeadersVisible = false;
            this.dgvRingi.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvRingi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRingi.Size = new System.Drawing.Size(1213, 615);
            this.dgvRingi.TabIndex = 16;
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
            // 
            // cmgtno
            // 
            this.cmgtno.DataPropertyName = "pdfid";
            this.cmgtno.HeaderText = "管理No.";
            this.cmgtno.Name = "cmgtno";
            this.cmgtno.ReadOnly = true;
            // 
            // crequest
            // 
            this.crequest.DataPropertyName = "request";
            this.crequest.HeaderText = "Request";
            this.crequest.Name = "crequest";
            // 
            // cRingi
            // 
            this.cRingi.DataPropertyName = "ringi";
            this.cRingi.HeaderText = "Ringi No.";
            this.cRingi.Name = "cRingi";
            this.cRingi.ReadOnly = true;
            // 
            // cdesc
            // 
            this.cdesc.DataPropertyName = "desc";
            this.cdesc.HeaderText = "Description";
            this.cdesc.Name = "cdesc";
            this.cdesc.ReadOnly = true;
            // 
            // cModel
            // 
            this.cModel.DataPropertyName = "model";
            this.cModel.HeaderText = "機種";
            this.cModel.Name = "cModel";
            this.cModel.ReadOnly = true;
            // 
            // cCur
            // 
            this.cCur.DataPropertyName = "currency";
            this.cCur.HeaderText = "通貨";
            this.cCur.Name = "cCur";
            this.cCur.ReadOnly = true;
            // 
            // cPrice
            // 
            this.cPrice.DataPropertyName = "amount";
            this.cPrice.HeaderText = "正味価格";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // ctype
            // 
            this.ctype.DataPropertyName = "type";
            this.ctype.HeaderText = "Type";
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "chaseno";
            this.cid.HeaderText = "chaseno";
            this.cid.Name = "cid";
            this.cid.Visible = false;
            // 
            // ciid
            // 
            this.ciid.DataPropertyName = "id";
            this.ciid.HeaderText = "id";
            this.ciid.Name = "ciid";
            this.ciid.Visible = false;
            // 
            // tsbtnSend
            // 
            this.tsbtnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSend.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnSend.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtnSend.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSend.Image")));
            this.tsbtnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSend.Name = "tsbtnSend";
            this.tsbtnSend.Size = new System.Drawing.Size(73, 22);
            this.tsbtnSend.Text = "Send Mail";
            this.tsbtnSend.Click += new System.EventHandler(this.tsbtnSend_Click);
            // 
            // FaRingi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvRingi);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FaRingi";
            this.Size = new System.Drawing.Size(1213, 639);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRingi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripButton tsbtnApprove;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.DataGridView dgvRingi;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.DataGridViewComboBoxColumn capproval;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmgtno;
        private System.Windows.Forms.DataGridViewTextBoxColumn crequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRingi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCur;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciid;
        private System.Windows.Forms.ToolStripButton tsbtnSend;
    }
}
