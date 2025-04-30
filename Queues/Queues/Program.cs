using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел");

            var n = int.Parse(Console.ReadLine());

            var numbers = new Queue<int>[10];

            for(var i =0; i < numbers.Length; i++)
                numbers[i] = new Queue<int>();

            var rnd = new Random();

            for(var i = 0; i < n; i++)
            {
                int m = rnd.Next(0, 1000);
                numbers[m % 10].Enqueue(m);
                Console.Write($"{m} ");
            }

            Console.WriteLine("\n");
            
            for (var j = 0; j < numbers.Length; j++)
                if (numbers[j].Count > 0)
                {
                    Console.WriteLine($"Числа, оканчивающиеся на {j}");

                    while (numbers[j].Count > 0)
                        Console.Write($"{numbers[j].Dequeue()} ");

                    Console.WriteLine("\n");
                }
        }
    }
}
