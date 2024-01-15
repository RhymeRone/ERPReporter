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
            if (usernameBox.Text == Program.Admin.Username &&
                passwordBox.Text == Program.Admin.Password)
            {
                Application.Run(new DatabaseList());
            }
            else XtraMessageBox.Show("Kullanıcı Adı / Parola Hatalı","Giriş Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}