using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEmail_Utility
{
    public class Utility
    {
        public static string ActiveUserName
        {
            get
            {
                return GetUserName();
            }
        }

        // set the active user
        private static string GetUserName()
        {
            return Environment.UserName;
        }

        


    }
}
