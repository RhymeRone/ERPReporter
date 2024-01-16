using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NebimV3Reporter
{
    public class SqlHelper
    {
        public interface IDatabaseLoginInfo
        {
            string SqlUsername { get; set; }
            string SqlPassword { get; set; }
            string DatabaseName { get; set; }
        }

        public interface IConnection
        {
            IDatabaseLoginInfo DatabaseLoginInfo{ get; set; }
            SqlConnection SqlConnection { get; set; }
            bool Connect();
            bool Disconnect();
            SqlConnection GetConnection();

        }

        public class SqlLoginInfo : IDatabaseLoginInfo
        {
            private string _sqlUsername;
            private string _sqlPassword;
            private string _databaseName;

            public SqlLoginInfo(string sqlUserName, string sqlPassword, string databaseName)
            {
                _sqlUsername = sqlUserName;
                _sqlPassword = sqlPassword;
                _databaseName = databaseName;
            }

            public string SqlUsername { get { return _sqlUsername; } set { _sqlUsername = value; } }
            public string SqlPassword { get { return _sqlPassword; } set { _sqlPassword = value; } }
            public string DatabaseName { get { return _databaseName; } set { _databaseName = value; } }
        }

        public class Connection : IConnection
        { 
            public IDatabaseLoginInfo _databaseLoginInfo;
            public SqlConnection _connection;

            public IDatabaseLoginInfo DatabaseLoginInfo { get => _databaseLoginInfo; set => _databaseLoginInfo = value; }
            public SqlConnection SqlConnection { get => _connection; set => _connection = value; }

            public Connection(IDatabaseLoginInfo databaseLoginInfo)
            {
                _databaseLoginInfo = databaseLoginInfo;
                _connection = new SqlConnection($"Server=localhost;" +
                                                $"Database={_databaseLoginInfo.DatabaseName};" +
                                                $"User ID={_databaseLoginInfo.SqlUsername};" +
                                                $"Password={_databaseLoginInfo.SqlPassword};");
            }


            public bool Connect()
            {
                try
                {
                    _connection.Open();
                    return true;
                }
                catch (Exception e)
                {

                    XtraMessageBox.Show(e.Message,"Bağlantı Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            public bool Disconnect()
            {
                try
                {
                    _connection.Close();
                    _connection.Dispose();
                    return true;
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message,"Veritabanı Bağlantısı Kapatılamadı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }

            public SqlConnection GetConnection()
            {
                return _connection;
            }


        }

        public class Data
        {
            private IConnection _connection;
            public Data(IConnection connection)
            {
                _connection = connection;
            }

            public DataTable GetTable(string command)
            {
                try
                {
                    if (_connection.Connect())
                    {
                        DataAdapter dtAdapter = new SqlDataAdapter(command, _connection.GetConnection());
                        DataSet ds = new DataSet();
                        dtAdapter.Fill(ds);
                        _connection.Disconnect();
                        return ds.Tables[0];
                    }
                    return null;
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show(e.Message);
                    return null;
                }
            }
        }

    }


}
