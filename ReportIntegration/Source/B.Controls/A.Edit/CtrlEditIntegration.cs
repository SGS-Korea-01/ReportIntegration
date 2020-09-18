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
    public partial class CtrlEditIntegration : UlUserControlEng
    {
        private CtrlEditRight parent;

        public CtrlEditIntegration(CtrlEditRight parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void CtrlEditIntegration_Load(object sender, EventArgs e)
        {
            parent.SetMenu(3);
        }
    }
}
