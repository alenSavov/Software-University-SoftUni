using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { " -> " },StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List<int>> wood = new Dictionary<string, List<int>>();
            int materialCount = 0;

            while (input[0] != "chop chop")
            {
                string types = input[0];
                int height = int.Parse(input[1]);

                if (!wood.ContainsKey(types))
                {
                    wood[types] = new List<int>();
                }

                wood[types].Add(height);
                materialCount++;

                input = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            }            

            int totalMaterialIsReady = 0;
            foreach (var mats in wood)
            {
                totalMaterialIsReady += mats.Value.Sum();
            }

            string type = Console.ReadLine();
            int metersNeeded = int.Parse(Console.ReadLine());

            var usedLogs = wood[type]
                .ToList()
                .Where(item => item >= metersNeeded)
                .ToList();

            int usedLogsSum = usedLogs.Sum();

            double pricePerMeter = Math.Round((totalMaterialIsReady / (double)materialCount), 2);
            double usedLogPrice = Math.Round((usedLogsSum * pricePerMeter), 2);
            double unusedLogPrice = Math.Round(((totalMaterialIsReady - usedLogsSum) * pricePerMeter * 0.25), 2);
            double totalCottageScrapper = Math.Round((usedLogPrice + unusedLogPrice), 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalCottageScrapper:f2}");
        }
    }
}
