namespace Sgs.ReportIntegration.Source
{
    partial class DialogReportPreview
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
            this.reportPreview = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.reportPreview);
            this.bgPanel.Size = new System.Drawing.Size(1008, 601);
            // 
            // reportPreview
            // 
            this.reportPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPreview.IsMetric = true;
            this.reportPreview.Location = new System.Drawing.Point(0, 0);
            this.reportPreview.Name = "reportPreview";
            this.reportPreview.Size = new System.Drawing.Size(1008, 601);
            this.reportPreview.TabIndex = 0;
            // 
            // DialogReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Name = "DialogReportPreview";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.DialogReportPreview_Load);
            this.Resize += new System.EventHandler(this.DialogReportPreview_Resize);
            this.bgPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer reportPreview;
    }
}
