using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.UIAutomation;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NebimV3Reporter.forms;
using NebimV3Reporter.Properties;

namespace NebimV3Reporter
{
    internal static class Program
    {
        public static string DatabaseListCommand =
            "Select name from sys.databases where name like 'V3%' or name = 'TEST'";
        public static readonly User Admin = new User("", "master");

        public static Settings properties = Settings.Default;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XtraMessageBox.SmartTextWrap = true; // Messagebox yazılarını kısaltır
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Localizer.Active = Localizer.CreateDefaultLocalizer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            InitializeApplication();
        }

        static void InitializeApplication()
        {
            if (Properties.Settings.Default.UpdateAutomatically) CheckUpdate();

            LoginPanel loginPanel = new LoginPanel();
            loginPanel.LoginSuccess += (sender, e) =>
            {
                loginPanel.DialogResult = DialogResult.OK;
                if (loginPanel.rememberCheck.Checked)
                {
                    properties.Username = loginPanel.usernameBox.Text;
                    properties.Password = loginPanel.passwordBox.Text;
                    properties.Remember = loginPanel.rememberCheck.Checked;
                    properties.Save();
                }
                else
                {
                    properties.Username = "";
                    properties.Password = "";
                    properties.Remember = false;
                    properties.Save();
                }
            };

            if (loginPanel.ShowDialog() == DialogResult.OK)
                if (new DatabaseList().ShowDialog() == DialogResult.OK)
                    Application.Run(new MainForm());
        }


        public static void Maintenence()
        {
            XtraMessageBox.Show("Burası Bakım Aşamasında!", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void CheckUpdate()
        { 
            string UpdateInfo = "https://nebimv3reporter.s3.eu-central-1.amazonaws.com/updateinfo.xml";
            AutoUpdater.Start(UpdateInfo);
        }


    }


}
