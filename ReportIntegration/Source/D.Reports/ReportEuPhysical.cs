using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraReports.UI;

namespace Sgs.ReportIntegration
{
    public partial class ReportEuPhysical : XtraReport
    {
        private StaffDataSet staffSet;

        public ReportEuPhysical()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            staffSet = new StaffDataSet(AppRes.DB.Connect, null, null);
        }

        private void Detail1_BeforePrint(object sender, PrintEventArgs e)
        {
            DataRow row = ((sender as XRControl).Report.GetCurrentRow() as DataRowView).Row;
            bool line = Convert.ToBoolean(row["line"]);

            if (line == true)
            {
                p2TableCell1.Borders = BorderSide.All;
                p2TableCell2.Borders = BorderSide.All;
            }
            else
            {
                p2TableCell1.Borders = BorderSide.Top | BorderSide.Left | BorderSide.Right;
                p2TableCell2.Borders = BorderSide.Top | BorderSide.Left | BorderSide.Right;
            }
        }

        private void DetailReport_BeforePrint(object sender, PrintEventArgs e)
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
    }
}
