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

            Console.ReadKey();
        }
    }
}
