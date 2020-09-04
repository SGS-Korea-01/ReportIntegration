using System;
using System.Threading;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isAlone;
            Mutex mutex = new Mutex(true, @"Global\Sgs.ReportIntegration", out isAlone);

            if (isAlone == true)
            {
                WindowsFormsSettings.ForceDirectXPaint();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                try
                {
                    AppRes.Create();
                    AppRes.TotalLog[ELogTag.Note] = "Start program";
                    Application.Run(new FormReportIntegrationMain());
                }
                catch (Exception e)
                {
                    AppRes.TotalLog[ELogTag.Exception] = e.ToString();
                    MessageBox.Show(e.ToString(), AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    AppRes.TotalLog[ELogTag.Note] = "Stop program";
                    AppRes.Destroy();

                    mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show(
                    "Cannot run this program because of running it already!",
                    "ReportIntegration", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                Application.Exit();
            }
        }
    }
}
