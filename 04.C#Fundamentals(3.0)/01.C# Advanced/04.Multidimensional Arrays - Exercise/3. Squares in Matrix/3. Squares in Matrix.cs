using System;
using System.Linq;
using System.Text;

namespace _3._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[size[0], size[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                var values = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int colums = 0; colums < matrix.GetLength(1); colums++)
                {
                    matrix[rows, colums] = values[colums];
                }

            }            
            var countEqualCells = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int colums = 0; colums < matrix.GetLength(1) - 1; colums++)
                {                    
                    var sb = new StringBuilder();
                    var currentCells = matrix[row, colums] + matrix[row, colums + 1]
                                        + matrix[row + 1, colums] + matrix[row + 1, colums +1];
                    sb.Append(currentCells).ToString();
                    if (sb[0] == sb[1] && sb[0] == sb[2] && sb[0] == sb[3])
                    {
                        countEqualCells++;
                    }
                }
            }
            Console.WriteLine(countEqualCells >= 1 ? countEqualCells : countEqualCells);   
           
                       
        }
    }
}
