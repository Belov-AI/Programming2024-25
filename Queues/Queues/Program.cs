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
            Console.WriteLine("Введите колочество чисел");

            var n = int.Parse(Console.ReadLine());

            var numbers = new Queue<int>[10];

            for(var i =0; i < numbers.Length; i++)
                numbers[i] = new Queue<int>();

            var rnd = new Random();


            
        }
    }
}
