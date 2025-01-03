﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace tst_project
{
    public partial class RegistrationForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public RegistrationForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private AccountManager accountManager = new AccountManager();
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameField.Text;
            string password = PasswordField.Text;
            string confirmpassword = ConfirmPasswordField.Text;

            if (username != null && password != null && password == confirmpassword) 
            {
                if (accountManager.validateCredentials(username, password))
                {
                    MessageBox.Show("Account Already Exists!");
                }
                else
                {
                    if (accountManager.createAccount(username, password))
                    {   
                    MessageBox.Show("Account Created Successfully");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid User or Password");
            }

        }
    }
}
