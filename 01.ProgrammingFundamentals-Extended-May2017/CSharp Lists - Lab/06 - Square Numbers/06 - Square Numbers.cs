using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var resultNumbers = new List<int>();


            for (int i = 0; i < squareNumbers.Count; i++)
            {
                var square = Math.Sqrt(squareNumbers[i]);

                if (square == (int)square)
                {
                    resultNumbers.Add(squareNumbers[i]);
                }

            }
            resultNumbers.Sort();
            resultNumbers.Reverse();

            Console.WriteLine(string.Join(" ",resultNumbers));
        }
    }
}
