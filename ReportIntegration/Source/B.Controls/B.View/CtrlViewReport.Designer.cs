namespace Sgs.ReportIntegration
{
    partial class CtrlViewReport
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
            this.reportTab = new System.Windows.Forms.TabControl();
            this.bomPage = new System.Windows.Forms.TabPage();
            this.physicalPage = new System.Windows.Forms.TabPage();
            this.chemicalPage = new System.Windows.Forms.TabPage();
            this.integrationPage = new System.Windows.Forms.TabPage();
            this.bgPanel.SuspendLayout();
            this.reportTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.reportTab);
            this.bgPanel.Size = new System.Drawing.Size(820, 568);
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.integrationPage);
            this.reportTab.Controls.Add(this.bomPage);
            this.reportTab.Controls.Add(this.physicalPage);
            this.reportTab.Controls.Add(this.chemicalPage);
            this.reportTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTab.Location = new System.Drawing.Point(0, 0);
            this.reportTab.Margin = new System.Windows.Forms.Padding(4);
            this.reportTab.Name = "reportTab";
            this.reportTab.Padding = new System.Drawing.Point(6, 4);
            this.reportTab.SelectedIndex = 0;
            this.reportTab.Size = new System.Drawing.Size(820, 568);
            this.reportTab.TabIndex = 9;
            // 
            // bomPage
            // 
            this.bomPage.Location = new System.Drawing.Point(4, 26);
            this.bomPage.Margin = new System.Windows.Forms.Padding(2);
            this.bomPage.Name = "bomPage";
            this.bomPage.Padding = new System.Windows.Forms.Padding(2);
            this.bomPage.Size = new System.Drawing.Size(504, 538);
            this.bomPage.TabIndex = 0;
            this.bomPage.Text = "  BOM  ";
            this.bomPage.UseVisualStyleBackColor = true;
            // 
            // physicalPage
            // 
            this.physicalPage.Location = new System.Drawing.Point(4, 26);
            this.physicalPage.Name = "physicalPage";
            this.physicalPage.Size = new System.Drawing.Size(504, 538);
            this.physicalPage.TabIndex = 2;
            this.physicalPage.Text = "  PHYSICAL  ";
            this.physicalPage.UseVisualStyleBackColor = true;
            // 
            // chemicalPage
            // 
            this.chemicalPage.Location = new System.Drawing.Point(4, 26);
            this.chemicalPage.Name = "chemicalPage";
            this.chemicalPage.Size = new System.Drawing.Size(504, 538);
            this.chemicalPage.TabIndex = 3;
            this.chemicalPage.Text = "  CHEMICAL  ";
            this.chemicalPage.UseVisualStyleBackColor = true;
            // 
            // integrationPage
            // 
            this.integrationPage.Location = new System.Drawing.Point(4, 26);
            this.integrationPage.Name = "integrationPage";
            this.integrationPage.Size = new System.Drawing.Size(812, 538);
            this.integrationPage.TabIndex = 4;
            this.integrationPage.Text = "  INTEGRATION  ";
            this.integrationPage.UseVisualStyleBackColor = true;
            // 
            // CtrlViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlViewReport";
            this.Size = new System.Drawing.Size(820, 568);
            this.Resize += new System.EventHandler(this.CtrlViewReport_Resize);
            this.bgPanel.ResumeLayout(false);
            this.reportTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl reportTab;
        private System.Windows.Forms.TabPage bomPage;
        private System.Windows.Forms.TabPage physicalPage;
        private System.Windows.Forms.TabPage chemicalPage;
        private System.Windows.Forms.TabPage integrationPage;
    }
}
