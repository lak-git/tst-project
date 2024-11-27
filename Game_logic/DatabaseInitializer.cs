using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace tst_project
{
    public static class DatabaseInitializer
    {
        private const string ConnectionString = "Data Source=mydatabase.sqlite;Version=3;";


        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL
                    );";
                using (var command = new SQLiteCommand(createTableQuery, connection)) 
                {
                    command.ExecuteNonQuery();
                }

                string insertAdminQuery = @"
                    INSERT INTO Users (Username, Password, Role)
                    VALUES ('admin', 'admin123', 'admin')
                    ON CONFLICT(Username) DO NOTHING;";
                using (var command = new SQLiteCommand(insertAdminQuery, connection))
                { 
                    command.ExecuteNonQuery(); 
                }
            }
        }
    }
}
