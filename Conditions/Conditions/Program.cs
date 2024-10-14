using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки через пробел");
            var input = Console.ReadLine();
            
            var k = input.IndexOf(' ');
            var x = double.Parse(input.Substring(0,k));
            var y = double.Parse(input.Substring(k+1));

            string message;

            if (x == 0)
                if (y == 0)
                    message = "совпадает с началом координат";
                else
                    message = "лежит на оси Oy";
            else if (x > 0)
                if (y > 0)
                    message = "точка лежит в I квадранте";
                else if (y < 0)
                    message = "точка лежит в IV квадранте";
                else
                    message = "лежит на оси Ox";
            else
                if (y > 0)
                    message = "точка лежит во II квадранте";
                else if (y < 0)
                    message = "точка лежит в III квадранте";
                else
                    message = "лежит на оси Ox";


            Console.WriteLine($"Точка ({x}; {y}) " + message);

            Console.ReadKey();
        }
    }
}
