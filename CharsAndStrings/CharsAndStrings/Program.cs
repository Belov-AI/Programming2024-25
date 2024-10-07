using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = 'z';
            Console.WriteLine(letter);

            letter = (char)0x42F;
            Console.WriteLine(letter);

            letter = char.ToLower(letter);
            Console.WriteLine(letter);
            Console.WriteLine(char.IsLetter(letter));
            Console.WriteLine(char.IsDigit(letter));

            Console.WriteLine();
            string s = "Hello";
            Console.WriteLine(s);   
            s += ", World";
            Console.WriteLine(s);
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s[7]);
            Console.WriteLine(s.Substring(7));

            Console.WriteLine("Введите целое число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введенное число " + n);

            Console.WriteLine("Роман Л. Н. Толстого \"Война и мир\"");
            Console.WriteLine("Роман Л. Н. Толстого \x00ABВойна и мир\x00BB");
            Console.WriteLine("Прямой угол равен 90\x00B0\a");


            double x = 551.23456789;
            int y = 2;
            Console.WriteLine("x = {0,6:F4} y = {1:G}", x, y);
            Console.WriteLine($"абсцисса {x,6:F4}; ордината {y}");
            Console.WriteLine($"точка ({x:F2}; {y:F2})");

            Console.WriteLine("x = {0,6:E}", x);

            Console.WriteLine("Сейчас {0:HH:mm dd.MM.yy}", DateTime.Now);

            Console.WriteLine();
            PrintCultureInfo(CultureInfo.CurrentCulture.Name);
            PrintCultureInfo("en-US");
            PrintCultureInfo("en-GB");
            PrintCultureInfo("fr-FR");
            PrintCultureInfo("es-ES");

            Console.ReadKey();
        }

        static void PrintCultureInfo(string name)
        {
            var oldCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo(name);

            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            var x = 1.234556;
            Console.WriteLine(x);
            var dt = DateTime.Now;
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine();

            CultureInfo.CurrentCulture = oldCulture;
        }

    }
}
