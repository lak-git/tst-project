using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst_project.Game_logic
{
    internal class StatsCalculator
    {
        public float typingSpeed { get; set; }
        public float typingAccuracy { get; set; }
        public float score { get; set; }

        public StatsCalculator(float typingSpeed, float typingAccuracy, float score)
        {
            this.typingSpeed = typingSpeed;
            this.typingAccuracy = typingAccuracy;
            this.score = score;
        }
        public StatsCalculator()
        {
            typingSpeed = 0.0f;
            typingAccuracy = 0.0f;
            score = 0.0f;
        }

        public float CalcTypingSpeed(string userText, float timeInSeconds)
        {
            string[] words = userText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            typingSpeed = (wordCount / timeInSeconds) * 60;
            return typingSpeed;
        }
        public float CalcTypingAccuracy(string originalText, string userText)
        {
            float correctChars = 0;
            int length = Math.Min(originalText.Length, userText.Length);

            for (int i = 0; i < length; i++)
            {
                if (originalText[i] == userText[i])
                    correctChars++;
            }

            typingAccuracy = (correctChars / originalText.Length) * 100;
            return typingAccuracy;
        }

        public float CalScore()
        {
            score = typingSpeed * typingAccuracy;
            return score;
        }
    }
}
