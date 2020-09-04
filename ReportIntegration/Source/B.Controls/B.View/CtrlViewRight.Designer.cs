namespace Sgs.ReportIntegration
{
    partial class CtrlViewRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlViewRight));
            this.viewPanel = new Ulee.Controls.UlPanel();
            this.menuPanel = new Ulee.Controls.UlPanel();
            this.printButton = new DevExpress.XtraEditors.SimpleButton();
            this.exportButton = new DevExpress.XtraEditors.SimpleButton();
            this.euButton = new DevExpress.XtraEditors.SimpleButton();
            this.usButton = new DevExpress.XtraEditors.SimpleButton();
            this.openButton = new DevExpress.XtraEditors.SimpleButton();
            this.bgPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.viewPanel);
            this.bgPanel.Controls.Add(this.menuPanel);
            this.bgPanel.Size = new System.Drawing.Size(908, 568);
            // 
            // viewPanel
            // 
            this.viewPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewPanel.Size = new System.Drawing.Size(820, 568);
            this.viewPanel.Spacing = 0;
            this.viewPanel.TabIndex = 11;
            this.viewPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Silver;
            this.menuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.menuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.menuPanel.Controls.Add(this.openButton);
            this.menuPanel.Controls.Add(this.euButton);
            this.menuPanel.Controls.Add(this.usButton);
            this.menuPanel.Controls.Add(this.printButton);
            this.menuPanel.Controls.Add(this.exportButton);
            this.menuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.InnerColor2 = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(824, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.OuterColor2 = System.Drawing.Color.White;
            this.menuPanel.Size = new System.Drawing.Size(84, 568);
            this.menuPanel.Spacing = 0;
            this.menuPanel.TabIndex = 10;
            this.menuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.menuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // printButton
            // 
            this.printButton.AllowFocus = false;
            this.printButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Appearance.Options.UseBorderColor = true;
            this.printButton.Appearance.Options.UseFont = true;
            this.printButton.Appearance.Options.UseTextOptions = true;
            this.printButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.printButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("printButton.ImageOptions.Image")));
            this.printButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.printButton.Location = new System.Drawing.Point(2, 448);
            this.printButton.LookAndFeel.SkinName = "DevExpress Style";
            this.printButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(80, 58);
            this.printButton.TabIndex = 33;
            this.printButton.TabStop = false;
            this.printButton.Text = "PRINT";
            // 
            // exportButton
            // 
            this.exportButton.AllowFocus = false;
            this.exportButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Appearance.Options.UseBorderColor = true;
            this.exportButton.Appearance.Options.UseFont = true;
            this.exportButton.Appearance.Options.UseTextOptions = true;
            this.exportButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.exportButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exportButton.ImageOptions.Image")));
            this.exportButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.exportButton.Location = new System.Drawing.Point(2, 508);
            this.exportButton.LookAndFeel.SkinName = "DevExpress Style";
            this.exportButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(80, 58);
            this.exportButton.TabIndex = 32;
            this.exportButton.TabStop = false;
            this.exportButton.Text = "EXPORT";
            // 
            // euButton
            // 
            this.euButton.AllowFocus = false;
            this.euButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euButton.Appearance.Options.UseFont = true;
            this.euButton.Appearance.Options.UseTextOptions = true;
            this.euButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.euButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("euButton.ImageOptions.Image")));
            this.euButton.ImageOptions.ImageToTextIndent = 0;
            this.euButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.euButton.Location = new System.Drawing.Point(2, 62);
            this.euButton.LookAndFeel.SkinName = "DevExpress Style";
            this.euButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.euButton.Name = "euButton";
            this.euButton.Size = new System.Drawing.Size(80, 58);
            this.euButton.TabIndex = 37;
            this.euButton.TabStop = false;
            this.euButton.Text = "EU";
            // 
            // usButton
            // 
            this.usButton.AllowFocus = false;
            this.usButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usButton.Appearance.Options.UseFont = true;
            this.usButton.Appearance.Options.UseTextOptions = true;
            this.usButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.usButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("usButton.ImageOptions.Image")));
            this.usButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.usButton.Location = new System.Drawing.Point(2, 2);
            this.usButton.LookAndFeel.SkinName = "DevExpress Style";
            this.usButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.usButton.Name = "usButton";
            this.usButton.Size = new System.Drawing.Size(80, 58);
            this.usButton.TabIndex = 36;
            this.usButton.TabStop = false;
            this.usButton.Text = "US";
            // 
            // openButton
            // 
            this.openButton.AllowFocus = false;
            this.openButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Appearance.Options.UseBorderColor = true;
            this.openButton.Appearance.Options.UseFont = true;
            this.openButton.Appearance.Options.UseTextOptions = true;
            this.openButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.openButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("openButton.ImageOptions.Image")));
            this.openButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.openButton.Location = new System.Drawing.Point(2, 388);
            this.openButton.LookAndFeel.SkinName = "DevExpress Style";
            this.openButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(80, 58);
            this.openButton.TabIndex = 37;
            this.openButton.TabStop = false;
            this.openButton.Text = "OPEN";
            // 
            // CtrlViewRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlViewRight";
            this.Size = new System.Drawing.Size(908, 568);
            this.Load += new System.EventHandler(this.CtrlViewRight_Load);
            this.Enter += new System.EventHandler(this.CtrlViewRight_Enter);
            this.Leave += new System.EventHandler(this.CtrlViewRight_Leave);
            this.Resize += new System.EventHandler(this.CtrlViewRight_Resize);
            this.bgPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel viewPanel;
        private Ulee.Controls.UlPanel menuPanel;
        private DevExpress.XtraEditors.SimpleButton printButton;
        private DevExpress.XtraEditors.SimpleButton exportButton;
        private DevExpress.XtraEditors.SimpleButton euButton;
        private DevExpress.XtraEditors.SimpleButton usButton;
        private DevExpress.XtraEditors.SimpleButton openButton;
    }
}
