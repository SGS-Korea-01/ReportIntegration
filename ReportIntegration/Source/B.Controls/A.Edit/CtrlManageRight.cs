using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ulee.Controls;

namespace Sgs.ReportIntegration
{
    public partial class CtrlManageRight : UlUserControlEng
    {
        private CtrlManageReport ctrlReport;

        public CtrlManageRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            ctrlReport = new CtrlManageReport(this);
            viewPanel.Controls.Add(ctrlReport);
            viewPanel.Controls[0].Dock = DockStyle.Fill;
        }

        private void CtrlManageRight_Resize(object sender, EventArgs e)
        {
            viewPanel.Size = new Size(Width - 88, Height);

            menuPanel.Size = new Size(84, Height);
            menuPanel.Left = Width - 84;

            addUsButton.Top = menuPanel.Size.Height - 240;
            addEuButton.Top = menuPanel.Size.Height - 180;
            saveButton.Top = menuPanel.Size.Height - 120;
            cancelButton.Top = menuPanel.Size.Height - 60;
        }

        private void addBomButton_Click(object sender, EventArgs e)
        {
            EReportArea area = ((sender as SimpleButton).Tag.ToString() == "0") ? EReportArea.US : EReportArea.EU;

            string fName = OpenBomFile(area);
            if (string.IsNullOrWhiteSpace(fName) == false)
            {
                ctrlReport.LoadBom(area, fName);
            }
        }

        private string OpenBomFile(EReportArea area)
        {
            string fName = "";
            OpenFileDialog dialog = new OpenFileDialog();

            switch (area)
            {
                case EReportArea.US:
                    dialog.InitialDirectory = Path.Combine(AppRes.Settings.BomPath, "AURORA ASTM");
                    break;

                case EReportArea.EU:
                    dialog.InitialDirectory = Path.Combine(AppRes.Settings.BomPath, "AURORA EN");
                    break;
            }

            dialog.DefaultExt = "xls";
            dialog.Filter = "Excel files (*.xls)|*.xls";
            dialog.Multiselect = false;
            dialog.ShowReadOnly = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fName = dialog.FileName;
            }

            return fName;
        }
    }
}
