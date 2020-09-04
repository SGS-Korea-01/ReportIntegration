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
    public partial class CtrlEditPhysicalEu : UlUserControlEng
    {
        private PhysicalMainDataSet dataSet;

        public CtrlEditPhysicalEu(PhysicalMainDataSet set)
        {
            dataSet = set;

            InitializeComponent();
        }
    }
}
