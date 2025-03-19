using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public sealed class Service : IEnumerable<User>
    {
        public static string Name;
        List<User> users;
        static Service uniqueInstance;

        private Service()
        {
            Name = "Webservice";
            users = new List<User>();
        }

        public static Service GetService()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Service();
            }

            return uniqueInstance;
        }

        public void AddUser(User user, string password)
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

        public void PrintUsers()
        {
            foreach (User user in users)
                user.PrintInfo();
        }

        public IEnumerator<User> GetEnumerator() => users.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
