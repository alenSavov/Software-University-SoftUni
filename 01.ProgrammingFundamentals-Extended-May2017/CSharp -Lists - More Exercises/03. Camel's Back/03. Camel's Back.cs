using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> camels = Console.ReadLine().Split().Select(int.Parse).ToList();
            int buildings = int.Parse(Console.ReadLine());

            int roundCount = 0;

            while (camels.Count > buildings)
            {
                camels.RemoveAt(camels.Count - 1);
                camels.RemoveAt(0);
                roundCount++;
            }

            if (roundCount == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", camels)}");
            }
            else
            {
                Console.WriteLine($"{roundCount} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", camels)}");
            }

        }


    }
}

