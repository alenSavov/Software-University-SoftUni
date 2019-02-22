using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (var num in input)
            {
                if (dictionary.ContainsKey(num))
                {
                    dictionary[num] += 1;
                }
                else
                {
                    dictionary.Add(num, 1);
                }
            }
            foreach (var d in dictionary.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{d.Key} -> {d.Value}");
            }

        }
    }
}
