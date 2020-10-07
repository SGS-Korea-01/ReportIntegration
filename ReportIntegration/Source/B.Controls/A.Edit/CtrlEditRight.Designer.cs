namespace Sgs.ReportIntegration
{
    partial class CtrlEditRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlEditRight));
            this.menuPanel = new Ulee.Controls.UlPanel();
            this.integrationButton = new DevExpress.XtraEditors.SimpleButton();
            this.bomButton = new DevExpress.XtraEditors.SimpleButton();
            this.chemicalButton = new DevExpress.XtraEditors.SimpleButton();
            this.physicalButton = new DevExpress.XtraEditors.SimpleButton();
            this.chemicalMenuPanel = new Ulee.Controls.UlPanel();
            this.chemicalSaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.chemicalCancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.chemicalPrintButton = new DevExpress.XtraEditors.SimpleButton();
            this.chemicalDeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.chemicalImportButton = new DevExpress.XtraEditors.SimpleButton();
            this.physicalMenuPanel = new Ulee.Controls.UlPanel();
            this.physicalSaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.physicalCancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.physicalPrintButton = new DevExpress.XtraEditors.SimpleButton();
            this.physicalDeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.physicalImportButton = new DevExpress.XtraEditors.SimpleButton();
            this.bomMenuPanel = new Ulee.Controls.UlPanel();
            this.bomDeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.bomImportButton = new DevExpress.XtraEditors.SimpleButton();
            this.viewPanel = new Ulee.Controls.UlPanel();
            this.integMenuPanel = new Ulee.Controls.UlPanel();
            this.integSaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.integCancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.integPrintButton = new DevExpress.XtraEditors.SimpleButton();
            this.integDeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.integImportButton = new DevExpress.XtraEditors.SimpleButton();
            this.bgPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.chemicalMenuPanel.SuspendLayout();
            this.physicalMenuPanel.SuspendLayout();
            this.bomMenuPanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.integMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.AutoSize = false;
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.menuPanel);
            this.bgPanel.Controls.Add(this.viewPanel);
            this.bgPanel.Size = new System.Drawing.Size(908, 568);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Silver;
            this.menuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.menuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.menuPanel.Controls.Add(this.integrationButton);
            this.menuPanel.Controls.Add(this.bomButton);
            this.menuPanel.Controls.Add(this.chemicalButton);
            this.menuPanel.Controls.Add(this.physicalButton);
            this.menuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.InnerColor2 = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(824, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.OuterColor2 = System.Drawing.Color.White;
            this.menuPanel.Size = new System.Drawing.Size(84, 568);
            this.menuPanel.Spacing = 0;
            this.menuPanel.TabIndex = 8;
            this.menuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.menuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // integrationButton
            // 
            this.integrationButton.AllowFocus = false;
            this.integrationButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrationButton.Appearance.Options.UseFont = true;
            this.integrationButton.Appearance.Options.UseTextOptions = true;
            this.integrationButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.integrationButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("integrationButton.ImageOptions.Image")));
            this.integrationButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.integrationButton.Location = new System.Drawing.Point(2, 182);
            this.integrationButton.LookAndFeel.SkinName = "DevExpress Style";
            this.integrationButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.integrationButton.Name = "integrationButton";
            this.integrationButton.Size = new System.Drawing.Size(80, 58);
            this.integrationButton.TabIndex = 39;
            this.integrationButton.TabStop = false;
            this.integrationButton.Tag = "0";
            this.integrationButton.Text = "INTEGR.";
            // 
            // bomButton
            // 
            this.bomButton.AllowFocus = false;
            this.bomButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomButton.Appearance.Options.UseFont = true;
            this.bomButton.Appearance.Options.UseTextOptions = true;
            this.bomButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.bomButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bomButton.ImageOptions.Image")));
            this.bomButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.bomButton.Location = new System.Drawing.Point(2, 2);
            this.bomButton.LookAndFeel.SkinName = "DevExpress Style";
            this.bomButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bomButton.Name = "bomButton";
            this.bomButton.Size = new System.Drawing.Size(80, 58);
            this.bomButton.TabIndex = 36;
            this.bomButton.TabStop = false;
            this.bomButton.Tag = "0";
            this.bomButton.Text = "BOM";
            // 
            // chemicalButton
            // 
            this.chemicalButton.AllowFocus = false;
            this.chemicalButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalButton.Appearance.Options.UseFont = true;
            this.chemicalButton.Appearance.Options.UseTextOptions = true;
            this.chemicalButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.chemicalButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chemicalButton.ImageOptions.Image")));
            this.chemicalButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.chemicalButton.Location = new System.Drawing.Point(2, 122);
            this.chemicalButton.LookAndFeel.SkinName = "DevExpress Style";
            this.chemicalButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chemicalButton.Name = "chemicalButton";
            this.chemicalButton.Size = new System.Drawing.Size(80, 58);
            this.chemicalButton.TabIndex = 38;
            this.chemicalButton.TabStop = false;
            this.chemicalButton.Tag = "0";
            this.chemicalButton.Text = "CHEMICAL";
            // 
            // physicalButton
            // 
            this.physicalButton.AllowFocus = false;
            this.physicalButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalButton.Appearance.Options.UseFont = true;
            this.physicalButton.Appearance.Options.UseTextOptions = true;
            this.physicalButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.physicalButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("physicalButton.ImageOptions.Image")));
            this.physicalButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.physicalButton.Location = new System.Drawing.Point(2, 62);
            this.physicalButton.LookAndFeel.SkinName = "DevExpress Style";
            this.physicalButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.physicalButton.Name = "physicalButton";
            this.physicalButton.Size = new System.Drawing.Size(80, 58);
            this.physicalButton.TabIndex = 37;
            this.physicalButton.TabStop = false;
            this.physicalButton.Tag = "0";
            this.physicalButton.Text = "PHYSICAL";
            // 
            // chemicalMenuPanel
            // 
            this.chemicalMenuPanel.BackColor = System.Drawing.Color.Silver;
            this.chemicalMenuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.chemicalMenuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.chemicalMenuPanel.Controls.Add(this.chemicalSaveButton);
            this.chemicalMenuPanel.Controls.Add(this.chemicalCancelButton);
            this.chemicalMenuPanel.Controls.Add(this.chemicalPrintButton);
            this.chemicalMenuPanel.Controls.Add(this.chemicalDeleteButton);
            this.chemicalMenuPanel.Controls.Add(this.chemicalImportButton);
            this.chemicalMenuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.chemicalMenuPanel.InnerColor2 = System.Drawing.Color.White;
            this.chemicalMenuPanel.Location = new System.Drawing.Point(566, 270);
            this.chemicalMenuPanel.Name = "chemicalMenuPanel";
            this.chemicalMenuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.chemicalMenuPanel.OuterColor2 = System.Drawing.Color.White;
            this.chemicalMenuPanel.Size = new System.Drawing.Size(80, 298);
            this.chemicalMenuPanel.Spacing = 0;
            this.chemicalMenuPanel.TabIndex = 41;
            this.chemicalMenuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.chemicalMenuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // chemicalSaveButton
            // 
            this.chemicalSaveButton.AllowFocus = false;
            this.chemicalSaveButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalSaveButton.Appearance.Options.UseBorderColor = true;
            this.chemicalSaveButton.Appearance.Options.UseFont = true;
            this.chemicalSaveButton.Appearance.Options.UseTextOptions = true;
            this.chemicalSaveButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.chemicalSaveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chemicalSaveButton.ImageOptions.Image")));
            this.chemicalSaveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.chemicalSaveButton.Location = new System.Drawing.Point(0, 180);
            this.chemicalSaveButton.LookAndFeel.SkinName = "DevExpress Style";
            this.chemicalSaveButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chemicalSaveButton.Name = "chemicalSaveButton";
            this.chemicalSaveButton.Size = new System.Drawing.Size(80, 58);
            this.chemicalSaveButton.TabIndex = 46;
            this.chemicalSaveButton.TabStop = false;
            this.chemicalSaveButton.Text = "SAVE";
            this.chemicalSaveButton.Click += new System.EventHandler(this.chemicalSaveButton_Click);
            // 
            // chemicalCancelButton
            // 
            this.chemicalCancelButton.AllowFocus = false;
            this.chemicalCancelButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalCancelButton.Appearance.Options.UseBorderColor = true;
            this.chemicalCancelButton.Appearance.Options.UseFont = true;
            this.chemicalCancelButton.Appearance.Options.UseTextOptions = true;
            this.chemicalCancelButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.chemicalCancelButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chemicalCancelButton.ImageOptions.Image")));
            this.chemicalCancelButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.chemicalCancelButton.Location = new System.Drawing.Point(0, 240);
            this.chemicalCancelButton.LookAndFeel.SkinName = "DevExpress Style";
            this.chemicalCancelButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chemicalCancelButton.Name = "chemicalCancelButton";
            this.chemicalCancelButton.Size = new System.Drawing.Size(80, 58);
            this.chemicalCancelButton.TabIndex = 45;
            this.chemicalCancelButton.TabStop = false;
            this.chemicalCancelButton.Text = "CANCEL";
            this.chemicalCancelButton.Click += new System.EventHandler(this.chemicalCancelButton_Click);
            // 
            // chemicalPrintButton
            // 
            this.chemicalPrintButton.AllowFocus = false;
            this.chemicalPrintButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalPrintButton.Appearance.Options.UseFont = true;
            this.chemicalPrintButton.Appearance.Options.UseTextOptions = true;
            this.chemicalPrintButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.chemicalPrintButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chemicalPrintButton.ImageOptions.Image")));
            this.chemicalPrintButton.ImageOptions.ImageToTextIndent = 0;
            this.chemicalPrintButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.chemicalPrintButton.Location = new System.Drawing.Point(0, 120);
            this.chemicalPrintButton.LookAndFeel.SkinName = "DevExpress Style";
            this.chemicalPrintButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chemicalPrintButton.Name = "chemicalPrintButton";
            this.chemicalPrintButton.Size = new System.Drawing.Size(80, 58);
            this.chemicalPrintButton.TabIndex = 41;
            this.chemicalPrintButton.TabStop = false;
            this.chemicalPrintButton.Text = "PRINT";
            this.chemicalPrintButton.Click += new System.EventHandler(this.chemicalPrintButton_Click);
            // 
            // chemicalDeleteButton
            // 
            this.chemicalDeleteButton.AllowFocus = false;
            this.chemicalDeleteButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalDeleteButton.Appearance.Options.UseFont = true;
            this.chemicalDeleteButton.Appearance.Options.UseTextOptions = true;
            this.chemicalDeleteButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.chemicalDeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chemicalDeleteButton.ImageOptions.Image")));
            this.chemicalDeleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.chemicalDeleteButton.Location = new System.Drawing.Point(0, 60);
            this.chemicalDeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.chemicalDeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chemicalDeleteButton.Name = "chemicalDeleteButton";
            this.chemicalDeleteButton.Size = new System.Drawing.Size(80, 58);
            this.chemicalDeleteButton.TabIndex = 37;
            this.chemicalDeleteButton.TabStop = false;
            this.chemicalDeleteButton.Tag = "0";
            this.chemicalDeleteButton.Text = "DELETE";
            this.chemicalDeleteButton.Click += new System.EventHandler(this.chemicalDeleteButton_Click);
            // 
            // chemicalImportButton
            // 
            this.chemicalImportButton.AllowFocus = false;
            this.chemicalImportButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicalImportButton.Appearance.Options.UseFont = true;
            this.chemicalImportButton.Appearance.Options.UseTextOptions = true;
            this.chemicalImportButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.chemicalImportButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("chemicalImportButton.ImageOptions.Image")));
            this.chemicalImportButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.chemicalImportButton.Location = new System.Drawing.Point(0, 0);
            this.chemicalImportButton.LookAndFeel.SkinName = "DevExpress Style";
            this.chemicalImportButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chemicalImportButton.Name = "chemicalImportButton";
            this.chemicalImportButton.Size = new System.Drawing.Size(80, 58);
            this.chemicalImportButton.TabIndex = 36;
            this.chemicalImportButton.TabStop = false;
            this.chemicalImportButton.Tag = "0";
            this.chemicalImportButton.Text = "IMPORT";
            this.chemicalImportButton.Click += new System.EventHandler(this.chemicalImportButton_Click);
            // 
            // physicalMenuPanel
            // 
            this.physicalMenuPanel.BackColor = System.Drawing.Color.Silver;
            this.physicalMenuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.physicalMenuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.physicalMenuPanel.Controls.Add(this.physicalSaveButton);
            this.physicalMenuPanel.Controls.Add(this.physicalCancelButton);
            this.physicalMenuPanel.Controls.Add(this.physicalPrintButton);
            this.physicalMenuPanel.Controls.Add(this.physicalDeleteButton);
            this.physicalMenuPanel.Controls.Add(this.physicalImportButton);
            this.physicalMenuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.physicalMenuPanel.InnerColor2 = System.Drawing.Color.White;
            this.physicalMenuPanel.Location = new System.Drawing.Point(480, 270);
            this.physicalMenuPanel.Name = "physicalMenuPanel";
            this.physicalMenuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.physicalMenuPanel.OuterColor2 = System.Drawing.Color.White;
            this.physicalMenuPanel.Size = new System.Drawing.Size(80, 298);
            this.physicalMenuPanel.Spacing = 0;
            this.physicalMenuPanel.TabIndex = 40;
            this.physicalMenuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.physicalMenuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // physicalSaveButton
            // 
            this.physicalSaveButton.AllowFocus = false;
            this.physicalSaveButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalSaveButton.Appearance.Options.UseBorderColor = true;
            this.physicalSaveButton.Appearance.Options.UseFont = true;
            this.physicalSaveButton.Appearance.Options.UseTextOptions = true;
            this.physicalSaveButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.physicalSaveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("physicalSaveButton.ImageOptions.Image")));
            this.physicalSaveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.physicalSaveButton.Location = new System.Drawing.Point(0, 180);
            this.physicalSaveButton.LookAndFeel.SkinName = "DevExpress Style";
            this.physicalSaveButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.physicalSaveButton.Name = "physicalSaveButton";
            this.physicalSaveButton.Size = new System.Drawing.Size(80, 58);
            this.physicalSaveButton.TabIndex = 44;
            this.physicalSaveButton.TabStop = false;
            this.physicalSaveButton.Text = "SAVE";
            this.physicalSaveButton.Click += new System.EventHandler(this.physicalSaveButton_Click);
            // 
            // physicalCancelButton
            // 
            this.physicalCancelButton.AllowFocus = false;
            this.physicalCancelButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalCancelButton.Appearance.Options.UseBorderColor = true;
            this.physicalCancelButton.Appearance.Options.UseFont = true;
            this.physicalCancelButton.Appearance.Options.UseTextOptions = true;
            this.physicalCancelButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.physicalCancelButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("physicalCancelButton.ImageOptions.Image")));
            this.physicalCancelButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.physicalCancelButton.Location = new System.Drawing.Point(0, 240);
            this.physicalCancelButton.LookAndFeel.SkinName = "DevExpress Style";
            this.physicalCancelButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.physicalCancelButton.Name = "physicalCancelButton";
            this.physicalCancelButton.Size = new System.Drawing.Size(80, 58);
            this.physicalCancelButton.TabIndex = 43;
            this.physicalCancelButton.TabStop = false;
            this.physicalCancelButton.Text = "CANCEL";
            this.physicalCancelButton.Click += new System.EventHandler(this.physicalCancelButton_Click);
            // 
            // physicalPrintButton
            // 
            this.physicalPrintButton.AllowFocus = false;
            this.physicalPrintButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalPrintButton.Appearance.Options.UseFont = true;
            this.physicalPrintButton.Appearance.Options.UseTextOptions = true;
            this.physicalPrintButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.physicalPrintButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("physicalPrintButton.ImageOptions.Image")));
            this.physicalPrintButton.ImageOptions.ImageToTextIndent = 0;
            this.physicalPrintButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.physicalPrintButton.Location = new System.Drawing.Point(0, 120);
            this.physicalPrintButton.LookAndFeel.SkinName = "DevExpress Style";
            this.physicalPrintButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.physicalPrintButton.Name = "physicalPrintButton";
            this.physicalPrintButton.Size = new System.Drawing.Size(80, 58);
            this.physicalPrintButton.TabIndex = 42;
            this.physicalPrintButton.TabStop = false;
            this.physicalPrintButton.Text = "PRINT";
            this.physicalPrintButton.Click += new System.EventHandler(this.physicalPrintButton_Click);
            // 
            // physicalDeleteButton
            // 
            this.physicalDeleteButton.AllowFocus = false;
            this.physicalDeleteButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalDeleteButton.Appearance.Options.UseFont = true;
            this.physicalDeleteButton.Appearance.Options.UseTextOptions = true;
            this.physicalDeleteButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.physicalDeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("physicalDeleteButton.ImageOptions.Image")));
            this.physicalDeleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.physicalDeleteButton.Location = new System.Drawing.Point(0, 60);
            this.physicalDeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.physicalDeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.physicalDeleteButton.Name = "physicalDeleteButton";
            this.physicalDeleteButton.Size = new System.Drawing.Size(80, 58);
            this.physicalDeleteButton.TabIndex = 37;
            this.physicalDeleteButton.TabStop = false;
            this.physicalDeleteButton.Tag = "0";
            this.physicalDeleteButton.Text = "DELETE";
            this.physicalDeleteButton.Click += new System.EventHandler(this.physicalDeleteButton_Click);
            // 
            // physicalImportButton
            // 
            this.physicalImportButton.AllowFocus = false;
            this.physicalImportButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalImportButton.Appearance.Options.UseFont = true;
            this.physicalImportButton.Appearance.Options.UseTextOptions = true;
            this.physicalImportButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.physicalImportButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("physicalImportButton.ImageOptions.Image")));
            this.physicalImportButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.physicalImportButton.Location = new System.Drawing.Point(0, 0);
            this.physicalImportButton.LookAndFeel.SkinName = "DevExpress Style";
            this.physicalImportButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.physicalImportButton.Name = "physicalImportButton";
            this.physicalImportButton.Size = new System.Drawing.Size(80, 58);
            this.physicalImportButton.TabIndex = 36;
            this.physicalImportButton.TabStop = false;
            this.physicalImportButton.Tag = "0";
            this.physicalImportButton.Text = "IMPORT";
            this.physicalImportButton.Click += new System.EventHandler(this.physicalImportButton_Click);
            // 
            // bomMenuPanel
            // 
            this.bomMenuPanel.BackColor = System.Drawing.Color.Silver;
            this.bomMenuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.bomMenuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bomMenuPanel.Controls.Add(this.bomDeleteButton);
            this.bomMenuPanel.Controls.Add(this.bomImportButton);
            this.bomMenuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.bomMenuPanel.InnerColor2 = System.Drawing.Color.White;
            this.bomMenuPanel.Location = new System.Drawing.Point(737, 328);
            this.bomMenuPanel.Name = "bomMenuPanel";
            this.bomMenuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.bomMenuPanel.OuterColor2 = System.Drawing.Color.White;
            this.bomMenuPanel.Size = new System.Drawing.Size(80, 240);
            this.bomMenuPanel.Spacing = 0;
            this.bomMenuPanel.TabIndex = 39;
            this.bomMenuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.bomMenuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // bomDeleteButton
            // 
            this.bomDeleteButton.AllowFocus = false;
            this.bomDeleteButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomDeleteButton.Appearance.Options.UseFont = true;
            this.bomDeleteButton.Appearance.Options.UseTextOptions = true;
            this.bomDeleteButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.bomDeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bomDeleteButton.ImageOptions.Image")));
            this.bomDeleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.bomDeleteButton.Location = new System.Drawing.Point(0, 182);
            this.bomDeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.bomDeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bomDeleteButton.Name = "bomDeleteButton";
            this.bomDeleteButton.Size = new System.Drawing.Size(80, 58);
            this.bomDeleteButton.TabIndex = 37;
            this.bomDeleteButton.TabStop = false;
            this.bomDeleteButton.Tag = "0";
            this.bomDeleteButton.Text = "DELETE";
            this.bomDeleteButton.Click += new System.EventHandler(this.bomDeleteButton_Click);
            // 
            // bomImportButton
            // 
            this.bomImportButton.AllowFocus = false;
            this.bomImportButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bomImportButton.Appearance.Options.UseFont = true;
            this.bomImportButton.Appearance.Options.UseTextOptions = true;
            this.bomImportButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.bomImportButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bomImportButton.ImageOptions.Image")));
            this.bomImportButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.bomImportButton.Location = new System.Drawing.Point(0, 122);
            this.bomImportButton.LookAndFeel.SkinName = "DevExpress Style";
            this.bomImportButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.bomImportButton.Name = "bomImportButton";
            this.bomImportButton.Size = new System.Drawing.Size(80, 58);
            this.bomImportButton.TabIndex = 36;
            this.bomImportButton.TabStop = false;
            this.bomImportButton.Tag = "0";
            this.bomImportButton.Text = "IMPORT";
            this.bomImportButton.Click += new System.EventHandler(this.bomImportButton_Click);
            // 
            // viewPanel
            // 
            this.viewPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.Controls.Add(this.integMenuPanel);
            this.viewPanel.Controls.Add(this.physicalMenuPanel);
            this.viewPanel.Controls.Add(this.bomMenuPanel);
            this.viewPanel.Controls.Add(this.chemicalMenuPanel);
            this.viewPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewPanel.Size = new System.Drawing.Size(820, 568);
            this.viewPanel.Spacing = 0;
            this.viewPanel.TabIndex = 9;
            this.viewPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // integMenuPanel
            // 
            this.integMenuPanel.BackColor = System.Drawing.Color.Silver;
            this.integMenuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.integMenuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.integMenuPanel.Controls.Add(this.integSaveButton);
            this.integMenuPanel.Controls.Add(this.integCancelButton);
            this.integMenuPanel.Controls.Add(this.integPrintButton);
            this.integMenuPanel.Controls.Add(this.integDeleteButton);
            this.integMenuPanel.Controls.Add(this.integImportButton);
            this.integMenuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.integMenuPanel.InnerColor2 = System.Drawing.Color.White;
            this.integMenuPanel.Location = new System.Drawing.Point(652, 270);
            this.integMenuPanel.Name = "integMenuPanel";
            this.integMenuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.integMenuPanel.OuterColor2 = System.Drawing.Color.White;
            this.integMenuPanel.Size = new System.Drawing.Size(80, 298);
            this.integMenuPanel.Spacing = 0;
            this.integMenuPanel.TabIndex = 42;
            this.integMenuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.integMenuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // integSaveButton
            // 
            this.integSaveButton.AllowFocus = false;
            this.integSaveButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integSaveButton.Appearance.Options.UseBorderColor = true;
            this.integSaveButton.Appearance.Options.UseFont = true;
            this.integSaveButton.Appearance.Options.UseTextOptions = true;
            this.integSaveButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.integSaveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("integSaveButton.ImageOptions.Image")));
            this.integSaveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.integSaveButton.Location = new System.Drawing.Point(0, 180);
            this.integSaveButton.LookAndFeel.SkinName = "DevExpress Style";
            this.integSaveButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.integSaveButton.Name = "integSaveButton";
            this.integSaveButton.Size = new System.Drawing.Size(80, 58);
            this.integSaveButton.TabIndex = 46;
            this.integSaveButton.TabStop = false;
            this.integSaveButton.Text = "SAVE";
            this.integSaveButton.Click += new System.EventHandler(this.integSaveButton_Click);
            // 
            // integCancelButton
            // 
            this.integCancelButton.AllowFocus = false;
            this.integCancelButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integCancelButton.Appearance.Options.UseBorderColor = true;
            this.integCancelButton.Appearance.Options.UseFont = true;
            this.integCancelButton.Appearance.Options.UseTextOptions = true;
            this.integCancelButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.integCancelButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("integCancelButton.ImageOptions.Image")));
            this.integCancelButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.integCancelButton.Location = new System.Drawing.Point(0, 240);
            this.integCancelButton.LookAndFeel.SkinName = "DevExpress Style";
            this.integCancelButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.integCancelButton.Name = "integCancelButton";
            this.integCancelButton.Size = new System.Drawing.Size(80, 58);
            this.integCancelButton.TabIndex = 45;
            this.integCancelButton.TabStop = false;
            this.integCancelButton.Text = "CANCEL";
            this.integCancelButton.Click += new System.EventHandler(this.integCancelButton_Click);
            // 
            // integPrintButton
            // 
            this.integPrintButton.AllowFocus = false;
            this.integPrintButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integPrintButton.Appearance.Options.UseFont = true;
            this.integPrintButton.Appearance.Options.UseTextOptions = true;
            this.integPrintButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.integPrintButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("integPrintButton.ImageOptions.Image")));
            this.integPrintButton.ImageOptions.ImageToTextIndent = 0;
            this.integPrintButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.integPrintButton.Location = new System.Drawing.Point(0, 120);
            this.integPrintButton.LookAndFeel.SkinName = "DevExpress Style";
            this.integPrintButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.integPrintButton.Name = "integPrintButton";
            this.integPrintButton.Size = new System.Drawing.Size(80, 58);
            this.integPrintButton.TabIndex = 41;
            this.integPrintButton.TabStop = false;
            this.integPrintButton.Text = "PRINT";
            this.integPrintButton.Click += new System.EventHandler(this.integPrintButton_Click);
            // 
            // integDeleteButton
            // 
            this.integDeleteButton.AllowFocus = false;
            this.integDeleteButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integDeleteButton.Appearance.Options.UseFont = true;
            this.integDeleteButton.Appearance.Options.UseTextOptions = true;
            this.integDeleteButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.integDeleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("integDeleteButton.ImageOptions.Image")));
            this.integDeleteButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.integDeleteButton.Location = new System.Drawing.Point(0, 60);
            this.integDeleteButton.LookAndFeel.SkinName = "DevExpress Style";
            this.integDeleteButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.integDeleteButton.Name = "integDeleteButton";
            this.integDeleteButton.Size = new System.Drawing.Size(80, 58);
            this.integDeleteButton.TabIndex = 37;
            this.integDeleteButton.TabStop = false;
            this.integDeleteButton.Tag = "0";
            this.integDeleteButton.Text = "DELETE";
            this.integDeleteButton.Click += new System.EventHandler(this.integDeleteButton_Click);
            // 
            // integImportButton
            // 
            this.integImportButton.AllowFocus = false;
            this.integImportButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integImportButton.Appearance.Options.UseFont = true;
            this.integImportButton.Appearance.Options.UseTextOptions = true;
            this.integImportButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.integImportButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("integImportButton.ImageOptions.Image")));
            this.integImportButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.integImportButton.Location = new System.Drawing.Point(0, 0);
            this.integImportButton.LookAndFeel.SkinName = "DevExpress Style";
            this.integImportButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.integImportButton.Name = "integImportButton";
            this.integImportButton.Size = new System.Drawing.Size(80, 58);
            this.integImportButton.TabIndex = 36;
            this.integImportButton.TabStop = false;
            this.integImportButton.Tag = "0";
            this.integImportButton.Text = "IMPORT";
            this.integImportButton.Click += new System.EventHandler(this.integImportButton_Click);
            // 
            // CtrlEditRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CtrlEditRight";
            this.Size = new System.Drawing.Size(908, 568);
            this.Resize += new System.EventHandler(this.CtrlEditRight_Resize);
            this.bgPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.chemicalMenuPanel.ResumeLayout(false);
            this.physicalMenuPanel.ResumeLayout(false);
            this.bomMenuPanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.integMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Ulee.Controls.UlPanel menuPanel;
        private Ulee.Controls.UlPanel viewPanel;
        private DevExpress.XtraEditors.SimpleButton physicalButton;
        private DevExpress.XtraEditors.SimpleButton bomButton;
        private DevExpress.XtraEditors.SimpleButton chemicalButton;
        private Ulee.Controls.UlPanel bomMenuPanel;
        private DevExpress.XtraEditors.SimpleButton bomDeleteButton;
        private DevExpress.XtraEditors.SimpleButton bomImportButton;
        private Ulee.Controls.UlPanel chemicalMenuPanel;
        private DevExpress.XtraEditors.SimpleButton chemicalDeleteButton;
        private DevExpress.XtraEditors.SimpleButton chemicalImportButton;
        private Ulee.Controls.UlPanel physicalMenuPanel;
        private DevExpress.XtraEditors.SimpleButton physicalDeleteButton;
        private DevExpress.XtraEditors.SimpleButton physicalImportButton;
        private DevExpress.XtraEditors.SimpleButton physicalPrintButton;
        private DevExpress.XtraEditors.SimpleButton chemicalPrintButton;
        private DevExpress.XtraEditors.SimpleButton physicalSaveButton;
        private DevExpress.XtraEditors.SimpleButton physicalCancelButton;
        private DevExpress.XtraEditors.SimpleButton chemicalSaveButton;
        private DevExpress.XtraEditors.SimpleButton chemicalCancelButton;
        private DevExpress.XtraEditors.SimpleButton integrationButton;
        private Ulee.Controls.UlPanel integMenuPanel;
        private DevExpress.XtraEditors.SimpleButton integSaveButton;
        private DevExpress.XtraEditors.SimpleButton integCancelButton;
        private DevExpress.XtraEditors.SimpleButton integPrintButton;
        private DevExpress.XtraEditors.SimpleButton integDeleteButton;
        private DevExpress.XtraEditors.SimpleButton integImportButton;
    }
}
