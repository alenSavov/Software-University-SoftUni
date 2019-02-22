using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            

            for (int i = integers.Count - 1; i >= 0; i--)
            {
                Console.Write(integers[i] + " ");
            }
        }
    }
}