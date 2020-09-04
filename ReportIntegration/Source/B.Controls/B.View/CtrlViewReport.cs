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
    public partial class CtrlViewReport : UlUserControlEng
    {
        private CtrlViewRight parent;

        public CtrlViewReport(CtrlViewRight parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void CtrlViewReport_Resize(object sender, EventArgs e)
        {
            reportTab.Size = new Size(Width - 310, Height);
        }
    }
}
