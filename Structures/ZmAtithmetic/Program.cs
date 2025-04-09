using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structures;

namespace ZmAtithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Zm(11, 51);
            var y = new Zm(11, 10);

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} * {y} = {x * y}");


        }
    }
}
