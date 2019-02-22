using System;
using System.Linq;

namespace _2._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeMatrix = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var sizeRows = sizeMatrix[0];
            var sizeColums = sizeMatrix[1];
            int[,] matrix = new int[sizeRows, sizeColums];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var rowValues = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int colums = 0; colums < matrix.GetLength(1); colums++)
                {
                    matrix[rows, colums] = rowValues[colums];
                }
            }
            var sum = 0;
            var rowIndex = 0;
            var columIndex = 0;

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int colums = 0; colums < matrix.GetLength(1) - 1; colums++)
                {
                    var currentSum = matrix[rows, colums] + matrix[rows, colums + 1]
                                    + matrix[rows + 1, colums] + matrix[rows + 1, colums + 1];

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        rowIndex = rows;
                        columIndex = colums;
                    }
                }
            }

            Console.WriteLine(matrix[rowIndex, columIndex] + " " + matrix[rowIndex, columIndex + 1]);
            Console.WriteLine(matrix[rowIndex + 1, columIndex] + " " + matrix[rowIndex + 1, columIndex + 1]);
            Console.WriteLine(sum);
        }
    }
}
