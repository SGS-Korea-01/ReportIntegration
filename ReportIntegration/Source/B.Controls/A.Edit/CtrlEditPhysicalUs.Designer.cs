namespace Sgs.ReportIntegration
{
    partial class CtrlEditPhysicalUs
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
            this.physicalTab = new System.Windows.Forms.TabControl();
            this.physical1Page = new System.Windows.Forms.TabPage();
            this.physical2Page = new System.Windows.Forms.TabPage();
            this.physical3Page = new System.Windows.Forms.TabPage();
            this.physical4Page = new System.Windows.Forms.TabPage();
            this.physical5Page = new System.Windows.Forms.TabPage();
            this.physical6Page = new System.Windows.Forms.TabPage();
            this.imagePanel = new Ulee.Controls.UlPanel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.p6FileNoPanel = new Ulee.Controls.UlPanel();
            this.p6DescPanel = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            this.physicalTab.SuspendLayout();
            this.physical6Page.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.physicalTab);
            this.bgPanel.Size = new System.Drawing.Size(556, 568);
            // 
            // physicalTab
            // 
            this.physicalTab.Controls.Add(this.physical1Page);
            this.physicalTab.Controls.Add(this.physical2Page);
            this.physicalTab.Controls.Add(this.physical3Page);
            this.physicalTab.Controls.Add(this.physical4Page);
            this.physicalTab.Controls.Add(this.physical5Page);
            this.physicalTab.Controls.Add(this.physical6Page);
            this.physicalTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physicalTab.Location = new System.Drawing.Point(0, 0);
            this.physicalTab.Margin = new System.Windows.Forms.Padding(0);
            this.physicalTab.Name = "physicalTab";
            this.physicalTab.Padding = new System.Drawing.Point(0, 0);
            this.physicalTab.SelectedIndex = 0;
            this.physicalTab.Size = new System.Drawing.Size(556, 568);
            this.physicalTab.TabIndex = 91;
            this.physicalTab.SelectedIndexChanged += new System.EventHandler(this.physicalTab_SelectedIndexChanged);
            this.physicalTab.Resize += new System.EventHandler(this.physicalTab_Resize);
            // 
            // physical1Page
            // 
            this.physical1Page.AutoScroll = true;
            this.physical1Page.BackColor = System.Drawing.Color.Transparent;
            this.physical1Page.Location = new System.Drawing.Point(4, 24);
            this.physical1Page.Margin = new System.Windows.Forms.Padding(0);
            this.physical1Page.Name = "physical1Page";
            this.physical1Page.Size = new System.Drawing.Size(548, 540);
            this.physical1Page.TabIndex = 0;
            this.physical1Page.Tag = "0";
            this.physical1Page.Text = "  Page 1  ";
            this.physical1Page.UseVisualStyleBackColor = true;
            // 
            // physical2Page
            // 
            this.physical2Page.AutoScroll = true;
            this.physical2Page.Location = new System.Drawing.Point(4, 24);
            this.physical2Page.Margin = new System.Windows.Forms.Padding(0);
            this.physical2Page.Name = "physical2Page";
            this.physical2Page.Size = new System.Drawing.Size(548, 540);
            this.physical2Page.TabIndex = 1;
            this.physical2Page.Tag = "1";
            this.physical2Page.Text = "  Page 2  ";
            this.physical2Page.UseVisualStyleBackColor = true;
            // 
            // physical3Page
            // 
            this.physical3Page.AutoScroll = true;
            this.physical3Page.Location = new System.Drawing.Point(4, 24);
            this.physical3Page.Margin = new System.Windows.Forms.Padding(0);
            this.physical3Page.Name = "physical3Page";
            this.physical3Page.Size = new System.Drawing.Size(548, 540);
            this.physical3Page.TabIndex = 2;
            this.physical3Page.Tag = "2";
            this.physical3Page.Text = "  Page 3  ";
            this.physical3Page.UseVisualStyleBackColor = true;
            // 
            // physical4Page
            // 
            this.physical4Page.AutoScroll = true;
            this.physical4Page.Location = new System.Drawing.Point(4, 24);
            this.physical4Page.Margin = new System.Windows.Forms.Padding(0);
            this.physical4Page.Name = "physical4Page";
            this.physical4Page.Size = new System.Drawing.Size(548, 540);
            this.physical4Page.TabIndex = 3;
            this.physical4Page.Tag = "3";
            this.physical4Page.Text = "  Page 4  ";
            this.physical4Page.UseVisualStyleBackColor = true;
            // 
            // physical5Page
            // 
            this.physical5Page.AutoScroll = true;
            this.physical5Page.Location = new System.Drawing.Point(4, 24);
            this.physical5Page.Margin = new System.Windows.Forms.Padding(0);
            this.physical5Page.Name = "physical5Page";
            this.physical5Page.Size = new System.Drawing.Size(548, 540);
            this.physical5Page.TabIndex = 4;
            this.physical5Page.Tag = "4";
            this.physical5Page.Text = "  Page 5  ";
            this.physical5Page.UseVisualStyleBackColor = true;
            // 
            // physical6Page
            // 
            this.physical6Page.Controls.Add(this.p6FileNoPanel);
            this.physical6Page.Controls.Add(this.imagePanel);
            this.physical6Page.Location = new System.Drawing.Point(4, 24);
            this.physical6Page.Name = "physical6Page";
            this.physical6Page.Padding = new System.Windows.Forms.Padding(3);
            this.physical6Page.Size = new System.Drawing.Size(548, 540);
            this.physical6Page.TabIndex = 5;
            this.physical6Page.Tag = "5";
            this.physical6Page.Text = "  Page 6  ";
            this.physical6Page.UseVisualStyleBackColor = true;
            this.physical6Page.Resize += new System.EventHandler(this.physical6Page_Resize);
            // 
            // imagePanel
            // 
            this.imagePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.imagePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Controls.Add(this.p6DescPanel);
            this.imagePanel.Controls.Add(this.imageBox);
            this.imagePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.imagePanel.InnerColor2 = System.Drawing.Color.White;
            this.imagePanel.Location = new System.Drawing.Point(8, 8);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.imagePanel.OuterColor2 = System.Drawing.Color.White;
            this.imagePanel.Size = new System.Drawing.Size(532, 470);
            this.imagePanel.Spacing = 0;
            this.imagePanel.TabIndex = 3;
            this.imagePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.imagePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox.Location = new System.Drawing.Point(8, 64);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(516, 396);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // p6FileNoPanel
            // 
            this.p6FileNoPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.p6FileNoPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.p6FileNoPanel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p6FileNoPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.p6FileNoPanel.InnerColor2 = System.Drawing.Color.White;
            this.p6FileNoPanel.Location = new System.Drawing.Point(8, 484);
            this.p6FileNoPanel.Name = "p6FileNoPanel";
            this.p6FileNoPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.p6FileNoPanel.OuterColor2 = System.Drawing.Color.White;
            this.p6FileNoPanel.Size = new System.Drawing.Size(532, 48);
            this.p6FileNoPanel.Spacing = 0;
            this.p6FileNoPanel.TabIndex = 4;
            this.p6FileNoPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.p6FileNoPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // p6DescPanel
            // 
            this.p6DescPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.p6DescPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.p6DescPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p6DescPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.p6DescPanel.InnerColor2 = System.Drawing.Color.White;
            this.p6DescPanel.Location = new System.Drawing.Point(8, 8);
            this.p6DescPanel.Name = "p6DescPanel";
            this.p6DescPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.p6DescPanel.OuterColor2 = System.Drawing.Color.White;
            this.p6DescPanel.Size = new System.Drawing.Size(516, 48);
            this.p6DescPanel.Spacing = 0;
            this.p6DescPanel.TabIndex = 5;
            this.p6DescPanel.Text = "Picture of Sample as Received :";
            this.p6DescPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.p6DescPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // CtrlEditPhysicalUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CtrlEditPhysicalUs";
            this.Size = new System.Drawing.Size(556, 568);
            this.bgPanel.ResumeLayout(false);
            this.physicalTab.ResumeLayout(false);
            this.physical6Page.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl physicalTab;
        private System.Windows.Forms.TabPage physical1Page;
        private System.Windows.Forms.TabPage physical2Page;
        private System.Windows.Forms.TabPage physical3Page;
        private System.Windows.Forms.TabPage physical4Page;
        private System.Windows.Forms.TabPage physical5Page;
        private System.Windows.Forms.TabPage physical6Page;
        private Ulee.Controls.UlPanel p6FileNoPanel;
        private Ulee.Controls.UlPanel imagePanel;
        private System.Windows.Forms.PictureBox imageBox;
        private Ulee.Controls.UlPanel p6DescPanel;
    }
}
