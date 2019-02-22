using System;
using System.Linq;

namespace _2._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            long primaryDiagonal = 0;
            long secondaryDiagonal = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                primaryDiagonal += matrix[row][row];
                secondaryDiagonal += matrix[row][matrix.Length - 1 - row];
            }
            long absDifference = Math.Abs(primaryDiagonal - secondaryDiagonal);
            Console.WriteLine(absDifference);
        }

        
    }
}
