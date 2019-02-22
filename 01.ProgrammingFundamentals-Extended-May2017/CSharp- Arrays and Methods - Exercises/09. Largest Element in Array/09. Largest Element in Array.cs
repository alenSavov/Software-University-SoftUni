using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] array = new int[numberOfLines];
            int largestELement = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                largestELement = array.Max();
            }
            Console.WriteLine(largestELement);

        }
    }
}
