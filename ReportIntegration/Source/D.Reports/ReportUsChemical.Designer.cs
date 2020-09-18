namespace Sgs.ReportIntegration.Source.D.Reports
{
    partial class ReportUsChemical
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.VerticalDetail = new DevExpress.XtraReports.UI.VerticalDetailBand();
            this.VerticalHeader = new DevExpress.XtraReports.UI.VerticalHeaderBand();
            this.VerticalTotal = new DevExpress.XtraReports.UI.VerticalTotalBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.VerticalDetail,
            this.VerticalHeader,
            this.VerticalTotal,
            this.GroupFooter1});
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // VerticalDetail
            // 
            this.VerticalDetail.Name = "VerticalDetail";
            this.VerticalDetail.WidthF = 215.625F;
            // 
            // VerticalHeader
            // 
            this.VerticalHeader.Name = "VerticalHeader";
            this.VerticalHeader.WidthF = 161.4583F;
            // 
            // VerticalTotal
            // 
            this.VerticalTotal.Name = "VerticalTotal";
            this.VerticalTotal.WidthF = 231.25F;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // ReportUsChemical
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.DetailReport});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Version = "20.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.VerticalDetailBand VerticalDetail;
        private DevExpress.XtraReports.UI.VerticalHeaderBand VerticalHeader;
        private DevExpress.XtraReports.UI.VerticalTotalBand VerticalTotal;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
    }
}
