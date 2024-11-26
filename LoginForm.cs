using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SQLite;

namespace tst_project
{
    public partial class LoginForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public LoginForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToRegister_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateLogin(string username, string password)
        {
            const string ConnectionString = "Data Source=mydatabase.sqlite;Version=3;";

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password ";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();
                            MessageBox.Show($"Success! Role: {role}");
                            return true;
                        }
                    }
                }
            }

            MessageBox.Show("Invalid Username or Password");
            return false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameField.Text;
            string password = PasswordField.Text;

            if (ValidateLogin(username, password))
            {
            }

        }
    }
}
