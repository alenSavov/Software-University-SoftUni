using System;
using System.Collections.Generic;
using System.Linq;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            var matrix = new List<List<int>>(n);

            for (int i = 0; i < matrix.Count(); i++)
            {
                var values = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();


            }

        }
    }
}
