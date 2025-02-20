using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public enum AccessLevel
    {
        Low, 
        Medium, 
        High
    }

    public class Admin : RegisteredUser
    {
        AccessLevel accessLevel;

        public Admin(string login, string password, string email, AccessLevel level) :
            base(login, password, email)
        { 
            accessLevel = level;
        }

        public void ChangeUserPassword(User user, string newPassword)
        {
            if(accessLevel == AccessLevel.High)
                passwordHash = newPassword.GetHashCode();
        }
        
    }
}
