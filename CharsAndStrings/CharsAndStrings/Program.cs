using System;
using System.Collections.Generic;
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

            Console.ReadKey();
        }
    }
}
