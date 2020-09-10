using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ulee.Controls;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditRight : UlUserControlEng
    {
        public CtrlEditRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            viewPanel.Controls.Clear();

            menuPanel.Controls.Add(physicalMenuPanel);
            menuPanel.Controls.Add(chemicalMenuPanel);
            menuPanel.Controls.Add(bomMenuPanel);

            physicalMenuPanel.Left = 2;
            physicalMenuPanel.Top = 268;

            chemicalMenuPanel.Left = 2;
            chemicalMenuPanel.Top = 268;

            bomMenuPanel.Left = 2;
            bomMenuPanel.Top = 326;

            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlEditPhysical(this), physicalButton);
            DefMenu.Add(new CtrlEditChemical(this), chemicalButton);
            DefMenu.Add(new CtrlEditBom(this), bomButton);
            DefMenu.Index = 0;
        }

        private void CtrlEditRight_Resize(object sender, EventArgs e)
        {
            viewPanel.Size = new Size(Width - 88, Height);

            menuPanel.Size = new Size(84, Height);
            menuPanel.Left = Width - 84;

            physicalMenuPanel.Top = menuPanel.Size.Height - 300;
            chemicalMenuPanel.Top = menuPanel.Size.Height - 300;
            bomMenuPanel.Top = menuPanel.Size.Height - 242;
        }

        private void physicalImportButton_Click(object sender, EventArgs e)
        {
            (DefMenu.Controls(0) as CtrlEditPhysical).Import();
        }

        private void physicalDeleteButton_Click(object sender, EventArgs e)
        {
            (DefMenu.Controls(0) as CtrlEditPhysical).Delete();
        }

        private void physicalPrintButton_Click(object sender, EventArgs e)
        {
            (DefMenu.Controls(0) as CtrlEditPhysical).Print();
        }

        private void physicalSaveButton_Click(object sender, EventArgs e)
        {
            (DefMenu.Controls(0) as CtrlEditPhysical).Save();
        }

        private void physicalCancelButton_Click(object sender, EventArgs e)
        {
            (DefMenu.Controls(0) as CtrlEditPhysical).Cancel();
        }

        private void chemicalImportButton_Click(object sender, EventArgs e)
        {
            //(DefMenu.Controls(1) as CtrlEditChemical).Import();
        }

        private void bomImportButton_Click(object sender, EventArgs e)
        {
            string fName = OpenBomFile();

            if (string.IsNullOrWhiteSpace(fName) == false)
            {
                EReportArea area = EReportArea.None;
                string dirName = Path.GetDirectoryName(fName);

                if (dirName.EndsWith("AURORA ASTM") == true) area = EReportArea.US;
                else if (dirName.EndsWith("AURORA EN") == true) area = EReportArea.EU;

                if (area != EReportArea.None)
                {
                    (DefMenu.Controls(2) as CtrlEditBom).Import(area, fName);
                }
            }
        }

        public void SetMenu(int index)
        {
            bomMenuPanel.Visible = false;
            physicalMenuPanel.Visible = false;
            chemicalMenuPanel.Visible = false;

            switch (index)
            {
                // Physical
                case 0:
                    physicalMenuPanel.Visible = true;
                    break;

                // Chemical
                case 1:
                    chemicalMenuPanel.Visible = true;
                    break;

                // BOM
                case 2:
                    bomMenuPanel.Visible = true;
                    break;
            }
        }

        private string OpenBomFile()
        {
            string fName = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = AppRes.Settings.BomPath;
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
