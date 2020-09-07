namespace Sgs.ReportIntegration
{
    partial class FormReportIntegrationMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportIntegrationMain));
            this.mainStatus = new System.Windows.Forms.StatusStrip();
            this.dateTimeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.companyStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.descStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerMeterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacityCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConvertorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prtOptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etcOptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPanel = new Ulee.Controls.UlPanel();
            this.menuPanel = new Ulee.Controls.UlPanel();
            this.editButton = new DevExpress.XtraEditors.SimpleButton();
            this.settingsButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.logButton = new DevExpress.XtraEditors.SimpleButton();
            this.authorLogoPanel = new Ulee.Controls.UlPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgPanel.SuspendLayout();
            this.mainStatus.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.authorLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.authorLogoPanel);
            this.bgPanel.Controls.Add(this.menuPanel);
            this.bgPanel.Controls.Add(this.viewPanel);
            this.bgPanel.Size = new System.Drawing.Size(1008, 577);
            // 
            // mainStatus
            // 
            this.mainStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateTimeStatusLabel,
            this.companyStatusLabel,
            this.descStatusLabel});
            this.mainStatus.Location = new System.Drawing.Point(0, 577);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(1008, 24);
            this.mainStatus.TabIndex = 3;
            // 
            // dateTimeStatusLabel
            // 
            this.dateTimeStatusLabel.AutoSize = false;
            this.dateTimeStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.dateTimeStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.dateTimeStatusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStatusLabel.Name = "dateTimeStatusLabel";
            this.dateTimeStatusLabel.Size = new System.Drawing.Size(138, 19);
            this.dateTimeStatusLabel.Text = "2018-05-29 10:50:00";
            // 
            // companyStatusLabel
            // 
            this.companyStatusLabel.AutoSize = false;
            this.companyStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.companyStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.companyStatusLabel.Name = "companyStatusLabel";
            this.companyStatusLabel.Size = new System.Drawing.Size(142, 19);
            this.companyStatusLabel.Text = "SGS Co., Ltd.";
            // 
            // descStatusLabel
            // 
            this.descStatusLabel.AutoSize = false;
            this.descStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.descStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.descStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.descStatusLabel.Name = "descStatusLabel";
            this.descStatusLabel.Size = new System.Drawing.Size(713, 19);
            this.descStatusLabel.Spring = true;
            this.descStatusLabel.Text = " When you need to be sure";
            this.descStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.allToolStripMenuItem.Tag = "0";
            this.allToolStripMenuItem.Text = "All";
            // 
            // powerMeterToolStripMenuItem
            // 
            this.powerMeterToolStripMenuItem.Name = "powerMeterToolStripMenuItem";
            this.powerMeterToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.powerMeterToolStripMenuItem.Tag = "1";
            this.powerMeterToolStripMenuItem.Text = "Power Meter";
            // 
            // recorderToolStripMenuItem
            // 
            this.recorderToolStripMenuItem.Name = "recorderToolStripMenuItem";
            this.recorderToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.recorderToolStripMenuItem.Tag = "2";
            this.recorderToolStripMenuItem.Text = "Recorder";
            // 
            // controllerToolStripMenuItem
            // 
            this.controllerToolStripMenuItem.Name = "controllerToolStripMenuItem";
            this.controllerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.controllerToolStripMenuItem.Tag = "3";
            this.controllerToolStripMenuItem.Text = "Controller";
            // 
            // plcToolStripMenuItem
            // 
            this.plcToolStripMenuItem.Name = "plcToolStripMenuItem";
            this.plcToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.plcToolStripMenuItem.Tag = "4";
            this.plcToolStripMenuItem.Text = "PLC";
            // 
            // capacityCalculatorToolStripMenuItem
            // 
            this.capacityCalculatorToolStripMenuItem.Name = "capacityCalculatorToolStripMenuItem";
            this.capacityCalculatorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.capacityCalculatorToolStripMenuItem.Text = "Capacity Calculator";
            // 
            // windowCalculatorToolStripMenuItem
            // 
            this.windowCalculatorToolStripMenuItem.Name = "windowCalculatorToolStripMenuItem";
            this.windowCalculatorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.windowCalculatorToolStripMenuItem.Text = "Window Calculator";
            // 
            // unitConvertorToolStripMenuItem
            // 
            this.unitConvertorToolStripMenuItem.Name = "unitConvertorToolStripMenuItem";
            this.unitConvertorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.unitConvertorToolStripMenuItem.Text = "Unit Convertor";
            // 
            // prtOptionMenuItem
            // 
            this.prtOptionMenuItem.Name = "prtOptionMenuItem";
            this.prtOptionMenuItem.Size = new System.Drawing.Size(116, 22);
            this.prtOptionMenuItem.Text = "Printing";
            // 
            // etcOptionMenuItem
            // 
            this.etcOptionMenuItem.Name = "etcOptionMenuItem";
            this.etcOptionMenuItem.Size = new System.Drawing.Size(116, 22);
            this.etcOptionMenuItem.Text = "Etc";
            // 
            // viewPanel
            // 
            this.viewPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewPanel.Location = new System.Drawing.Point(94, 6);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewPanel.Size = new System.Drawing.Size(908, 568);
            this.viewPanel.Spacing = 0;
            this.viewPanel.TabIndex = 0;
            this.viewPanel.TabStop = true;
            this.viewPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Silver;
            this.menuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.menuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.menuPanel.Controls.Add(this.editButton);
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.logButton);
            this.menuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.InnerColor2 = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(6, 50);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.OuterColor2 = System.Drawing.Color.White;
            this.menuPanel.Size = new System.Drawing.Size(84, 524);
            this.menuPanel.Spacing = 0;
            this.menuPanel.TabIndex = 7;
            this.menuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.menuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // editButton
            // 
            this.editButton.AllowFocus = false;
            this.editButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Appearance.Options.UseFont = true;
            this.editButton.Appearance.Options.UseTextOptions = true;
            this.editButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.editButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.AppearanceDisabled.Options.UseFont = true;
            this.editButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.AppearanceHovered.Options.UseFont = true;
            this.editButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.AppearancePressed.Options.UseFont = true;
            this.editButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editButton.ImageOptions.Image")));
            this.editButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.editButton.Location = new System.Drawing.Point(2, 2);
            this.editButton.LookAndFeel.SkinName = "DevExpress Style";
            this.editButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 58);
            this.editButton.TabIndex = 3;
            this.editButton.TabStop = false;
            this.editButton.Text = "REPORT";
            // 
            // settingsButton
            // 
            this.settingsButton.AllowFocus = false;
            this.settingsButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Appearance.Options.UseFont = true;
            this.settingsButton.Appearance.Options.UseTextOptions = true;
            this.settingsButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.settingsButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.AppearanceDisabled.Options.UseFont = true;
            this.settingsButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.AppearanceHovered.Options.UseFont = true;
            this.settingsButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.AppearancePressed.Options.UseFont = true;
            this.settingsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.ImageOptions.Image")));
            this.settingsButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.settingsButton.Location = new System.Drawing.Point(2, 62);
            this.settingsButton.LookAndFeel.SkinName = "DevExpress Style";
            this.settingsButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(80, 58);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.TabStop = false;
            this.settingsButton.Text = "SETTINGS";
            // 
            // exitButton
            // 
            this.exitButton.AllowFocus = false;
            this.exitButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Appearance.Options.UseFont = true;
            this.exitButton.Appearance.Options.UseTextOptions = true;
            this.exitButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.exitButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.AppearanceDisabled.Options.UseFont = true;
            this.exitButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.AppearanceHovered.Options.UseFont = true;
            this.exitButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.AppearancePressed.Options.UseFont = true;
            this.exitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.ImageOptions.Image")));
            this.exitButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(2, 464);
            this.exitButton.LookAndFeel.SkinName = "DevExpress Style";
            this.exitButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 58);
            this.exitButton.TabIndex = 5;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "EXIT";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logButton
            // 
            this.logButton.AllowFocus = false;
            this.logButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.Appearance.Options.UseFont = true;
            this.logButton.Appearance.Options.UseTextOptions = true;
            this.logButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.logButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.AppearanceDisabled.Options.UseFont = true;
            this.logButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.AppearanceHovered.Options.UseFont = true;
            this.logButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.AppearancePressed.Options.UseFont = true;
            this.logButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logButton.ImageOptions.Image")));
            this.logButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.logButton.Location = new System.Drawing.Point(2, 122);
            this.logButton.LookAndFeel.SkinName = "DevExpress Style";
            this.logButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(80, 58);
            this.logButton.TabIndex = 4;
            this.logButton.TabStop = false;
            this.logButton.Text = "LOG";
            // 
            // authorLogoPanel
            // 
            this.authorLogoPanel.BackColor = System.Drawing.Color.Black;
            this.authorLogoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("authorLogoPanel.BackgroundImage")));
            this.authorLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.authorLogoPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.authorLogoPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.authorLogoPanel.Controls.Add(this.pictureBox1);
            this.authorLogoPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.authorLogoPanel.InnerColor2 = System.Drawing.Color.White;
            this.authorLogoPanel.Location = new System.Drawing.Point(6, 6);
            this.authorLogoPanel.Name = "authorLogoPanel";
            this.authorLogoPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.authorLogoPanel.OuterColor2 = System.Drawing.Color.White;
            this.authorLogoPanel.Size = new System.Drawing.Size(84, 40);
            this.authorLogoPanel.Spacing = 0;
            this.authorLogoPanel.TabIndex = 9;
            this.authorLogoPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.authorLogoPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormReportIntegrationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.mainStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReportIntegrationMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportIntegrationMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReportIntegrationMain_FormClosed);
            this.Load += new System.EventHandler(this.FormReportIntegrationMain_Load);
            this.Leave += new System.EventHandler(this.FormReportIntegrationMain_Leave);
            this.Resize += new System.EventHandler(this.FormReportIntegrationMain_Resize);
            this.Controls.SetChildIndex(this.mainStatus, 0);
            this.Controls.SetChildIndex(this.bgPanel, 0);
            this.bgPanel.ResumeLayout(false);
            this.mainStatus.ResumeLayout(false);
            this.mainStatus.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.authorLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatus;
        private System.Windows.Forms.ToolStripStatusLabel dateTimeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel companyStatusLabel;
        private Ulee.Controls.UlPanel viewPanel;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerMeterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capacityCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitConvertorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prtOptionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etcOptionMenuItem;
        private Ulee.Controls.UlPanel menuPanel;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton settingsButton;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton logButton;
        private Ulee.Controls.UlPanel authorLogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel descStatusLabel;
    }
}

