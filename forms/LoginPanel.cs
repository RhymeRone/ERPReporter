using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void xtraUserControl1_Load(object sender, EventArgs e)
        {

        }


        private void LoginPanel_Load(object sender, EventArgs e)
        {

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