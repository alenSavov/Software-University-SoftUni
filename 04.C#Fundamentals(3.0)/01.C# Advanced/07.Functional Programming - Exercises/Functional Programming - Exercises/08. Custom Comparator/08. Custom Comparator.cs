using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            Func<int, bool> filterForEven = n => n % 2 == 0;
            Func<int, bool> filterForOdd = n => n % 2 != 0;

            var tempListEven = numbers.Where(filterForEven).ToList();
            tempListEven.Sort();
            var tempListOdd = numbers.Where(filterForOdd).ToList();
            tempListOdd.Sort();

            var resultList = new List<int>();
            resultList.AddRange(tempListEven);
            resultList.AddRange(tempListOdd);

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
