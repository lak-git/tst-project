using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst_project.Account_System
{
    internal class Session
    {
        public float Score
        {
            get { return this.Score; }
            private set
            {
                if (value >= 0) { this.Score = value; }
                else { Console.WriteLine("Throw an error"); }
            }
        }
        public float TypingSpeed
        {
            get { return this.TypingSpeed; }
            private set
            {
                if (value >= 0) { this.TypingSpeed = value; }
                else { Console.WriteLine("Throw an error"); }
            }
        }
        public float TypingAccuracy
        {
            get { return this.TypingAccuracy; }
            private set
            {
                if (value >= 0) { this.TypingAccuracy = value; }
                else { Console.WriteLine("Throw an error"); }
            }
        }

        public Session()
        {
            this.TypingSpeed = 0;
            this.TypingAccuracy = 0;
            this.Score = 0;
        }

        public void UpdateStats(float score, float typingSpeed, float typingAccuracy)
        {
            this.TypingSpeed = typingSpeed;
            this.TypingAccuracy = typingAccuracy;
            this.Score = score;
        }
    }
}
