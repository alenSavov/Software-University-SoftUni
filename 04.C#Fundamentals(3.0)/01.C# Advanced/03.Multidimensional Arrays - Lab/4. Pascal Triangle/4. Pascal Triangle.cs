namespace _1.Sum_Matrix_Elements
{
    using System;
    using System.Linq;

    public class SumMatrixElements
    {
        public static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            int[][] triangle = new int[height][];
            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new int[currentHeight + 1];
                triangle[currentHeight][0] = 1;
                triangle[currentHeight][currentHeight] = 1;
                if (currentHeight >= 2)
                {
                    for (int widthCounter = 1; widthCounter < currentHeight; widthCounter++)
                    {
                        triangle[currentHeight][widthCounter] =
                            triangle[currentHeight - 1][widthCounter - 1] +
                            triangle[currentHeight - 1][widthCounter];
                    }
                }
            }
            for (int rows = 0; rows < triangle.Length; rows++)
            {
                for (int colums = 0; colums < triangle[rows].Length; colums++)
                {
                    Console.Write(triangle[rows][colums] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
