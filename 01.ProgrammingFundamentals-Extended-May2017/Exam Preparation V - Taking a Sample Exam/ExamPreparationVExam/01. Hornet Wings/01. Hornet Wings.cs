using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wingFlaps = decimal.Parse(Console.ReadLine());
            decimal distance = decimal.Parse(Console.ReadLine());
            decimal endurance = decimal.Parse(Console.ReadLine());

            decimal distanceResult = (wingFlaps / 1000) * distance;
            decimal hornetFlapsResult = wingFlaps / 100;
            int restsFor5Sec = (int)(wingFlaps / endurance) * 5;
            int result = (int)restsFor5Sec + (int)hornetFlapsResult;
                               
                           

            Console.WriteLine($"{distanceResult:F2} m.");
            Console.WriteLine($"{result} s.");


        }
    }
}
