using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static Dictionary<char, char> brackets = new Dictionary<char, char>();
        // ключ - закрыв. скобка, значение - открыв. скобка
        static void Main(string[] args)
        {
            brackets[')'] = '(';
            brackets[']'] = '[';
            brackets['»'] = '«';

            while (true) 
            {
                Console.WriteLine("Введите выражение со скобками. Enter - выход");
                var input = Console.ReadLine();

                if (input.Length == 0) break;

                if (IsExpessionCorrect(input))
                    Console.WriteLine("Скобки расставлены верно");
                else
                    Console.WriteLine("Скобки расставлены неверно");

                Console.WriteLine();

            }
        }

        static bool IsExpessionCorrect(string expression)
        {
            var stack = new Stack<char>();

            foreach (char c in expression)
                if (brackets.ContainsValue(c))
                    stack.Push(c);
                else if (brackets.ContainsKey(c) &&
                    (stack.Count == 0 || stack.Pop() != brackets[c]))
                    return false;

            return stack.Count == 0;
        }
    }
}
