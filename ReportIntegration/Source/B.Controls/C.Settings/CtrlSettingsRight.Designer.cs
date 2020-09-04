namespace Sgs.ReportIntegration
{
    partial class CtrlSettingsRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlSettingsRight));
            this.viewPanel = new Ulee.Controls.UlPanel();
            this.menuPanel = new Ulee.Controls.UlPanel();
            this.saveButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.euButton = new DevExpress.XtraEditors.SimpleButton();
            this.usButton = new DevExpress.XtraEditors.SimpleButton();
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
            this.menuPanel.Controls.Add(this.saveButton);
            this.menuPanel.Controls.Add(this.cancelButton);
            this.menuPanel.Controls.Add(this.euButton);
            this.menuPanel.Controls.Add(this.usButton);
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
            // saveButton
            // 
            this.saveButton.AllowFocus = false;
            this.saveButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Appearance.Options.UseBorderColor = true;
            this.saveButton.Appearance.Options.UseFont = true;
            this.saveButton.Appearance.Options.UseTextOptions = true;
            this.saveButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.saveButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.ImageOptions.Image")));
            this.saveButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.saveButton.Location = new System.Drawing.Point(2, 448);
            this.saveButton.LookAndFeel.SkinName = "DevExpress Style";
            this.saveButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 58);
            this.saveButton.TabIndex = 33;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "SAVE";
            // 
            // cancelButton
            // 
            this.cancelButton.AllowFocus = false;
            this.cancelButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Appearance.Options.UseBorderColor = true;
            this.cancelButton.Appearance.Options.UseFont = true;
            this.cancelButton.Appearance.Options.UseTextOptions = true;
            this.cancelButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.cancelButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.ImageOptions.Image")));
            this.cancelButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cancelButton.Location = new System.Drawing.Point(2, 508);
            this.cancelButton.LookAndFeel.SkinName = "DevExpress Style";
            this.cancelButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 58);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "CANCEL";
            // 
            // euButton
            // 
            this.euButton.AllowFocus = false;
            this.euButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euButton.Appearance.Options.UseFont = true;
            this.euButton.Appearance.Options.UseTextOptions = true;
            this.euButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.euButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("physicalButton.ImageOptions.Image")));
            this.euButton.ImageOptions.ImageToTextIndent = 0;
            this.euButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.euButton.Location = new System.Drawing.Point(2, 62);
            this.euButton.LookAndFeel.SkinName = "DevExpress Style";
            this.euButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.euButton.Name = "euButton";
            this.euButton.Size = new System.Drawing.Size(80, 58);
            this.euButton.TabIndex = 4;
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
            this.usButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bomButton.ImageOptions.Image")));
            this.usButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.usButton.Location = new System.Drawing.Point(2, 2);
            this.usButton.LookAndFeel.SkinName = "DevExpress Style";
            this.usButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.usButton.Name = "usButton";
            this.usButton.Size = new System.Drawing.Size(80, 58);
            this.usButton.TabIndex = 3;
            this.usButton.TabStop = false;
            this.usButton.Text = "US";
            // 
            // CtrlSettingsRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlSettingsRight";
            this.Size = new System.Drawing.Size(908, 568);
            this.Resize += new System.EventHandler(this.CtrlSettingsRight_Resize);
            this.bgPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel viewPanel;
        private Ulee.Controls.UlPanel menuPanel;
        private DevExpress.XtraEditors.SimpleButton saveButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private DevExpress.XtraEditors.SimpleButton euButton;
        private DevExpress.XtraEditors.SimpleButton usButton;
    }
}
