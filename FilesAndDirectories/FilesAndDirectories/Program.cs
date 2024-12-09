using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAndDirectories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("test.txt")) 
            {
                File.Create("test.txt");

            }

            Console.WriteLine(File.Exists("test.txt"));

            File.Delete("test.txt");
            Console.WriteLine(File.Exists("test.txt"));

            Console.ReadKey();
        }
    }
}
