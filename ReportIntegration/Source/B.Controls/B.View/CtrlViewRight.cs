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
    public partial class CtrlViewRight : UlUserControlEng
    {
        public CtrlViewRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlViewReport(this), usButton);
            DefMenu.Add(new CtrlViewReport(this), euButton);
            DefMenu.Index = 0;
        }

        private void CtrlViewRight_Load(object sender, EventArgs e)
        {
        }

        private void CtrlViewRight_Leave(object sender, EventArgs e)
        {
        }

        private void CtrlViewRight_Enter(object sender, EventArgs e)
        {
        }

        private void CtrlViewRight_Resize(object sender, EventArgs e)
        {
            viewPanel.Size = new Size(Width - 88, Height);

            menuPanel.Size = new Size(84, Height);
            menuPanel.Left = Width - 84;

            openButton.Top = menuPanel.Size.Height - 180;
            printButton.Top = menuPanel.Size.Height - 120;
            exportButton.Top = menuPanel.Size.Height - 60;
        }
    }
}
