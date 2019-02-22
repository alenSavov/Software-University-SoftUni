using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();

            var ccc = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string continent = input[0];
                string country = input[1];
                string citie = input[2];

                if (!ccc.ContainsKey(continent))
                {
                    ccc[continent] = new Dictionary<string, List<string>>();
                }

                if (!ccc[continent].ContainsKey(country))
                {
                    ccc[continent][country] = new List<string>();
                }
                ccc[continent][country].Add(citie);
            }

            foreach (var continent in ccc)
            {
                Console.WriteLine($"{continent.Key}: ");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }

        }
    }
}
