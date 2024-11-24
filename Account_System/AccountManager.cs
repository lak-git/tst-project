using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tst_project.Account_System;

namespace tst_project
{
    internal class AccountManager
    {
        // Temporary
        public User adminAcc = new User("admin123", "admin123", 0);
        //
        private User CurrentLoggedInUser { get; set; }

        public AccountManager() { }

        public void logInUser(string username, string password)
        {
            // Temporary
            if (adminAcc.validateCredentials(username, password))
            {
                CurrentLoggedInUser = adminAcc;
            }
            //
        }
        public void updateStatsFromGame(Session session)
        {
            CurrentLoggedInUser.updateStats(session.Score, session.TypingSpeed);
        }
    }
}
