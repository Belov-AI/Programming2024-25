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

        static List<User> users;

        static Service()
        {
            Name = "Webservice";
            users = new List<User>();
        }

        public static void AddUser(User user, string password)
        {
            if (user == null || password == null)
                return;

            if (user.CheckPassword(password))
            {
                users.Add(user);
                Console.WriteLine($"{Name} >> {DateTime.Now.ToShortTimeString()} присоединился {user.Login}");
            }
            else
                Console.WriteLine($"Пара логин: {user.Login}, пароль: {password} неверная");
        }

        public static void PrintUsers()
        {
            foreach (User user in users)
                user.PrintInfo();
        }
    }
}
