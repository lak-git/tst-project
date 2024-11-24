using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst_project.Account_System
{
    internal class Session
    {
        public float Score { get; set; }
        public float TypingSpeed { get; set; }

        public Session()
        {
            this.Score = 0;
            this.TypingSpeed = 0;
        }

        public void updateStats(float score, float typingSpeed)
        {
            this.Score = score;
            this.TypingSpeed = typingSpeed;
        }
    }
}
