using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NebimV3Reporter.forms
{
    public partial class LoginPanel : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler LoginSuccess;

        public LoginPanel()
        {
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            versionLabel.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
            if (Program.properties.Remember)
            {
                usernameBox.Text = Program.properties.Username;
                passwordBox.Text = Program.properties.Password;
                rememberCheck.Checked = Program.properties.Remember;
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(AuthenticateUser(usernameBox.Text,passwordBox.Text))
                OnLoginSuccess(sender, e);
        }

        protected bool AuthenticateUser(string username, string password)
        {
            if (username == Program.Admin.Username &&
                password == Program.Admin.Password)
            {
                return true;
            }
            XtraMessageBox.Show("Kullanıcı Adı / Parola Hatalı", "Giriş Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        protected virtual void OnLoginSuccess(object sender, EventArgs e)
        {
            LoginSuccess?.Invoke(this, EventArgs.Empty);
        }

    }
}