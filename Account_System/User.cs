using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace tst_project.Account_System
{
    internal class User : Session
    {
        public string Username { get; private set; }
        private string Password { get; set; }
        private int UserID { get; set; }

        public User(string username, string password, int userID) : base()
        {
            this.Username = username;
            this.Password = password;
            this.UserID = userID;
        }

        public bool validateCredentials(string username, string password)
        {
            return this.Username == username && this.Password == password;
        }
    }
}
