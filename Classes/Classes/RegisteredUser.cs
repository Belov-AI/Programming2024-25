using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class RegisteredUser : User
    {
        public string Email {  get; protected set; }

        public RegisteredUser(string login, string password, string email) : base(login, password)  
        {
            if (email.Contains("@"))
                Email = email;
            else
                throw new ArgumentException("Неверный адрес email");
        }

        public void ChangeEmail(string newEmail, string password)
        {
            if(!Email.Contains("@"))
                throw new ArgumentException("Неверный адрес email");

            if(!CheckPassword(password))
                throw new ArgumentException("Неверный пароль");

            Email = newEmail;
        }
    }

}
