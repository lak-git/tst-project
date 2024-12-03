namespace tst_project
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.UserInputField = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.ParagraphWrapper = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.GameStartLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GameCountDown = new System.Windows.Forms.Timer(this.components);
            this.GetReadyText = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // UserInputField
            // 
            this.UserInputField.AnimateReadOnly = false;
            this.UserInputField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserInputField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserInputField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserInputField.Depth = 0;
            this.UserInputField.HideSelection = true;
            this.UserInputField.Hint = "Hello World";
            this.UserInputField.Location = new System.Drawing.Point(74, 308);
            this.UserInputField.MaxLength = 32767;
            this.UserInputField.MouseState = MaterialSkin.MouseState.OUT;
            this.UserInputField.Name = "UserInputField";
            this.UserInputField.PasswordChar = '\0';
            this.UserInputField.ReadOnly = false;
            this.UserInputField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserInputField.SelectedText = "";
            this.UserInputField.SelectionLength = 0;
            this.UserInputField.SelectionStart = 0;
            this.UserInputField.ShortcutsEnabled = true;
            this.UserInputField.Size = new System.Drawing.Size(635, 100);
            this.UserInputField.TabIndex = 0;
            this.UserInputField.TabStop = false;
            this.UserInputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserInputField.UseSystemPasswordChar = false;
            // 
            // ParagraphWrapper
            // 
            this.ParagraphWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ParagraphWrapper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParagraphWrapper.Depth = 0;
            this.ParagraphWrapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ParagraphWrapper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ParagraphWrapper.HideSelection = false;
            this.ParagraphWrapper.Location = new System.Drawing.Point(74, 101);
            this.ParagraphWrapper.MouseState = MaterialSkin.MouseState.HOVER;
            this.ParagraphWrapper.Name = "ParagraphWrapper";
            this.ParagraphWrapper.ReadOnly = true;
            this.ParagraphWrapper.Size = new System.Drawing.Size(635, 150);
            this.ParagraphWrapper.TabIndex = 5;
            this.ParagraphWrapper.Text = "";
            // 
            // GameStartLabel
            // 
            this.GameStartLabel.AutoSize = true;
            this.GameStartLabel.Depth = 0;
            this.GameStartLabel.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GameStartLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.GameStartLabel.HighEmphasis = true;
            this.GameStartLabel.Location = new System.Drawing.Point(373, 225);
            this.GameStartLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.GameStartLabel.Name = "GameStartLabel";
            this.GameStartLabel.Size = new System.Drawing.Size(54, 115);
            this.GameStartLabel.TabIndex = 6;
            this.GameStartLabel.Text = "3";
            // 
            // GameCountDown
            // 
            this.GameCountDown.Enabled = true;
            this.GameCountDown.Interval = 1000;
            this.GameCountDown.Tick += new System.EventHandler(this.GameCountDown_Tick);
            // 
            // GetReadyText
            // 
            this.GetReadyText.AutoSize = true;
            this.GetReadyText.Depth = 0;
            this.GetReadyText.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GetReadyText.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.GetReadyText.HighEmphasis = true;
            this.GetReadyText.Location = new System.Drawing.Point(184, 110);
            this.GetReadyText.MouseState = MaterialSkin.MouseState.HOVER;
            this.GetReadyText.Name = "GetReadyText";
            this.GetReadyText.Size = new System.Drawing.Size(432, 115);
            this.GetReadyText.TabIndex = 7;
            this.GetReadyText.Text = "Get Ready";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetReadyText);
            this.Controls.Add(this.GameStartLabel);
            this.Controls.Add(this.ParagraphWrapper);
            this.Controls.Add(this.UserInputField);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 UserInputField;
        private MaterialSkin.Controls.MaterialMultiLineTextBox ParagraphWrapper;
        private MaterialSkin.Controls.MaterialLabel GameStartLabel;
        private System.Windows.Forms.Timer GameCountDown;
        private MaterialSkin.Controls.MaterialLabel GetReadyText;
    }
}