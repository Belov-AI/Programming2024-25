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

            var service = Service.GetService();

            service.AddUser(user, "12345");
            //Service.AddUser(anotherUser, "12345");
            service.AddUser(anotherUser, "qwerty");

            var regUser = new RegisteredUser("Tiger", "55555", "tiger@mail.ru");
            service.AddUser(regUser, "55555");

            var admin = new Admin("mrPresident", "usa666", "president@gov.com", AccessLevel.High);
            service.AddUser(admin, "usa666");

            var vipUser = new VIPUser("BillGates", "N{DFOjabm165ryo]rnL", "billgates@microisoft.com", "1234567890");
            service.AddUser(vipUser, "N{DFOjabm165ryo]rnL");

            foreach(var u in service)
                u.PrintInfo();

            Console.WriteLine();

            //Service.PrintUsers();

            //var myUsers = new User[5];
            //myUsers[0] = user;
            //myUsers[1] = anotherUser;
            //myUsers[2] = regUser;
            //myUsers[3] = admin;
            //myUsers[4] = vipUser;

            //PrintUsers(myUsers);

            //Console.WriteLine();
            //Array.Sort(myUsers);
            //PrintUsers(myUsers);

            //Console.WriteLine();
            //Array.Sort(myUsers, new ReverseAlphabeticalOrderComparer());
            //PrintUsers(myUsers);

            //Console.ReadKey();
        }

        public static void PrintUsers(User[] users)
        {
            foreach (User user in users)
                user.PrintInfo();
        }

        
    }
}
