using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class VIPUser : RegisteredUser
    {
        private string cadrNumber;

        public VIPUser(string login, string password, string email, string cardNumber) :
            base(login,password, email)
        {
            this.cadrNumber = cardNumber;
        }

        public void ChangeCard(string newCardNumber, string password)
        {
            if(CheckPassword(password))
               cadrNumber = newCardNumber;
        }
    }
}
