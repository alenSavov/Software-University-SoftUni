using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.RemoveAt(j);
                        j--;
                    }
                }
            }

            long firstListSum = firstList.Sum();
            long secondListSum = secondList.Sum();

            if (firstListSum == secondListSum)
            {
                Console.WriteLine($"Yes. Sum: {firstListSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstListSum - secondListSum)}");
            }
        }
    }
}
