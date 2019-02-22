using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallestElements = 1000000000;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallestElements)
                {
                    smallestElements = array[i];

                }

            }
            Console.WriteLine(smallestElements);
        }
    }
}
