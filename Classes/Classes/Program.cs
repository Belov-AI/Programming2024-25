using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person mike;
            mike = new Person();
            mike.Name = "Михаил";
            mike.LastName = "Иванов";
            mike.Age = 20;

            var kate = new Person() 
            {
                Name = "Екатерина", 
                LastName = "Петрова", 
            };

            kate.Age = 19;

            var peter = new Person("Пётр", "Сидоров", 21);
            var anonymous = new Person();
            
            mike.PrintInfo();
            kate.PrintInfo();
            peter.PrintInfo();
            anonymous.PrintInfo();

            var user = new User("user123", "12345");
            var anotherUser = new User("topProggerCS", "qwerty");

            Service.AddUser(user, "12345");
            Service.AddUser(anotherUser, "12345");

            Console.ReadKey();
        }
    }
}
