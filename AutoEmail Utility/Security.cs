using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEmail_Utility
{
    public class Security
    {
        public static string ActiveUser =  Utility.ActiveUserName;
        private static bool AccessLogIn = false;
       
        public static bool LogInCheck
        {
            get
            {
                if (ActiveUser == "USER_NAME_insert")
                {
                    AccessLogIn = true;
                }
                else
                {
                    AccessLogIn = false;
                }
                return AccessLogIn;
            }
        }

    }
}
