using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> minFunc = GetMin;

            var minNumber = minFunc(inputNumbers);
            Console.WriteLine(minNumber);
        }

        private static int GetMin(List<int> numbers)
        {
            int min = int.MaxValue;

            foreach (var num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
