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
            this.Login = new MaterialSkin.Controls.MaterialButton();
            this.Password = new MaterialSkin.Controls.MaterialTextBox();
            this.Username = new MaterialSkin.Controls.MaterialTextBox();
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
            // Login
            // 
            this.Login.AutoSize = false;
            this.Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Login.Depth = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.HighEmphasis = true;
            this.Login.Icon = null;
            this.Login.Location = new System.Drawing.Point(20, 282);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login.Name = "Login";
            this.Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Login.Size = new System.Drawing.Size(233, 36);
            this.Login.TabIndex = 12;
            this.Login.Text = "LOGIN";
            this.Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Login.UseAccentColor = false;
            this.Login.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.AnimateReadOnly = false;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Depth = 0;
            this.Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Password.Hint = "Password";
            this.Password.LeadingIcon = null;
            this.Password.Location = new System.Drawing.Point(20, 150);
            this.Password.MaxLength = 50;
            this.Password.MouseState = MaterialSkin.MouseState.OUT;
            this.Password.Multiline = false;
            this.Password.Name = "Password";
            this.Password.Password = true;
            this.Password.Size = new System.Drawing.Size(233, 50);
            this.Password.TabIndex = 11;
            this.Password.Text = "";
            this.Password.TrailingIcon = null;
            // 
            // Username
            // 
            this.Username.AnimateReadOnly = false;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Depth = 0;
            this.Username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Username.Hint = "Username";
            this.Username.LeadingIcon = null;
            this.Username.Location = new System.Drawing.Point(20, 86);
            this.Username.MaxLength = 50;
            this.Username.MouseState = MaterialSkin.MouseState.OUT;
            this.Username.Multiline = false;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(233, 50);
            this.Username.TabIndex = 10;
            this.Username.Text = "";
            this.Username.TrailingIcon = null;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 361);
            this.Controls.Add(this.BackToRegister);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel BackToRegister;
        private MaterialSkin.Controls.MaterialButton Login;
        private MaterialSkin.Controls.MaterialTextBox Password;
        private MaterialSkin.Controls.MaterialTextBox Username;
    }
}