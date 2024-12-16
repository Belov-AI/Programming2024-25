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
                File.Create("test.txt").Close();

            }

            Console.WriteLine(File.Exists("test.txt"));

            Console.WriteLine();

            var text = File.ReadAllText("test.txt");
            Console.WriteLine(text);        

            Console.WriteLine();

            File.WriteAllText("test.txt", "Новая строка");

            var lines = File.ReadAllLines("test.txt");

            foreach (var line in lines)
                Console.WriteLine(line);

            Console.WriteLine();

            File.WriteAllLines("test.txt",
                    new[]
                    {
                        "Японские очки",
                        "Куда вы пропали?"
                    }
                );

            File.AppendAllText("test.txt", "Никак не найду");

            lines = File.ReadAllLines("test.txt");

            foreach (var line in lines)
                Console.WriteLine(line);

            Console.WriteLine();

            using(var stream = new StreamReader("test.txt"))
            {
                while (!stream.EndOfStream)
                {
                    var s = stream.ReadLine();
                    Console.WriteLine(s);
                }
            }

            var file = new FileInfo("test.txt");

            if(file.Exists)
            {
                Console.WriteLine(file.Name);
            }

            Console.WriteLine(Directory.GetCurrentDirectory());

            //File.Delete("test.txt");
            //Console.WriteLine(File.Exists("test.txt"));

            Console.ReadKey();
        }
    }
}
