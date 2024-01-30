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
        }

        public void databaseListFill()
        {
            databaseListBox.Items.Clear();
            SqlHelper.SqlLoginInfo masterLoginInfo = new SqlHelper.SqlLoginInfo(
                Program.properties.sqlAddress, Program.properties.sqlUsername, Program.properties.sqlPassword,
                "master");
            databaseListBox.DataSource = GetDatabaseList(masterLoginInfo);
        }

        protected List<string> GetDatabaseList(SqlHelper.SqlLoginInfo sqlLoginInfo)
        {
            SqlHelper.Data dbContext = new SqlHelper.Data(new SqlHelper.Connection(sqlLoginInfo));
            DataTable dbListTable = dbContext.GetTable(Program.DatabaseListCommand);
            return dbListTable.ToList<string>(0);
        }

        private void chooseDatabaseBtn_Click(object sender, EventArgs e)
        {
            if (databaseListBox.SelectedItems.Count == 1)
            {
                Properties.Settings.Default.sqlCurrentDB = databaseListBox.SelectedItems[0].ToString();
                DialogResult = DialogResult.OK;
            }
            else XtraMessageBox.Show("Lütfen bir veritabanı seçiniz!", "Veritabanı Seçilmedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void getdbListBTN_Click(object sender, EventArgs e)
        {
            databaseListFill();
        }

        private void settingsdbBTN_Click(object sender, EventArgs e)
        {
            new DatabaseSettings().ShowDialog();
        }
    }
}