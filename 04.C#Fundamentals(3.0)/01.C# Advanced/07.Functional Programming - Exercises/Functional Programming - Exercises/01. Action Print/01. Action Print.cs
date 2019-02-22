using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNames = Console.ReadLine()
                 .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            Action<List<string>> print = PrintName; 
            print(inputNames);
        }

        public static void PrintName(List<string> list)
        {
            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}
