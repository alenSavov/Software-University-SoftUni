using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            int n = int.Parse(Console.ReadLine());
            Func<int, bool> filter = num => num % n != 0;

            var remainingNumbers = numbers.Reverse().Where(filter);
            Console.WriteLine(string.Join(" ",remainingNumbers));
          

        }
       
    }
}
