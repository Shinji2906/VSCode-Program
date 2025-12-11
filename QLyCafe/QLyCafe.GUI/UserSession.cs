using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyCafe.GUI
{
    public static class UserSession
    {
        public static string Username {  get; set; }
        public static bool isadmin { get; set; }
        public static bool islogin()
        {
            return !String.IsNullOrEmpty(Username);
        }
        public static void Logout()
        {
            Username = null;
            isadmin = false;
        }
    }
}
