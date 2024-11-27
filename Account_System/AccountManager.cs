using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tst_project.Account_System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace tst_project
{
    internal class AccountManager
    {
        // Temporary
        public User adminAcc = new User("admin123", "admin123", 0);
        //

        private const string ConnectionString = "Data Source=mydatabase.sqlite;Version=3;";
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

        public bool validateCredentials(string username, string password)
        {

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool createAccount(string username, string password)
        {
            using (var connection = new SQLiteConnection(ConnectionString)) 
            {
                connection.Open();
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, 'User')";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SQLiteException ex)
                    {
                        return false;
                    }
                }
            }
        }

        public void updateStatsFromGame(Session session)
        {
            CurrentLoggedInUser.updateStats(session.Score, session.TypingSpeed);
        }
    }
}
