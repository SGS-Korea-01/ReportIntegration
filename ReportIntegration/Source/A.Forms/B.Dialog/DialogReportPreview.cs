using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Ulee.Controls;

namespace Sgs.ReportIntegration.Source
{
    public partial class DialogReportPreview : UlFormEng
    {
        public object Source 
        { 
            get { return reportPreview.DocumentSource; }
            set { reportPreview.DocumentSource = value; } 
        }

        public DialogReportPreview()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
        }

        private void DialogReportPreview_Load(object sender, EventArgs e)
        {
        }

        private void DialogReportPreview_Resize(object sender, EventArgs e)
        {
            if (Width < 1024) Width = 1024;
            if (Height < 640) Height = 640;
        }
    }
}
