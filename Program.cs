using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UIAutomation;
using DevExpress.XtraEditors;
using NebimV3Reporter.forms;

namespace NebimV3Reporter
{
    internal static class Program
    {
        public static readonly User Admin = new User("Muratkan", "Evkuran123");

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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPanel());
        }
    }
}
