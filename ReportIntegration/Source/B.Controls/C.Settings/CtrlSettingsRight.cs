using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Ulee.Controls;

namespace Sgs.ReportIntegration
{
    public partial class CtrlSettingsRight : UlUserControlEng
    {
        public CtrlSettingsRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlSettingsReport(this), usButton);
            DefMenu.Add(new CtrlSettingsReport(this), euButton);
            DefMenu.Index = 0;
        }

        private void CtrlSettingsRight_Resize(object sender, EventArgs e)
        {
            viewPanel.Size = new Size(Width - 88, Height);

            menuPanel.Size = new Size(84, Height);
            menuPanel.Left = Width - 84;

            saveButton.Top = menuPanel.Size.Height - 120;
            cancelButton.Top = menuPanel.Size.Height - 60;
        }
    }
}
