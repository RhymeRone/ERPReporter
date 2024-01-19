using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.UIAutomation;
using DevExpress.XtraEditors;
using NebimV3Reporter.forms;

namespace NebimV3Reporter
{
    internal static class Program
    {
        public static readonly User Admin = new User("", "");

        public static SqlHelper.SqlLoginInfo CurrentDBInfo =
            new SqlHelper.SqlLoginInfo("reportadmin", "19339a20", "master");

        public static SqlHelper.Data DBContext;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XtraMessageBox.SmartTextWrap = true; // Messagebox yazılarını kısaltır
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeApplication();
        }

        static void InitializeApplication()
        {
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.LoginSuccess += (sender, e) =>
            {
                loginPanel.DialogResult = DialogResult.OK;
            };

            if (loginPanel.ShowDialog() == DialogResult.OK)
                if (new DatabaseList().ShowDialog() == DialogResult.OK)
                    Application.Run(new ReportForm());
        }
    }
}
