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
            this.PasswordField = new MaterialSkin.Controls.MaterialTextBox();
            this.UsernameField = new MaterialSkin.Controls.MaterialTextBox();
            this.ConfirmPasswordField = new MaterialSkin.Controls.MaterialTextBox();
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
            // PasswordField
            // 
            this.PasswordField.AnimateReadOnly = false;
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Depth = 0;
            this.PasswordField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordField.Hint = "Password";
            this.PasswordField.LeadingIcon = null;
            this.PasswordField.Location = new System.Drawing.Point(20, 146);
            this.PasswordField.MaxLength = 50;
            this.PasswordField.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordField.Multiline = false;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Password = true;
            this.PasswordField.Size = new System.Drawing.Size(233, 50);
            this.PasswordField.TabIndex = 6;
            this.PasswordField.Text = "";
            this.PasswordField.TrailingIcon = null;
            this.PasswordField.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // UsernameField
            // 
            this.UsernameField.AnimateReadOnly = false;
            this.UsernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameField.Depth = 0;
            this.UsernameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameField.Hint = "Username";
            this.UsernameField.LeadingIcon = null;
            this.UsernameField.Location = new System.Drawing.Point(20, 81);
            this.UsernameField.MaxLength = 50;
            this.UsernameField.MouseState = MaterialSkin.MouseState.OUT;
            this.UsernameField.Multiline = false;
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(233, 50);
            this.UsernameField.TabIndex = 5;
            this.UsernameField.Text = "";
            this.UsernameField.TrailingIcon = null;
            this.UsernameField.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // ConfirmPasswordField
            // 
            this.ConfirmPasswordField.AnimateReadOnly = false;
            this.ConfirmPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordField.Depth = 0;
            this.ConfirmPasswordField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ConfirmPasswordField.Hint = "Confirm Password";
            this.ConfirmPasswordField.LeadingIcon = null;
            this.ConfirmPasswordField.Location = new System.Drawing.Point(20, 211);
            this.ConfirmPasswordField.MaxLength = 50;
            this.ConfirmPasswordField.MouseState = MaterialSkin.MouseState.OUT;
            this.ConfirmPasswordField.Multiline = false;
            this.ConfirmPasswordField.Name = "ConfirmPasswordField";
            this.ConfirmPasswordField.Password = true;
            this.ConfirmPasswordField.Size = new System.Drawing.Size(233, 50);
            this.ConfirmPasswordField.TabIndex = 9;
            this.ConfirmPasswordField.Text = "";
            this.ConfirmPasswordField.TrailingIcon = null;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 361);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.ConfirmPasswordField);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
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
        private MaterialSkin.Controls.MaterialTextBox PasswordField;
        private MaterialSkin.Controls.MaterialTextBox UsernameField;
        private MaterialSkin.Controls.MaterialTextBox ConfirmPasswordField;
    }
}