using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");

            }

        }
    }
}
