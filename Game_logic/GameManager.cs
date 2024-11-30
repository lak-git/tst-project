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
     
        public AccountManager Account_Manager = new AccountManager();
        public TextHandler Text_Handler = new TextHandler();
        public Session CurrentSession = new Session();
        public string CurrentText;

    }
}
