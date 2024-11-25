namespace tst_project
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackToLogin = new MaterialSkin.Controls.MaterialLabel();
            this.Register = new MaterialSkin.Controls.MaterialButton();
            this.Password = new MaterialSkin.Controls.MaterialTextBox();
            this.Username = new MaterialSkin.Controls.MaterialTextBox();
            this.ConfirmPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // BackToLogin
            // 
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLogin.Depth = 0;
            this.BackToLogin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BackToLogin.Location = new System.Drawing.Point(87, 324);
            this.BackToLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(98, 19);
            this.BackToLogin.TabIndex = 8;
            this.BackToLogin.Text = "Back to Menu";
            this.BackToLogin.UseAccent = true;
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = false;
            this.Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Register.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Register.Depth = 0;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register.HighEmphasis = true;
            this.Register.Icon = null;
            this.Register.Location = new System.Drawing.Point(20, 282);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.Register.Name = "Register";
            this.Register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Register.Size = new System.Drawing.Size(233, 36);
            this.Register.TabIndex = 7;
            this.Register.Text = "REGISTER";
            this.Register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Register.UseAccentColor = false;
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Password
            // 
            this.Password.AnimateReadOnly = false;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.Hint = "Password";
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(20, 146);
            this.Password.MaxLength = 50;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Password = true;
            this.Password.Size = new System.Drawing.Size(233, 50);
            this.Password.TabIndex = 6;
            this.Password.Text = "";
            this.Password.TrailingIcon = null;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Username
            // 
            this.Username.AnimateReadOnly = false;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Depth = 0;
            this.Username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Username.Hint = "Username";
            this.Username.LeadingIcon = null;
            this.Username.Location = new System.Drawing.Point(20, 81);
            this.Username.MaxLength = 50;
            this.Username.MouseState = MaterialSkin.MouseState.OUT;
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(233, 50);
            this.Username.TabIndex = 5;
            this.Username.Text = "";
            this.Username.TrailingIcon = null;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AnimateReadOnly = false;
            this.ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPassword.Depth = 0;
            this.ConfirmPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ConfirmPassword.Hint = "Confirm Password";
            this.ConfirmPassword.LeadingIcon = null;
            this.ConfirmPassword.Location = new System.Drawing.Point(20, 211);
            this.ConfirmPassword.MaxLength = 50;
            this.ConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.ConfirmPassword.Multiline = false;
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Password = true;
            this.ConfirmPassword.Size = new System.Drawing.Size(233, 50);
            this.ConfirmPassword.TabIndex = 9;
            this.ConfirmPassword.Text = "";
            this.ConfirmPassword.TrailingIcon = null;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 361);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel BackToLogin;
        private MaterialSkin.Controls.MaterialButton Register;
        private MaterialSkin.Controls.MaterialTextBox Password;
        private MaterialSkin.Controls.MaterialTextBox Username;
        private MaterialSkin.Controls.MaterialTextBox ConfirmPassword;
    }
}