using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры матрицы A через пробел");
            var input = Console.ReadLine();

            int m, k, l, n;

            var dimensions = input.Split();
            m = int.Parse(dimensions[0]);
            k = int.Parse(dimensions[1]);

            Console.WriteLine("Введите размеры матрицы B через пробел");
            input = Console.ReadLine();

            dimensions = input.Split();
            l = int.Parse(dimensions[0]);
            n = int.Parse(dimensions[1]);

            if (k != l)
            {
                Console.WriteLine("Матрицы таких размеров перемножать нельзя");
                Console.ReadKey();
                return;            
            }

            Console.WriteLine("Введите матрицу A строкам через пробел");
            var a = InputMatrix(m, k);

            Console.WriteLine("Введите матрицу B строкам через пробел");
            var b = InputMatrix(l, n);

            Console.WriteLine("Произведение матриц AB:");
            PrintMatrix(MuliplyMatrixes(a, b));

            Console.ReadKey();
        }

        static double[,] InputMatrix(int rows, int columns)
        {
            var matrix = new double[rows, columns];

            for (var i = 0; i < rows; i++)
            {
                var input = Console.ReadLine();
                var elements = input.Split();

                for (var j = 0; j < columns; j++)
                    matrix[i, j] = double.Parse(elements[j]);
            }
            
            return matrix;
        }

        static double[,] MuliplyMatrixes(double[,] a, double[,] b)
        {
            if(a.GetLength(1) != b.GetLength(0)) 
            {
                throw new ArgumentException("Недопустимые рамеры матриц");
            }

            var c = new double[a.GetLength(0), b.GetLength(1)];

            for(var i = 0; i < c.GetLength(0); i++) 
                for(var j = 0;j < c.GetLength(1); j++)
                {
                    c[i, j] = 0;
                    for (var k = 0; k < a.GetLength(1); k++)
                        c[i, j] += a[i, k] * b[k, j];                
                }

            return c;
        }

        static void PrintMatrix(double[,] matrix)
        {
            for(var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],5:F2} ");

                Console.WriteLine();
            }
        }
    }
}
