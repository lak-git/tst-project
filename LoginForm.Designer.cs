namespace tst_project
{
    partial class LoginForm
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
            this.BackToRegister = new MaterialSkin.Controls.MaterialLabel();
            this.LoginBtn = new MaterialSkin.Controls.MaterialButton();
            this.PasswordField = new MaterialSkin.Controls.MaterialTextBox();
            this.UsernameField = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // BackToRegister
            // 
            this.BackToRegister.AutoSize = true;
            this.BackToRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToRegister.Depth = 0;
            this.BackToRegister.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BackToRegister.Location = new System.Drawing.Point(87, 324);
            this.BackToRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackToRegister.Name = "BackToRegister";
            this.BackToRegister.Size = new System.Drawing.Size(98, 19);
            this.BackToRegister.TabIndex = 13;
            this.BackToRegister.Text = "Back to Menu";
            this.BackToRegister.UseAccent = true;
            this.BackToRegister.Click += new System.EventHandler(this.BackToRegister_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AutoSize = false;
            this.LoginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginBtn.Depth = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.HighEmphasis = true;
            this.LoginBtn.Icon = null;
            this.LoginBtn.Location = new System.Drawing.Point(20, 282);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginBtn.Size = new System.Drawing.Size(233, 36);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginBtn.UseAccentColor = false;
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.AnimateReadOnly = false;
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Depth = 0;
            this.PasswordField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordField.Hint = "Password";
            this.PasswordField.LeadingIcon = null;
            this.PasswordField.Location = new System.Drawing.Point(20, 150);
            this.PasswordField.MaxLength = 50;
            this.PasswordField.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordField.Multiline = false;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Password = true;
            this.PasswordField.Size = new System.Drawing.Size(233, 50);
            this.PasswordField.TabIndex = 11;
            this.PasswordField.Text = "";
            this.PasswordField.TrailingIcon = null;
            this.PasswordField.TextChanged += new System.EventHandler(this.PasswordField_TextChanged);
            // 
            // UsernameField
            // 
            this.UsernameField.AnimateReadOnly = false;
            this.UsernameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameField.Depth = 0;
            this.UsernameField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameField.Hint = "Username";
            this.UsernameField.LeadingIcon = null;
            this.UsernameField.Location = new System.Drawing.Point(20, 86);
            this.UsernameField.MaxLength = 50;
            this.UsernameField.MouseState = MaterialSkin.MouseState.OUT;
            this.UsernameField.Multiline = false;
            this.UsernameField.Name = "UsernameField";
            this.UsernameField.Size = new System.Drawing.Size(233, 50);
            this.UsernameField.TabIndex = 10;
            this.UsernameField.Text = "";
            this.UsernameField.TrailingIcon = null;
            this.UsernameField.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 361);
            this.Controls.Add(this.BackToRegister);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UsernameField);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel BackToRegister;
        private MaterialSkin.Controls.MaterialButton LoginBtn;
        private MaterialSkin.Controls.MaterialTextBox PasswordField;
        private MaterialSkin.Controls.MaterialTextBox UsernameField;
    }
}