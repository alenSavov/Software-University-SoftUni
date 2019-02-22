using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (minValue > numbers[i])
                {
                    minValue = numbers[i];
                }
            }

            Console.WriteLine(string.Join(" ", minValue));
        }
    }
}
