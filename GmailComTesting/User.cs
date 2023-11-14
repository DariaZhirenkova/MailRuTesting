using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailComTesting
{
    public class User
    {
        private string _login { get; set; }

        public string login {  get
            { return _login; }
            }
        private string _password { get; set; }

        public string password
        {
            get
            { return _password; }
        }
        private string _endOfEmail { get; set; }

        public string email
        {
            get
            { return _endOfEmail; }
        }
        private string _name;
        public string name
        {
            get
            { return _name; }
        }

        public User(string login,string password,string endOfEmail,string name)
        {
            _login = login;
            _password = password;
            _endOfEmail = endOfEmail;
            _name = name;
        }

      
    }
}
