using System;


namespace Chessboard
{
    class Program
    {
        static void Main()
        {
            int boardSize;

            //Здесь ввод размера доски.
            //оформите его в виде бесконечного цикла с проверкой,
            //что 1<= boardSize <= 26
            //и предложением повторного ввода, если условие не выполняется
            //Предусмотрите отказ от ввода (с последующим завершением программы).

            while (true)
            {
                Console.WriteLine("Введите размер доски");
                boardSize = int.Parse(Console.ReadLine());
                if (boardSize < 1 || boardSize > 26)
                {
                    Console.WriteLine("Допустисый размер от 1 до 26");
                    continue;
                }
                else
                    break;
            }
            
            PrintBoard(boardSize);           

            Console.ReadKey();
        }

        static void PrintBoard(int size)
        {
            //написать метод печати шахматной доски размера (size x size)

            const ConsoleColor Dark = ConsoleColor.DarkBlue;
            const ConsoleColor Light = ConsoleColor.White;

            PrintHeader(size);

            for (var i = size; i > 0; i--)
            {
                Console.Write($"{i,2}");

                ConsoleColor color;
                if (i % 2 == 0)
                    color = Light;
                else
                    color = Dark;

                for (var j = 0; j< size; j++)
                {
                    PrintSquare(color);

                    if (color == Light)
                        color = Dark;
                    else
                        color = Light;
                }

                Console.WriteLine(i);
            }

            PrintHeader(size);
        }

        static void PrintHeader(int size)
        {
            Console.Write("  ");
            for (int i = 0; i < size; i++)
                Console.Write((char)(0x61 + i));

            Console.WriteLine();
        }

        /// <summary>
        /// Печать квадрата нужного цвета
        /// </summary>
        /// <param name="color">Цвет квадрата</param>
        static void PrintSquare(ConsoleColor color)
        {
            const char square = (char)0x2588;

            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(square);
            Console.ForegroundColor = defaultColor;
        }
    }
}
