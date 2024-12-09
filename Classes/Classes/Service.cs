using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class Service
    {
        public static string Name;

        static Service()
        {
            Name = "Webservice";
        }

        public static void AddUser(User user, string password)
        {
            if (user == null || password == null)
                return;

            if (user.CheckPassword(password))
                Console.WriteLine($"{Name} >> {DateTime.Now.ToShortTimeString()} присоединился {user.Login}");
            else
                Console.WriteLine($"Пара логин: {user.Login}, пароль: {password} неверная");
        }
    }
}
