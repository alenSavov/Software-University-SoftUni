using System;
using System.Linq;

namespace _4._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeMatrix = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rowsSize = sizeMatrix[0];
            var columsSize = sizeMatrix[1];
            int[,] matrix = new int[rowsSize, columsSize];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var values = Console.ReadLine()
                     .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
                for (int colums = 0; colums < matrix.GetLength(1); colums++)
                {
                    matrix[rows, colums] = values[colums];
                }
            }
            int currentSum = 0;
            int maxSum = 0;
            var rowIndex = 0;
            var columIndex = 0;
            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int colums = 0; colums < matrix.GetLength(1) - 2; colums++)
                {
                    currentSum = 0;
                    currentSum += matrix[rows, colums] + matrix[rows, colums + 1] + matrix[rows, colums + 2]
                     + matrix[rows + 1, colums] + matrix[rows + 1, colums + 1] + matrix[rows + 1, colums + 2]
                         + matrix[rows + 2, colums] + matrix[rows + 2, colums + 1] + matrix[rows + 2, colums + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowIndex = rows;
                        columIndex = colums;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Sum = {maxSum}");
            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int colums = 0; colums < matrix.GetLength(1) - 2; colums++)
                {
                    if (rows >= 1 || colums >= 1)
                    {
                        break; ;
                    }
                    Console.Write(matrix[rowIndex, columIndex] + " " + matrix[rowIndex, columIndex + 1] + " " + matrix[rowIndex, columIndex + 2]);
                    Console.WriteLine();
                    Console.Write( matrix[rowIndex + 1, columIndex] + " " + matrix[rowIndex + 1, columIndex + 1] + " " + matrix[rowIndex + 1, columIndex + 2]);
                    Console.WriteLine();
                    Console.Write(matrix[rowIndex + 2, columIndex] + " " + matrix[rowIndex + 2, columIndex + 1] + " " + matrix[rowIndex + 2, columIndex + 2]);
                    Console.WriteLine();
                }
            }
        }
    }
}