using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(Integer_to_Base(num , toBase));

        }

        private static string Integer_to_Base(long number, int toBase)
        {
            string result = string.Empty;

            while (number > 0 )
            {
                long remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;


        }
    }
}
