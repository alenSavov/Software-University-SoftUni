using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Reverse().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
