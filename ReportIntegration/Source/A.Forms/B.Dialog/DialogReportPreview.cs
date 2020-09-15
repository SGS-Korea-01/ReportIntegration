using System;

using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.UI;

namespace Sgs.ReportIntegration
{
    public partial class DialogReportPreview : XtraForm
    {
        public object Source
        {
            get { return docPreview.DocumentSource; }
            set { docPreview.DocumentSource = value; }
        }

        public DialogReportPreview()
        {
            InitializeComponent();
        }

        private void ReportWork_Load(object sender, EventArgs e)
        {
        }

        private void nBIofficeList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //ReportForm rpt = new ReportForm();
            //rpt.CreateDocument();
            //ReportPrintTool tool = new ReportPrintTool(rpt);
            //documentViewer1.DocumentSource = rpt;
        }

    }
}