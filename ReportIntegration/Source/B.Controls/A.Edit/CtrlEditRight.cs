﻿using System;
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
            bomMenuPanel.Left = 2;
            bomMenuPanel.Top = 326;

            physicalMenuPanel.Left = 2;
            physicalMenuPanel.Top = 326;

            chemicalMenuPanel.Left = 2;
            chemicalMenuPanel.Top = 326;

            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlEditBom(this), bomButton);
            DefMenu.Add(new CtrlEditPhysical(this), physicalButton);
            DefMenu.Add(new CtrlEditChemical(this), chemicalButton);
            DefMenu.Index = 0;
        }

        private void CtrlEditRight_Resize(object sender, EventArgs e)
        {
            viewPanel.Size = new Size(Width - 88, Height);

            menuPanel.Size = new Size(84, Height);
            menuPanel.Left = Width - 84;

            bomMenuPanel.Top = menuPanel.Size.Height - 242;
            physicalMenuPanel.Top = menuPanel.Size.Height - 242;
            chemicalMenuPanel.Top = menuPanel.Size.Height - 242;
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
                    (DefMenu.Controls(0) as CtrlEditBom).Import(area, fName);
                }
            }
        }

        private void physicalImportButton_Click(object sender, EventArgs e)
        {
            (DefMenu.Controls(1) as CtrlEditPhysical).Import();
        }

        private void chemicalImportButton_Click(object sender, EventArgs e)
        {
            //(DefMenu.Controls(1) as CtrlEditChemical).Import();
        }

        public void SetMenu(int index)
        {
            bomMenuPanel.Visible = false;
            physicalMenuPanel.Visible = false;
            chemicalMenuPanel.Visible = false;

            switch (index)
            {
                // BOM
                case 0:
                    bomMenuPanel.Visible = true;
                    break;

                // Physical
                case 1:
                    physicalMenuPanel.Visible = true;
                    break;

                // Chemical
                case 2:
                    chemicalMenuPanel.Visible = true;
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