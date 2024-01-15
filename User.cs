using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebimV3Reporter
{
    internal interface ILoginInfo{ string Username { get; set; } string Password { get; set; }}
    internal class User : ILoginInfo
    {
        private string _username,_password;

        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }
        public string Username
        {
            get => _username;
            set { _username = value; }
        }

        public string Password
        {
            get => _password;
            set { _password = value; }
        }
    }
}
