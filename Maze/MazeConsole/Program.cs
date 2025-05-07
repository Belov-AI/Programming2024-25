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
            var maze = new Maze(55,15);

            var path = new Stack<Cell>();

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
            
            for(var j = 0; j < maze.Width; j++)
                Console.Write(j % 10);
            Console.WriteLine();
        }
    }
}
