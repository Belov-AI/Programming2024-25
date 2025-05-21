using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MazeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            GetNumbers("Введите ширину и высоту лабиринта (от 5 до 79) через пробел",
                out n, out m);


            var maze = new Maze(n, m);

            var path = new Stack<Cell>();

            DispayMaze(maze, path);

            int startColumn, startRow;
            GetNumbers("Введите строку и столбец начала пути через пробел",
                out startRow, out startColumn);

            int endColumn, endRow;
            GetNumbers("Введите строку и столбец   конца пути через пробел",
                out endRow, out endColumn);

            path = maze.MakePath(maze.Board[startRow, startColumn], maze.Board[endRow, endColumn]);

            DispayMaze(maze, path);
        }

        static void DispayMaze(Maze maze, Stack<Cell> path)
        {
            PrintColumnNumbers(maze);

            for (var i = 0; i < maze.Height; i++)
            {
                Console.Write($"{i,2}");

                for (var j = 0; j < maze.Width; j++)
                    if (maze.Board[i, j].Wall)
                        Console.Write((char)0x2588);
                    else if (path.Contains(maze.Board[i, j]))
                        Console.Write('*');
                    else
                        Console.Write(' ');

                Console.WriteLine();
            }

            PrintColumnNumbers(maze);

        }

        static void PrintColumnNumbers(Maze maze)
        {
            Console.Write("  ");

            for (var j = 0; j < maze.Width; j++)
                Console.Write(j % 10);
            Console.WriteLine();
        }

        static void GetNumbers(string message, out int n, out int m)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var numbers = input.Split();

            n = int.Parse(numbers[0]);
            m = int.Parse(numbers[1]);
        }
    }
}
