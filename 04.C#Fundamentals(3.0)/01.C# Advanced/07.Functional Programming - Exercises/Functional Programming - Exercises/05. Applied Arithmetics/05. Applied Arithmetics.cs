using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add": // -> add 1 to each number
                        numbers = ForEach(numbers, n => n + 1);
                        break;
                    case "subtract": // -> subtract 1 from each number
                        numbers = ForEach(numbers, n => n - 1);
                        break;
                    case "multiply": // multiply each number by 2
                        numbers = ForEach(numbers, n => n * 2);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }

        private static IEnumerable<int> ForEach(IEnumerable<int> numbers, Func<int, int> func)
        {
            return numbers.Select(n => func(n));
        }
    }
}
