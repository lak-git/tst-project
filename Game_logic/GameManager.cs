using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tst_project.Account_System;

namespace tst_project.Game_logic
{
    internal class GameManager
    {
        public AccountManager Account_Manager;
        public Session CurrentSession;
        public StatsCalculator Stats_Calculator;
        public TextHandler Text_Handler;
        public Timer timer;
        public string CurrentText;
        public string UserInputText;

        public GameManager()
        {
            this.Account_Manager = new AccountManager();
            this.CurrentSession = new Session();
            this.Stats_Calculator = new StatsCalculator();
            this.Text_Handler = new TextHandler();
            this.timer = new Timer();
        }

        public void StartGame()
        {
            this.CurrentText = Text_Handler.RandomParagraph();
            this.timer.StartTimer();
        }
        public void StopGame()
        {
            float elapsedTime = timer.EndTimer();
            float typingSpeed = Stats_Calculator.CalcTypingSpeed(UserInputText, elapsedTime);
            float typingAccuracy = Stats_Calculator.CalcTypingAccuracy(CurrentText, UserInputText);
            float score = Stats_Calculator.CalScore();
        }
    }
}
