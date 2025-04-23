using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballChampionships
{
    class Program
    {
        static void Main(string[] args)
        {
            var champions = new Dictionary<string, int>();

            using (var file = new StreamReader("football.txt", Encoding.Default))
            {
                while (!file.EndOfStream)
                {
                    var team = file.ReadLine().Split('\t')[1];
                    
                    if(champions.ContainsKey(team))
                        champions[team]++;
                    else 
                        champions[team] = 1;
                }
            }

            PrintDictionary(champions);

            var sortedChamions = new SortedDictionary<string, int>(champions);

            Console.WriteLine();
            PrintSortedDictionary(sortedChamions);
        }

        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach(var item in dict)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }

        static void PrintSortedDictionary(SortedDictionary<string, int> dict)
        {
            foreach (var item in dict)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }


    }
}
