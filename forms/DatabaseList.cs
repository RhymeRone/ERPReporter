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
            databaseListBox.DataSource = GetDatabaseList();
           // databaseListBox.Items.Add("deneme");
        }

        private List<string> GetDatabaseList()
        {
            SqlHelper.SqlLoginInfo loginMasterDBInfo = new SqlHelper.SqlLoginInfo(
                Program.CurrentDBInfo.SqlUsername, Program.CurrentDBInfo.SqlPassword, "master");
            SqlHelper.Data dbContext = new SqlHelper.Data(new SqlHelper.Connection(loginMasterDBInfo));
            DataTable dbListTable = dbContext.GetTable(Program.DatabaseListCommand);
            return dbListTable.ToList<string>(0);
        }

        private void chooseDatabaseBtn_Click(object sender, EventArgs e)
        {
            SetDatabase(databaseListBox.SelectedItems[0].ToString());
        }

        protected void SetDatabase(string databasename)
        {
            if (databaseListBox.SelectedItems.Count == 1)
            {
                Program.CurrentDBInfo.DatabaseName = databasename;
                DialogResult = DialogResult.OK;
            }
            else XtraMessageBox.Show("Lütfen bir veritabanı seçiniz!", "Veritabanı Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DatabaseList_Load(object sender, EventArgs e)
        {

        }
    }
}