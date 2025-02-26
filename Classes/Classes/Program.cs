﻿using System;
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
            //Person mike;
            //mike = new Person();
            //mike.Name = "Михаил";
            //mike.LastName = "Иванов";
            //mike.Age = 20;

            //var kate = new Person() 
            //{
            //    Name = "Екатерина", 
            //    LastName = "Петрова", 
            //};

            //kate.Age = 19;

            //var peter = new Person("Пётр", "Сидоров", 21);
            //var anonymous = new Person();
            
            //mike.PrintInfo();
            //kate.PrintInfo();
            //peter.PrintInfo();
            //anonymous.PrintInfo();

            var user = new User("user123", "12345");
            var anotherUser = new User("topProggerCS", "qwerty");

            Service.AddUser(user, "12345");
            //Service.AddUser(anotherUser, "12345");
            Service.AddUser(anotherUser, "qwerty");

            var regUser = new RegisteredUser("Tiger", "55555", "tiger@mail.ru");
            Service.AddUser(regUser, "55555");

            var admin = new Admin("MrPresident", "usa666", "president@gov.com", AccessLevel.High);
            Service.AddUser(admin, "usa666");

            var vipUser = new VIPUser("BillGates", "N{DFOjabm165ryo]rnL", "billgates@microisoft.com", "1234567890");
            Service.AddUser(vipUser, "N{DFOjabm165ryo]rnL");

            Console.WriteLine();

            Service.PrintUsers();

            Console.ReadKey();
        }
    }
}
