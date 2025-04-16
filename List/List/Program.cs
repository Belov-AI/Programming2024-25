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

            PrinList(list);
            Console.WriteLine();

            Console.WriteLine($"Число элементов {list.Count}");
            Console.WriteLine($"Число зарезервированных элементов {list.Capacity}");
            Console.WriteLine();

            QuickSortList(list);
            PrinList(list);

        }

        static void PrinList(List<int> list)
        {
            foreach (var item in list)
                Console.Write($"{item} ");

            Console.WriteLine();
        }

        static void QuickSortList(List<int> list) 
        { 
            var left = new List<int>();
            var right = new List<int>();

            if(list.Count > 1)
            {
                var head = list[0];
                list.RemoveAt(0);

                foreach (var item in list)
                    if(item <  head)
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
