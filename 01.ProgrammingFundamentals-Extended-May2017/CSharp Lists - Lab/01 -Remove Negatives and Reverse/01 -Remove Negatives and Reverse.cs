using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01__Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers.RemoveAll(number => number < 0);
            }
            
                if (numbers.Count == 0)
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    Console.WriteLine(string.Join(" ",numbers));
                }
            
           
        }
    }
}
