using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new Table(15, 0, 0.5);

            table.Print("y = x^2", x => x * x);

            table.Print("y = x^3", x => x * x * x);
        }
    }
}
