using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        private static string logFileName;

        public string Login;

        protected int passwordHash;

        public int PasswordHash
        {
            get => passwordHash;

            private set
            {
                passwordHash = value;
            }
        }

        public User(string login, string password)
        {
            Login = login;
            PasswordHash = password.GetHashCode();
        }

        static User()
        {
            logFileName = "log.txt";
        }

        ~User() 
        {
            Console.WriteLine($"Service.Name>> Пользователь {Login} отсоединился");
        }

        public void ChangePassword(string newPassword, string oldPassword)
        {
            if(oldPassword.GetHashCode() == PasswordHash) 
            {
                PasswordHash = newPassword.GetHashCode();
            }
        }

        public bool CheckPassword(string password)
        {
            return password.GetHashCode() == PasswordHash;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Пользователь: {Login}");
        }

    }
}
