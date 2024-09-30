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

            Console.ReadKey();
        }
    }
}
