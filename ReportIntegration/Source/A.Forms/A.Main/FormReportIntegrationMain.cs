using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ulee.Controls;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public partial class FormReportIntegrationMain : UlFormEng
    {
        private const int csInvalidTime = 250;
        private const string csDateFormat = "yyyy-MM-dd";
        private const string csTimeFormat = "HH:mm:ss";

        private InvalidThread invalidThread;

        public FormReportIntegrationMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            invalidThread = null;

            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlEditRight(), editButton);
            DefMenu.Add(new CtrlViewRight(), viewButton);
            DefMenu.Add(new CtrlSettingsRight(), settingsButton);
            DefMenu.Add(new CtrlLogRight(), logButton);
            DefMenu.Index = 0;

            AppRes.TotalLog[ELogTag.Note] = "Create application mainform";
            AppRes.DbLog[ELogTag.Note] = $"MS-SQL Server ConnectionString - '{AppRes.DB.ConnectString}'";
        }

        private void FormReportIntegrationMain_Load(object sender, EventArgs e)
        {
            DispCaption();

            AppRes.TotalLog[ELogTag.Note] = "Resume screen invalidation thread";
            invalidThread = new InvalidThread(csInvalidTime);
            invalidThread.InvalidControls += InvalidForm;
            invalidThread.Resume();
        }

        private void FormReportIntegrationMain_Leave(object sender, EventArgs e)
        {
        }

        private void FormReportIntegrationMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Would you like to exit this program?",
                "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormReportIntegrationMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (invalidThread.IsAlive == true)
            {
                invalidThread.Terminate();
                AppRes.TotalLog[ELogTag.Note] = "Terminate screen invalidation thread";
            }

            AppRes.TotalLog[ELogTag.Note] = "Destroy application mainform";
        }

        private void FormReportIntegrationMain_Resize(object sender, EventArgs e)
        {
            if (Width < 1024) Width = 1024;
            if (Height < 640) Height = 640;

            menuPanel.Size = new Size(84, Height - 116);
            viewPanel.Size = new Size(Width - 116, Height - 72);

            exitButton.Top = Height - 176;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void InvalidForm(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(InvalidForm);
                this.BeginInvoke(func, new object[] { sender, e });
            }
            else
            {
                InvalidDateTime();
                InvalidUserControls(DefMenu);
            }
        }

        private void InvalidDateTime()
        {
            string dateTime = DateTime.Now.ToString(csDateFormat + " " + csTimeFormat);

            if (dateTimeStatusLabel.Text != dateTime)
            {
                dateTimeStatusLabel.Text = dateTime;
            }
        }

        private void InvalidUserControls(UlMenu menu)
        {
            if (menu == null) return;

            UlUserControlEng ctrl = menu.ActiveControl as UlUserControlEng;

            ctrl.InvalidControl(this, null);
            InvalidUserControls(ctrl.DefMenu);
        }

        private void DispCaption()
        {
            Text = "Test Report Integration Program Ver " + GetVersion();
        }

        private string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
