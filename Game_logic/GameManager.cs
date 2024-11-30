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
        public Session CurrentSession; // Keeps track of the score of the ongoing game
        public TextHandler Text_Handler;
        public Timer timer;
        public string CurrentText;
        public string UserInputText;

        public GameManager()
        {
            this.Account_Manager = new AccountManager();
            this.CurrentSession = new Session();
            this.Text_Handler = new TextHandler();
            this.timer = new Timer();
        }

        // Gets a random paragraph to display and starts the timer.
        public void StartGame()
        {
            this.CurrentText = Text_Handler.RandomParagraph();
            this.timer.StartTimer();
        }

        // Stops timer and calculates the stats, then updates the session with it.
        public void StopGame()
        {
            float elapsedTime = timer.EndTimer();
            float typingSpeed = StatsCalculator.CalcTypingSpeed(UserInputText, elapsedTime);
            float typingAccuracy = StatsCalculator.CalcTypingAccuracy(CurrentText, UserInputText);
            float score = StatsCalculator.CalcScore(typingSpeed, typingAccuracy);

            CurrentSession.UpdateStats(score, typingSpeed, typingAccuracy);
        }

        //TODO: Make it so that the game screen can use these methods and this class
        //TODO: Make a result screen that displays the stats contained in the session, you could also make a method that returns the said stats
    }
}
