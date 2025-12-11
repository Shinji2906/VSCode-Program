using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyCafe.DAL;

namespace QlyCafe.BLL
{
    internal class UserServices
    {
        private QlyCafe_Entities dbContext;
        public UserServices() {
            dbContext = new QlyCafe_Entities();
        }

        public bool islogin(string username, string password)
        {
            var user = dbContext.User.FirstOrDefault(u => u.username == username && u.password == password);
            return user != null && user.isactive;
        }

        public bool isadmin (string username)
        {
            var user = dbContext.User.FirstOrDefault(u => u.username == username);
            return user != null && user.role.Equals("admim", StringComparison.OrdinalIgnoreCase); 
        }
        
    }
}
 