﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst_project.Game_logic
{
    internal class StatsCalculator
    {
        public static float CalcTypingSpeed(string userText, float timeInSeconds)
        {
            string[] words = userText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            float typingSpeed = (wordCount / timeInSeconds) * 60;

            return typingSpeed;
        }

        public static float CalcTypingAccuracy(string originalText, string userText)
        {
            float correctChars = 0;
            int length = Math.Min(originalText.Length, userText.Length);

            for (int i = 0; i < length; i++)
            {
                if (originalText[i] == userText[i])
                    correctChars++;
            }
            float typingAccuracy = (correctChars / originalText.Length) * 100;

            return typingAccuracy;
        }

        public static float CalcScore(float typingSpeed, float typingAccuracy)
        {
            float score = typingSpeed * typingAccuracy;

            return score;
        }
    }
}
