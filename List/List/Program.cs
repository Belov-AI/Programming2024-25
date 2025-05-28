using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 5, 4, 2, 0, -1, 7 };
            var words = new List<string> {"cab", "bbbcas", "aabc" };

            PrintList(list);
            Console.WriteLine();

            Console.WriteLine($"Число элементов {list.Count}");
            Console.WriteLine($"Число зарезервированных элементов {list.Capacity}");
            Console.WriteLine();

            QuickSortList(list);
            PrintList(list);
            Console.WriteLine();

            PrintList(words);
            QuickSortList(words);
            PrintList(words);
        }

        static void PrintList<T>(List<T> list)
        {
            foreach (var item in list)
                Console.Write($"{item} ");

            Console.WriteLine();
        }

        static void QuickSortList<T>(List<T> list)
            where T: IComparable<T>
        { 
            var left = new List<T>();
            var right = new List<T>();

            if(list.Count > 1)
            {
                var head = list[0];
                list.RemoveAt(0);

                foreach (var item in list)
                    if(item.CompareTo(head) < 0)
                        left.Add(item);
                    else
                        right.Add(item);
                list.Clear();

                QuickSortList(left);
                list.AddRange(left);
                list.Add(head);
                QuickSortList(right);
                list.AddRange(right);
            }
        }

    }
}
