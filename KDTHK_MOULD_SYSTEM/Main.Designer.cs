namespace KDTHK_MOULD_SYSTEM
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlLeft = new CustomUtil.controls.panel.CustomPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblDisposal = new System.Windows.Forms.Label();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblPO = new System.Windows.Forms.Label();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblFixedAsset = new System.Windows.Forms.Label();
            this.lblRingi = new System.Windows.Forms.Label();
            this.lblQuotation = new System.Windows.Forms.Label();
            this.btnExtend = new System.Windows.Forms.Button();
            this.pnlMain = new CustomUtil.controls.panel.CustomPanel();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripDropDownButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1190, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton2.Tag = "home";
            this.toolStripButton2.Text = "Home";
            this.toolStripButton2.Click += new System.EventHandler(this.MenuClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton1.Tag = "quotation";
            this.toolStripDropDownButton1.Text = "Quotation";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.MenuClicked);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.ForeColor = System.Drawing.Color.White;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton3.Tag = "transfer";
            this.toolStripButton3.Text = "Transfer";
            this.toolStripButton3.Click += new System.EventHandler(this.MenuClicked);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.ForeColor = System.Drawing.Color.White;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton4.Tag = "disposal";
            this.toolStripButton4.Text = "Disposal";
            this.toolStripButton4.Click += new System.EventHandler(this.MenuClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton1.Tag = "report";
            this.toolStripButton1.Text = "Report";
            this.toolStripButton1.Click += new System.EventHandler(this.MenuClicked);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.ForeColor = System.Drawing.Color.White;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(37, 22);
            this.toolStripButton5.Tag = "data";
            this.toolStripButton5.Text = "Data";
            this.toolStripButton5.Click += new System.EventHandler(this.MenuClicked);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton6.ForeColor = System.Drawing.Color.White;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(47, 22);
            this.toolStripButton6.Tag = "setting";
            this.toolStripButton6.Text = "Setting";
            this.toolStripButton6.Click += new System.EventHandler(this.MenuClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1190, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pnlLeft.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlLeft.BorderColor = System.Drawing.Color.LightGray;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.BorderWidth = 1;
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.pnlMenu);
            this.pnlLeft.Controls.Add(this.btnExtend);
            this.pnlLeft.Curvature = 1;
            this.pnlLeft.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlLeft.Location = new System.Drawing.Point(0, 25);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 572);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblSetting);
            this.pnlMenu.Controls.Add(this.lblReport);
            this.pnlMenu.Controls.Add(this.lblMain);
            this.pnlMenu.Controls.Add(this.lblDisposal);
            this.pnlMenu.Controls.Add(this.lblTransfer);
            this.pnlMenu.Controls.Add(this.lblPO);
            this.pnlMenu.Controls.Add(this.lblInStock);
            this.pnlMenu.Controls.Add(this.lblFixedAsset);
            this.pnlMenu.Controls.Add(this.lblRingi);
            this.pnlMenu.Controls.Add(this.lblQuotation);
            this.pnlMenu.Location = new System.Drawing.Point(3, 32);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(195, 411);
            this.pnlMenu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 35);
            this.label1.TabIndex = 20;
            this.label1.Tag = "approval";
            this.label1.Text = "            Approval";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.label1, "Approval");
            this.label1.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblSetting
            // 
            this.lblSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblSetting.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.ForeColor = System.Drawing.Color.DimGray;
            this.lblSetting.Image = ((System.Drawing.Image)(resources.GetObject("lblSetting.Image")));
            this.lblSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSetting.Location = new System.Drawing.Point(3, 337);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(185, 35);
            this.lblSetting.TabIndex = 19;
            this.lblSetting.Tag = "setting";
            this.lblSetting.Text = "            Setting";
            this.lblSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblSetting, "Setting");
            this.lblSetting.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblReport
            // 
            this.lblReport.BackColor = System.Drawing.Color.Transparent;
            this.lblReport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.DimGray;
            this.lblReport.Image = ((System.Drawing.Image)(resources.GetObject("lblReport.Image")));
            this.lblReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReport.Location = new System.Drawing.Point(3, 300);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(185, 35);
            this.lblReport.TabIndex = 18;
            this.lblReport.Tag = "report";
            this.lblReport.Text = "            Report";
            this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblReport, "Report");
            this.lblReport.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblMain
            // 
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.DimGray;
            this.lblMain.Image = ((System.Drawing.Image)(resources.GetObject("lblMain.Image")));
            this.lblMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMain.Location = new System.Drawing.Point(3, 4);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(185, 35);
            this.lblMain.TabIndex = 17;
            this.lblMain.Tag = "mainview";
            this.lblMain.Text = "            Data View";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblMain, "Data View");
            this.lblMain.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblDisposal
            // 
            this.lblDisposal.BackColor = System.Drawing.Color.Transparent;
            this.lblDisposal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisposal.ForeColor = System.Drawing.Color.DimGray;
            this.lblDisposal.Image = ((System.Drawing.Image)(resources.GetObject("lblDisposal.Image")));
            this.lblDisposal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDisposal.Location = new System.Drawing.Point(3, 263);
            this.lblDisposal.Name = "lblDisposal";
            this.lblDisposal.Size = new System.Drawing.Size(185, 35);
            this.lblDisposal.TabIndex = 16;
            this.lblDisposal.Tag = "disposal";
            this.lblDisposal.Text = "            Disposal";
            this.lblDisposal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblDisposal, "Mould Disposal");
            this.lblDisposal.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblTransfer
            // 
            this.lblTransfer.BackColor = System.Drawing.Color.Transparent;
            this.lblTransfer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfer.ForeColor = System.Drawing.Color.DimGray;
            this.lblTransfer.Image = ((System.Drawing.Image)(resources.GetObject("lblTransfer.Image")));
            this.lblTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTransfer.Location = new System.Drawing.Point(3, 226);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(185, 35);
            this.lblTransfer.TabIndex = 15;
            this.lblTransfer.Tag = "transfer";
            this.lblTransfer.Text = "            Transfer";
            this.lblTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblTransfer, "Mould Transfer");
            this.lblTransfer.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblPO
            // 
            this.lblPO.BackColor = System.Drawing.Color.Transparent;
            this.lblPO.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPO.ForeColor = System.Drawing.Color.DimGray;
            this.lblPO.Image = ((System.Drawing.Image)(resources.GetObject("lblPO.Image")));
            this.lblPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPO.Location = new System.Drawing.Point(3, 152);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(185, 35);
            this.lblPO.TabIndex = 14;
            this.lblPO.Tag = "po";
            this.lblPO.Text = "            PO";
            this.lblPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblPO, "Issue PO");
            this.lblPO.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblInStock
            // 
            this.lblInStock.BackColor = System.Drawing.Color.Transparent;
            this.lblInStock.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.ForeColor = System.Drawing.Color.DimGray;
            this.lblInStock.Image = ((System.Drawing.Image)(resources.GetObject("lblInStock.Image")));
            this.lblInStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInStock.Location = new System.Drawing.Point(3, 189);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(185, 35);
            this.lblInStock.TabIndex = 13;
            this.lblInStock.Tag = "instock";
            this.lblInStock.Text = "            In Stock";
            this.lblInStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblInStock, "In Stock");
            this.lblInStock.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblFixedAsset
            // 
            this.lblFixedAsset.BackColor = System.Drawing.Color.Transparent;
            this.lblFixedAsset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedAsset.ForeColor = System.Drawing.Color.DimGray;
            this.lblFixedAsset.Image = ((System.Drawing.Image)(resources.GetObject("lblFixedAsset.Image")));
            this.lblFixedAsset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFixedAsset.Location = new System.Drawing.Point(3, 115);
            this.lblFixedAsset.Name = "lblFixedAsset";
            this.lblFixedAsset.Size = new System.Drawing.Size(185, 35);
            this.lblFixedAsset.TabIndex = 12;
            this.lblFixedAsset.Tag = "fa";
            this.lblFixedAsset.Text = "            Fixed Asset";
            this.lblFixedAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblFixedAsset, "Fixed Asset Progress");
            this.lblFixedAsset.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblRingi
            // 
            this.lblRingi.BackColor = System.Drawing.Color.Transparent;
            this.lblRingi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRingi.ForeColor = System.Drawing.Color.DimGray;
            this.lblRingi.Image = ((System.Drawing.Image)(resources.GetObject("lblRingi.Image")));
            this.lblRingi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRingi.Location = new System.Drawing.Point(3, 78);
            this.lblRingi.Name = "lblRingi";
            this.lblRingi.Size = new System.Drawing.Size(185, 35);
            this.lblRingi.TabIndex = 11;
            this.lblRingi.Tag = "ringi";
            this.lblRingi.Text = "            Ringi";
            this.lblRingi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblRingi, "Ringi Assign");
            this.lblRingi.Click += new System.EventHandler(this.LabelClicked);
            // 
            // lblQuotation
            // 
            this.lblQuotation.BackColor = System.Drawing.Color.Transparent;
            this.lblQuotation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotation.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuotation.Image = ((System.Drawing.Image)(resources.GetObject("lblQuotation.Image")));
            this.lblQuotation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuotation.Location = new System.Drawing.Point(3, 41);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(185, 35);
            this.lblQuotation.TabIndex = 10;
            this.lblQuotation.Tag = "quotation";
            this.lblQuotation.Text = "            Quotation";
            this.lblQuotation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooltip.SetToolTip(this.lblQuotation, "Quotation");
            this.lblQuotation.Click += new System.EventHandler(this.LabelClicked);
            // 
            // btnExtend
            // 
            this.btnExtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtend.BackgroundImage = global::KDTHK_MOULD_SYSTEM.Properties.Resources.left_button_basic_blue;
            this.btnExtend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExtend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtend.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExtend.FlatAppearance.BorderSize = 0;
            this.btnExtend.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExtend.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtend.Location = new System.Drawing.Point(167, 5);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(24, 24);
            this.btnExtend.TabIndex = 13;
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Window;
            this.pnlMain.BackColor2 = System.Drawing.SystemColors.Window;
            this.pnlMain.BorderColor = System.Drawing.Color.LightGray;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.BorderWidth = 1;
            this.pnlMain.Curvature = 1;
            this.pnlMain.CurveMode = ((CustomUtil.controls.panel.CornerCurveMode)((((CustomUtil.controls.panel.CornerCurveMode.TopLeft | CustomUtil.controls.panel.CornerCurveMode.TopRight) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomLeft) 
            | CustomUtil.controls.panel.CornerCurveMode.BottomRight)));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.GradientMode = CustomUtil.controls.panel.LinearGradientMode.None;
            this.pnlMain.Location = new System.Drawing.Point(200, 25);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(990, 572);
            this.pnlMain.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1190, 619);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "KDTHK MOULD SYSTEM";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private CustomUtil.controls.panel.CustomPanel pnlLeft;
        private CustomUtil.controls.panel.CustomPanel pnlMain;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblDisposal;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblFixedAsset;
        private System.Windows.Forms.Label lblRingi;
        private System.Windows.Forms.Label lblQuotation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button button1;
    }
}

