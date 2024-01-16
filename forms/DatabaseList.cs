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
    public partial class DatabaseList : DevExpress.XtraEditors.XtraForm
    {
        public DatabaseList()
        {
            InitializeComponent();
           // databaseListBox.DataSource = GetDatabaseList();
           databaseListBox.Items.Add("deneme");
        }

        private List<string> GetDatabaseList()
        {
            SqlHelper.SqlLoginInfo loginMasterDBInfo = new SqlHelper.SqlLoginInfo(
                Program.CurrentDBInfo.SqlUsername, Program.CurrentDBInfo.SqlPassword, "master");
            Program.DBContext = new SqlHelper.Data(new SqlHelper.Connection(loginMasterDBInfo));
            if (new SqlHelper.Connection(loginMasterDBInfo).Connect())
            {
                DataTable dbListTable = Program.DBContext.GetTable("SELECT name FROM sys.databases");
                return dbListTable.ToList<string>(0);
            }
                return null;
        }

        private void chooseDatabaseBtn_Click(object sender, EventArgs e)
        {
            SetDatabaseName(databaseListBox.SelectedItems[0].ToString());
        }

        protected void SetDatabaseName(string databasename)
        {
            if (databaseListBox.SelectedItems.Count == 1)
            {
                Program.CurrentDBInfo.DatabaseName = databasename;
                DialogResult = DialogResult.OK;
            }
            else XtraMessageBox.Show("Lütfen bir veritabanı seçiniz!", "Veritabanı Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}