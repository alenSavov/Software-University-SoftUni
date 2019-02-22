using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01__Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<string> results = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    results.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join("",results));
        }
    }
}
