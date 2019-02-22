using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfLenght = int.Parse(Console.ReadLine());
            int[] array = new int[numberOfLenght];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
                
            }
            Console.WriteLine(sum);
            
        }
    }
}
