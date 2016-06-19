using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPasswordChanger.Controller;
using RPasswordChanger.Model;
using RPasswordChanger.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Configuration;

namespace RPasswordChanger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeAppConfig();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            
        }
        static void InitializeAppConfig()
        {
            string systemAppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            AppSession.AppDataFolder = Path.Combine(systemAppFolder, "RPasswordChanger");
            if (!Directory.Exists(AppSession.AppDataFolder))
            {
                Directory.CreateDirectory(AppSession.AppDataFolder);
            }

            AppSession.DBFile = Path.Combine(AppSession.AppDataFolder, "Database.sdf");
            new AppDBInit();

            try
            {
                AppSession.Domain = ConfigurationManager.AppSettings["domain"];
                AppSession.Password = ConfigurationManager.AppSettings["password"];
                AppSession.UserName = ConfigurationManager.AppSettings["username"];
                AppSession.ServerIP = ConfigurationManager.AppSettings["server_ip"];
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
