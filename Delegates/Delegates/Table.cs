using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Table
    {
        public int RowsNumber { get; set; }
        public double Start { get; set; }
        public double Step { get; set; }

        public Table(int rows, double start, double step) 
        { 
            RowsNumber = rows;
            Start = start;
            Step = step;
        }

        public void Print(string name, Func<double, double> fuction)
        {
            var horizontalLine = new String('-', 17);

            Console.WriteLine(horizontalLine);
            Console.WriteLine("|   x   | " + name);
            Console.WriteLine(horizontalLine);

            var x = Start;

            for (var i = 0; i < RowsNumber; i++)
            {
                Console.WriteLine($"| {x,5:F2} | {fuction(x):F3}");
                x += Step;
            }

            Console.WriteLine(horizontalLine + "\n");
        }
    }
}
