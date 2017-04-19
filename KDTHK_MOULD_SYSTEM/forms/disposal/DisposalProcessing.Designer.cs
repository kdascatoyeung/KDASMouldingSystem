namespace KDTHK_MOULD_SYSTEM.forms.disposal
{
    partial class DisposalProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisposalProcessing));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.dgvDisposal = new System.Windows.Forms.DataGridView();
            this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.ctype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cstatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cpchaseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmouldno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpartno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2003 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2003ans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2003result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2003updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2004 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2004ans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2004result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2004updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdcrps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdcseisan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdcissued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdcresult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckdcupdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccapdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cacquishkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caccumhkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cclosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbookhkd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbookhkd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cringi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creportno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creportissued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creportreceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvendorresult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfadate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cremarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisposal)).BeginInit();
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
            this.tsbtn,
            this.tsbtnRefresh,
            this.tsbtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1186, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn
            // 
            this.tsbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.tsbtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtn.ForeColor = System.Drawing.Color.DimGray;
            this.tsbtn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn.Image")));
            this.tsbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn.Name = "tsbtn";
            this.tsbtn.Size = new System.Drawing.Size(62, 22);
            this.tsbtn.Text = "Switch";
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestToolStripMenuItem.BackgroundImage")));
            this.requestToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.requestToolStripMenuItem.Text = "Request";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historyToolStripMenuItem.BackgroundImage")));
            this.historyToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
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
            // dgvDisposal
            // 
            this.dgvDisposal.AllowUserToAddRows = false;
            this.dgvDisposal.AllowUserToDeleteRows = false;
            this.dgvDisposal.AllowUserToResizeRows = false;
            this.dgvDisposal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisposal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDisposal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDisposal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisposal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvDisposal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDisposal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisposal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctype,
            this.cstatus,
            this.cpchaseno,
            this.cmouldno,
            this.cpartno,
            this.cfa,
            this.cvendor,
            this.cto,
            this.c2003,
            this.c2003ans,
            this.c2003result,
            this.c2003updated,
            this.c2004,
            this.c2004ans,
            this.c2004result,
            this.c2004updated,
            this.ckdc,
            this.ckdcrps,
            this.ckdcseisan,
            this.ckdcissued,
            this.ckdcresult,
            this.ckdcupdated,
            this.cdesc,
            this.ccapdate,
            this.cacquishkd,
            this.caccumhkd,
            this.cclosing,
            this.cbookhkd,
            this.cfy,
            this.cbookhkd2,
            this.cringi,
            this.creportno,
            this.creportissued,
            this.creportreceived,
            this.cvendorresult,
            this.cfadate,
            this.cremarks});
            this.dgvDisposal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDisposal.Location = new System.Drawing.Point(3, 26);
            this.dgvDisposal.Name = "dgvDisposal";
            this.dgvDisposal.RowHeadersVisible = false;
            this.dgvDisposal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvDisposal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDisposal.Size = new System.Drawing.Size(1164, 601);
            this.dgvDisposal.TabIndex = 25;
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
            // ctype
            // 
            this.ctype.DataPropertyName = "dtype";
            this.ctype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctype.HeaderText = "Type";
            this.ctype.Items.AddRange(new object[] {
            "-----",
            "Vendor提出",
            "KDC生産本部室提出",
            "IPO関連担当者提出",
            "不要金型"});
            this.ctype.Name = "ctype";
            this.ctype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ctype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ctype.Width = 56;
            // 
            // cstatus
            // 
            this.cstatus.DataPropertyName = "status";
            this.cstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cstatus.HeaderText = "Status";
            this.cstatus.Items.AddRange(new object[] {
            "調整依賴中",
            "日本生産本部確認中",
            "日本生産本部確認完了",
            "固定資産確認",
            "廃棄稟議書申請",
            "廃棄報告書発行済",
            "廃棄報告書回収済",
            "固定資産廃棄申請"});
            this.cstatus.Name = "cstatus";
            this.cstatus.Width = 47;
            // 
            // cpchaseno
            // 
            this.cpchaseno.DataPropertyName = "chaseno";
            this.cpchaseno.HeaderText = "Chase No.";
            this.cpchaseno.Name = "cpchaseno";
            this.cpchaseno.ReadOnly = true;
            this.cpchaseno.Visible = false;
            this.cpchaseno.Width = 86;
            // 
            // cmouldno
            // 
            this.cmouldno.DataPropertyName = "mould";
            this.cmouldno.HeaderText = "Mould";
            this.cmouldno.Name = "cmouldno";
            this.cmouldno.ReadOnly = true;
            this.cmouldno.Width = 68;
            // 
            // cpartno
            // 
            this.cpartno.DataPropertyName = "partno";
            this.cpartno.HeaderText = "Part No.";
            this.cpartno.Name = "cpartno";
            this.cpartno.ReadOnly = true;
            this.cpartno.Width = 76;
            // 
            // cfa
            // 
            this.cfa.DataPropertyName = "asset";
            this.cfa.HeaderText = "Fixed Asset";
            this.cfa.Name = "cfa";
            this.cfa.ReadOnly = true;
            this.cfa.Width = 93;
            // 
            // cvendor
            // 
            this.cvendor.DataPropertyName = "vendor";
            this.cvendor.HeaderText = "Vendor";
            this.cvendor.Name = "cvendor";
            this.cvendor.ReadOnly = true;
            this.cvendor.Width = 70;
            // 
            // cto
            // 
            this.cto.DataPropertyName = "name";
            this.cto.HeaderText = "Vendor Name";
            this.cto.Name = "cto";
            this.cto.ReadOnly = true;
            this.cto.Width = 104;
            // 
            // c2003
            // 
            this.c2003.DataPropertyName = "p2003n";
            this.c2003.HeaderText = "P2003 No.";
            this.c2003.Name = "c2003";
            this.c2003.Width = 88;
            // 
            // c2003ans
            // 
            this.c2003ans.DataPropertyName = "p2003ans";
            this.c2003ans.HeaderText = "P2003 Ans";
            this.c2003ans.Name = "c2003ans";
            this.c2003ans.Width = 90;
            // 
            // c2003result
            // 
            this.c2003result.DataPropertyName = "p2003result";
            this.c2003result.HeaderText = "P2003 Result";
            this.c2003result.Name = "c2003result";
            this.c2003result.Width = 104;
            // 
            // c2003updated
            // 
            this.c2003updated.DataPropertyName = "p2003updated";
            this.c2003updated.HeaderText = "P2003 Updated";
            this.c2003updated.Name = "c2003updated";
            this.c2003updated.Width = 106;
            // 
            // c2004
            // 
            this.c2004.DataPropertyName = "p2004n";
            this.c2004.HeaderText = "P2004 No.";
            this.c2004.Name = "c2004";
            this.c2004.Width = 81;
            // 
            // c2004ans
            // 
            this.c2004ans.DataPropertyName = "p2004ans";
            this.c2004ans.HeaderText = "P2004 Ans";
            this.c2004ans.Name = "c2004ans";
            this.c2004ans.Width = 83;
            // 
            // c2004result
            // 
            this.c2004result.DataPropertyName = "p2004result";
            this.c2004result.HeaderText = "P2004 Result";
            this.c2004result.Name = "c2004result";
            this.c2004result.Width = 96;
            // 
            // c2004updated
            // 
            this.c2004updated.DataPropertyName = "p2004updated";
            this.c2004updated.HeaderText = "P2004 Updated";
            this.c2004updated.Name = "c2004updated";
            this.c2004updated.Width = 106;
            // 
            // ckdc
            // 
            this.ckdc.DataPropertyName = "kdcno";
            this.ckdc.HeaderText = "KDC No.";
            this.ckdc.Name = "ckdc";
            this.ckdc.Width = 69;
            // 
            // ckdcrps
            // 
            this.ckdcrps.DataPropertyName = "kdcrps";
            this.ckdcrps.HeaderText = "KDC RPS";
            this.ckdcrps.Name = "ckdcrps";
            this.ckdcrps.Width = 71;
            // 
            // ckdcseisan
            // 
            this.ckdcseisan.DataPropertyName = "kdcseisan";
            this.ckdcseisan.HeaderText = "KDC Seisan";
            this.ckdcseisan.Name = "ckdcseisan";
            this.ckdcseisan.Width = 86;
            // 
            // ckdcissued
            // 
            this.ckdcissued.DataPropertyName = "kdcissued";
            this.ckdcissued.HeaderText = "KDC Issued";
            this.ckdcissued.Name = "ckdcissued";
            this.ckdcissued.Width = 86;
            // 
            // ckdcresult
            // 
            this.ckdcresult.DataPropertyName = "kdcresult";
            this.ckdcresult.HeaderText = "KDC Result";
            this.ckdcresult.Name = "ckdcresult";
            this.ckdcresult.Width = 84;
            // 
            // ckdcupdated
            // 
            this.ckdcupdated.DataPropertyName = "kdcupdated";
            this.ckdcupdated.HeaderText = "KDC Updated";
            this.ckdcupdated.Name = "ckdcupdated";
            this.ckdcupdated.Width = 95;
            // 
            // cdesc
            // 
            this.cdesc.DataPropertyName = "de";
            this.cdesc.HeaderText = "Asset Desc";
            this.cdesc.Name = "cdesc";
            this.cdesc.Width = 83;
            // 
            // ccapdate
            // 
            this.ccapdate.DataPropertyName = "capdate";
            this.ccapdate.HeaderText = "Cap Date";
            this.ccapdate.Name = "ccapdate";
            this.ccapdate.Width = 75;
            // 
            // cacquishkd
            // 
            this.cacquishkd.DataPropertyName = "acquis";
            this.cacquishkd.HeaderText = "AcquisHKD";
            this.cacquishkd.Name = "cacquishkd";
            this.cacquishkd.Width = 92;
            // 
            // caccumhkd
            // 
            this.caccumhkd.DataPropertyName = "accum";
            this.caccumhkd.HeaderText = "AccumHKD";
            this.caccumhkd.Name = "caccumhkd";
            this.caccumhkd.Width = 91;
            // 
            // cclosing
            // 
            this.cclosing.DataPropertyName = "closing";
            this.cclosing.HeaderText = "Closing Month";
            this.cclosing.Name = "cclosing";
            this.cclosing.Width = 103;
            // 
            // cbookhkd
            // 
            this.cbookhkd.DataPropertyName = "bv1";
            this.cbookhkd.HeaderText = "Bool Val.";
            this.cbookhkd.Name = "cbookhkd";
            this.cbookhkd.Width = 74;
            // 
            // cfy
            // 
            this.cfy.DataPropertyName = "fy";
            this.cfy.HeaderText = "FY";
            this.cfy.Name = "cfy";
            this.cfy.Width = 44;
            // 
            // cbookhkd2
            // 
            this.cbookhkd2.DataPropertyName = "bv2";
            this.cbookhkd2.HeaderText = "Book Val.";
            this.cbookhkd2.Name = "cbookhkd2";
            this.cbookhkd2.Width = 76;
            // 
            // cringi
            // 
            this.cringi.DataPropertyName = "ringi";
            this.cringi.HeaderText = "Ringi";
            this.cringi.Name = "cringi";
            this.cringi.Width = 60;
            // 
            // creportno
            // 
            this.creportno.DataPropertyName = "reportno";
            this.creportno.HeaderText = "Report No.";
            this.creportno.Name = "creportno";
            this.creportno.Width = 82;
            // 
            // creportissued
            // 
            this.creportissued.DataPropertyName = "reportissued";
            this.creportissued.HeaderText = "Report Issued";
            this.creportissued.Name = "creportissued";
            this.creportissued.Width = 98;
            // 
            // creportreceived
            // 
            this.creportreceived.DataPropertyName = "reportreceived";
            this.creportreceived.HeaderText = "Report Received";
            this.creportreceived.Name = "creportreceived";
            this.creportreceived.Width = 109;
            // 
            // cvendorresult
            // 
            this.cvendorresult.DataPropertyName = "vendorresult";
            this.cvendorresult.HeaderText = "Vendor Result";
            this.cvendorresult.Name = "cvendorresult";
            this.cvendorresult.Width = 98;
            // 
            // cfadate
            // 
            this.cfadate.DataPropertyName = "disposaldate";
            this.cfadate.HeaderText = "FA Disposal Date";
            this.cfadate.Name = "cfadate";
            this.cfadate.Width = 114;
            // 
            // cremarks
            // 
            this.cremarks.DataPropertyName = "remarks";
            this.cremarks.HeaderText = "Remarks";
            this.cremarks.Name = "cremarks";
            this.cremarks.Width = 79;
            // 
            // DisposalProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dgvDisposal);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DisposalProcessing";
            this.Size = new System.Drawing.Size(1186, 642);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisposal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsbtn;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.DataGridView dgvDisposal;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.DataGridViewComboBoxColumn ctype;
        private System.Windows.Forms.DataGridViewComboBoxColumn cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpchaseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmouldno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpartno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cto;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2003;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2003ans;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2003result;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2003updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2004;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2004ans;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2004result;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2004updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdcrps;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdcseisan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdcissued;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdcresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckdcupdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccapdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacquishkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn caccumhkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbookhkd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbookhkd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cringi;
        private System.Windows.Forms.DataGridViewTextBoxColumn creportno;
        private System.Windows.Forms.DataGridViewTextBoxColumn creportissued;
        private System.Windows.Forms.DataGridViewTextBoxColumn creportreceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvendorresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfadate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cremarks;
    }
}
