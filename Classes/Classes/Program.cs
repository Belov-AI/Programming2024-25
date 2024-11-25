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
            mike.SetAge(20);

            var kate = new Person() 
            {
                Name = "Екатерина", 
                LastName = "Петрова", 
            };

            kate.SetAge(19);

            mike.PrintInfo();
            kate.PrintInfo();

            Console.ReadKey();
        }
    }
}
