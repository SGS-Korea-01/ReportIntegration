using DevExpress.LookAndFeel.Design;
using System.Data;
using System.IO;
using Ulee.Utils;

namespace Sgs.ReportIntegration
{
    public enum ELogType { Total, Database }

    public static class AppRes
    {
        private const string csIniFName = @"..\..\Config\Sgs.ReportIntegration.ini";

        public const string csDateFormat = "yyyy-MM-dd";

        public const string csDateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";

        public const string csDateTimeFormatSec = "yyyy-MM-dd HH:mm:ss";

        public const string Caption = "SGS";

        public static bool Busy { get; set; }

        public static UlIniFile Ini { get; private set; }

        public static UlLogger TotalLog { get; private set; }

        public static UlLogger DbLog { get; private set; }

        public static AppDatabase DB { get; private set; }

        public static AppSettings Settings { get; private set; }

        public static void Create()
        {
            Busy = false;

            Ini = new UlIniFile(csIniFName);

            TotalLog = new UlLogger();
            TotalLog.Path = Path.GetFullPath(Ini.GetString("Log", "TotalPath"));
            TotalLog.FName = Ini.GetString("Log", "TotalFileName");

            DbLog = new UlLogger();
            DbLog.Path = Path.GetFullPath(Ini.GetString("Log", "DatabasePath"));
            DbLog.FName = Ini.GetString("Log", "DatabaseFileName");

            string connectString = Ini.GetString("Database", "ConnectString");
            DB = new AppDatabase(connectString);
            
            if (string.IsNullOrWhiteSpace(connectString) == true)
            {
                DB.DataSource = Ini.GetString("Database", "DataSource");
                DB.InitialCatalog = Ini.GetString("Database", "InitialCatalog");
                DB.UserID = Ini.GetString("Database", "UserID");
                DB.Password = Ini.GetString("Database", "Password");
            }
            DB.Open();

            Settings = new AppSettings();
            TotalLog[ELogTag.Note] = $"Create application resource";
        }

        public static void Destroy()
        {
            if (DB.Connect.State == ConnectionState.Open)
            {
                DB.Close();
            }

            TotalLog[ELogTag.Note] = $"Destroy application resource";
        }
    }

    public class AppSettings
    {
        public string BomPath { get; set; }

        public string FinalPath { get; set; }

        public AppSettings()
        {
            BomPath = AppRes.Ini.GetString("Settings", "BomPath");
            FinalPath = AppRes.Ini.GetString("Settings", "FinalPath");
        }
    }
}
