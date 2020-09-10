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
        public PhysicalMainDataSet MainSet;

        public PhysicalImageDataSet ImageSet;

        public PhysicalP2DataSet P2Set;

        public PhysicalP3DataSet P3Set;

        public PhysicalP4DataSet P4Set;

        public PhysicalP5DataSet P5Set;

        public List<PhysicalPage2Row> P2Rows;

        public List<PhysicalPage3Row> P3Rows;

        public List<PhysicalPage4Row> P4Rows;

        public List<PhysicalPage5Row> P5Rows;

        public CtrlEditPhysicalEu()
        {
            InitializeComponent();
        }
    }
}
