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
    public partial class CtrlEditPhysicalUs : UlUserControlEng
    {
        private PhysicalMainDataSet dataSet;

        public CtrlEditPhysicalUs(PhysicalMainDataSet set)
        {
            dataSet = set;

            InitializeComponent();
        }

        private void physicalTab_Resize(object sender, EventArgs e)
        {
        }

        private void physical6Page_Resize(object sender, EventArgs e)
        {
            imagePanel.Size = new Size(physical6Page.Width - 16, physical6Page.Height - 70);
            imageBox.Size = new Size(imagePanel.Width - 16, imagePanel.Height - 74);
            p6DescPanel.Width = imagePanel.Width - 16;

            p6FileNoPanel.Top = physical6Page.Height - 56;
            p6FileNoPanel.Width = physical6Page.Width - 16;
        }

        private void physicalTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (physicalTab.SelectedIndex)
            {
                case 0:
                    SetPage1();
                    break;

                case 1:
                    SetPage2();
                    break;

                case 2:
                    SetPage3();
                    break;

                case 3:
                    SetPage4();
                    break;

                case 4:
                    SetPage5();
                    break;

                case 5:
                    SetPage6();
                    break;
            }
        }

        private void SetPage1()
        {

        }

        private void SetPage2()
        {

        }

        private void SetPage3()
        {

        }

        private void SetPage4()
        {

        }

        private void SetPage5()
        {

        }

        private void SetPage6()
        {
            imageBox.Image = dataSet.Image;
            p6FileNoPanel.Text = dataSet.FileNo;
        }
    }
}
