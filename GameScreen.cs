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

namespace tst_project
{
    public partial class GameScreen : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private int countValue; //Holds the countdown value
        public GameScreen()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            TextHandler textHandler = new TextHandler();
            textHandler.CreateTable();
            ParagraphWrapper.Text = textHandler.RandomParagraph(); //Assigns String to the GUI Element

            GameCountDown = new Timer(); //creates instance of timer
            GameCountDown.Interval = 1000;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            countValue = 3; //initialise value and assign countValue to label
            GameStartLabel.Text = countValue.ToString();

            GameCountDown.Start();

            ParagraphWrapper.Visible = false;
            UserInputField.Visible = false;
        }

        private void GameCountDown_Tick(object sender, EventArgs e)
        {
            countValue -= 1;
            if (countValue > 0) // Only update the label if the value is non-negative
            {
                GameStartLabel.Text = countValue.ToString();
                GameStartLabel.Refresh();
            } //update count value

            if (countValue <= 0)
            {
                GameCountDown.Stop();
                GameStartLabel.Visible = false;
                GetReadyText.Visible = false;
                ParagraphWrapper.Visible = true;
                UserInputField.Visible = true;
            }
        }
    }
}
