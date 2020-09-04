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
    public partial class CtrlSettingsReport : UlUserControlEng
    {
        private CtrlSettingsRight parent;

        public CtrlSettingsReport(CtrlSettingsRight parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
    }
}
