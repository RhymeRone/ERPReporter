using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

        public class Connection
        {
            private IDatabaseLoginInfo _databaseLoginInfo;
            private SqlConnection _connection;

            public Connection(IDatabaseLoginInfo databaseLoginInfo)
            {
                _databaseLoginInfo = databaseLoginInfo;
                _connection = new SqlConnection($"Server=localhost;" +
                                                $"Database={_databaseLoginInfo.DatabaseName};" +
                                                $"User ID={_databaseLoginInfo.SqlUsername};" +
                                                $"Password={_databaseLoginInfo.SqlPassword};");
            }
            public string Connect()
            {
                try
                {
                    _connection.Open();
                    return "Bağlantı Başarılı";
                }
                catch (Exception e)
                {
                    return e.Message;
                }
            }

            public void Disconnect()
            {
                try
                {
                    _connection.Close();
                    _connection.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

        }

    }


}
