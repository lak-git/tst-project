namespace tst_project
{
    partial class MainMenu
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
            this.Register = new MaterialSkin.Controls.MaterialButton();
            this.Login = new MaterialSkin.Controls.MaterialButton();
            this.StartGameBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.Register.Location = new System.Drawing.Point(19, 234);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.Register.Name = "Register";
            this.Register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Register.Size = new System.Drawing.Size(233, 36);
            this.Register.TabIndex = 8;
            this.Register.Text = "REGISTER";
            this.Register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Register.UseAccentColor = false;
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
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
            this.Login.Location = new System.Drawing.Point(19, 186);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login.Name = "Login";
            this.Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Login.Size = new System.Drawing.Size(233, 36);
            this.Login.TabIndex = 13;
            this.Login.Text = "LOGIN";
            this.Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Login.UseAccentColor = false;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.AutoSize = false;
            this.StartGameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartGameBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartGameBtn.Depth = 0;
            this.StartGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartGameBtn.HighEmphasis = true;
            this.StartGameBtn.Icon = null;
            this.StartGameBtn.Location = new System.Drawing.Point(19, 138);
            this.StartGameBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartGameBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartGameBtn.Size = new System.Drawing.Size(233, 36);
            this.StartGameBtn.TabIndex = 14;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartGameBtn.UseAccentColor = false;
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 361);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Register;
        private MaterialSkin.Controls.MaterialButton Login;
        private MaterialSkin.Controls.MaterialButton StartGameBtn;
    }
}