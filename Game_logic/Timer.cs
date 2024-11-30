using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tst_project.Game_logic
{
    internal class Timer
    {
        private DateTime startTime;

        public void StartTimer()
        {
            startTime = DateTime.Now;
        }
        public float EndTimer()
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            return (float)elapsedTime.TotalSeconds;
        }
    }
}
