using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tst_project.Account_System;

namespace tst_project.Game_logic
{
    internal class GameManager
    {

        public AccountManager Account_Manager;
        public TextHandler Text_Handler;
        public Session CurrentSession;
        public Timer timer;
        public string CurrentText;

        public GameManager()
        {
            this.timer = new Timer();
            this.Account_Manager = new AccountManager();
            this.CurrentSession = new Session();
            this.Text_Handler = new TextHandler();
        }
    }
}
