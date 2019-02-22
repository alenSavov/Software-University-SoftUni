using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.list
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var divisors = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            var divisibleNumbers = GetDivisibleNumbers(n, divisors);
            Console.WriteLine(string.Join(" ", divisibleNumbers));           

        }

        private static List<int> GetDivisibleNumbers(int n, List<int> divisors)
        {
            var divisibleNumbers = new List<int>();

            for (int num = 1; num <= n; num++)
            {
                var isDivisible = true;

                foreach (var d in divisors)
                {
                    Predicate<int> isNoDivisor = x => num % x != 0;

                    if (isNoDivisor(d))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    divisibleNumbers.Add(num);
                }
            }
            return divisibleNumbers;
        }
    }
}
