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

        }
    }
}