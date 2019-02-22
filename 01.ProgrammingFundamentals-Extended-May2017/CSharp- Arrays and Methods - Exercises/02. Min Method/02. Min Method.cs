using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            long num3 = long.Parse(Console.ReadLine());
            Console.WriteLine(GetMin(num1,GetMin(num2,num3)));
        }

        private static long GetMin(long number1, long number2)
        {
             return Math.Min(number1, number2);  
        }

        
    }
}
