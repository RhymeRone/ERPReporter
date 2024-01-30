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
    public partial class DatabaseSettings : DevExpress.XtraEditors.XtraForm
    {
        public DatabaseSettings()
        {
            InitializeComponent();
            loadSettings();
        }

        private void loadSettings()
        {
            sqlConnectBox.Text = Program.properties.sqlAddress;
            usernameBox.Text = Program.properties.sqlUsername;
            passwordBox.Text = Program.properties.sqlPassword;
        }
        private void connectTestBTN_Click(object sender, EventArgs e)
        {
            SqlHelper.SqlLoginInfo connectLoginInfo = new SqlHelper.SqlLoginInfo(sqlConnectBox.Text, 
                usernameBox.Text, passwordBox.Text, "master");
            var connection = new SqlHelper.Connection(connectLoginInfo);
            if (connection.Connect())
            {
                XtraMessageBox.Show("Bağlantı Başarılı","Bağlantı Testi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                connection.Disconnect();
            }
        }

        private void saveSettingsBTN_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Kaydetmek istediğinize emin misiniz?", "Kaydediliyor..", 
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.properties.sqlAddress = sqlConnectBox.Text;
                Program.properties.sqlUsername = usernameBox.Text;
                Program.properties.sqlPassword = passwordBox.Text;
                Program.properties.Save();
                XtraMessageBox.Show("Sunucu Bilgileri Kaydedildi", "Kaydetme Başarılı", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            
        }
    }
}