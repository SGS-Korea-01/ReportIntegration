using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;

namespace Sgs.ReportIntegration
{
    public partial class ReportUsChemical : XtraReport
    {
        private StaffDataSet staffSet;

        public ReportUsChemical()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            staffSet = new StaffDataSet(AppRes.DB.Connect, null, null);
        }

        private void Detail_BeforePrint(object sender, PrintEventArgs e)
        {
            DataSet set = (DataSource as BindingSource).DataSource as DataSet;
            string staffNo = Convert.ToString(set.Tables["P1"].Rows[0]["staffno"]);

            if (string.IsNullOrWhiteSpace(staffNo) == false)
            {
                staffSet.StaffNo = staffNo;
                staffSet.Select();
                staffSet.Fetch();

                if (staffSet.Signature != null)
                {
                    signImageBox.ImageSource = new ImageSource(staffSet.Signature);
                    signNameLabel.Text = staffSet.FirstName + " " + staffSet.LastName;
                }
            }
        }

        private void DetailReport_AfterPrint(object sender, EventArgs e)
        {
        }

        private void VerticalDetail_BeforePrint(object sender, PrintEventArgs e)
        {
        }

        private void DetailReport_BeforePrint(object sender, PrintEventArgs e)
        {
            DataSet set = (DataSource as BindingSource).DataSource as DataSet;

            GroupHeader2.Visible = (set.Tables["P2EXTEND"].Rows.Count == 0) ? false : true;
        }
    }
}
