using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] == n)
                {
                    count++;
                }

            }
            Console.WriteLine(count);

        }
    }
}
