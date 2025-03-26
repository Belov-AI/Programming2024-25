using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Threading;

namespace Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new Sequence();

            Console.WriteLine("Числа Фиобаччи");
            PrintSequence(sequence.Fibonacci());
            Console.WriteLine();

            Console.WriteLine("Факториалы");
            PrintSequence(sequence.Factorial());
            Console.WriteLine();

            Console.WriteLine("Сиракузская последоавтельность");
            Console.WriteLine("Начальное число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            PrintSequence(sequence.Collattz(n));
        }

        static void PrintSequence(IEnumerable<BigInteger> s)
        {
            foreach (var item in s)
            {
                Thread.Sleep(250);
                Console.WriteLine(item);

                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Spacebar)
                        break;
                }              
            }
        }
    }
}
