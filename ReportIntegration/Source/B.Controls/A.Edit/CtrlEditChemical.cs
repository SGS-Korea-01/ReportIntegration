using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ulee.Controls;

namespace Sgs.ReportIntegration
{
    public partial class CtrlEditChemical : UlUserControlEng
    {
        private CtrlEditRight parent;

        public CtrlEditChemical(CtrlEditRight parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void CtrlEditChemical_Enter(object sender, EventArgs e)
        {
            parent.SetMenu(1);
        }
    }
}
