using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeMatrix = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[sizeMatrix[0], sizeMatrix[1]];

            for (int rows = 0; rows < sizeMatrix[0]; rows++)
            {
                var rowValues = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int colums = 0; colums < sizeMatrix[1]; colums++)
                {
                    matrix[rows, colums] = rowValues[colums];
                }
            }

            int sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int colums = 0; colums < matrix.GetLength(1); colums++)
                {
                    sum += matrix[rows, colums];
                }
            }

            Console.WriteLine();
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
