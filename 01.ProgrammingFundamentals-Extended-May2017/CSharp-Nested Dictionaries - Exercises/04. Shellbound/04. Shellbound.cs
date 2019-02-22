using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            var dict = new Dictionary<string, HashSet<int>>();

            while (input[0] != "Aggregate")
            {
                string city = input[0];
                int shells = int.Parse(input[1]);

                if (!dict.ContainsKey(city))
                {
                    dict[city] = new HashSet<int>();
                }
                dict[city].Add(shells);

                input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var item in dict)
            {
                int gianShell = item.Value.Sum() - (int)item.Value.Average();
                Console.WriteLine($"{item.Key} -> {string.Join(", ",item.Value)} ({gianShell})");
            }
        }
    }
}
