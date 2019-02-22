using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> primaList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                primaList = RemoveAllOccurrenses(primaList);
            }
            primaList.Sort();
            Console.WriteLine(string.Join(" ",primaList));
        }

        private static List<int> RemoveAllOccurrenses(List<int> primaList)
        {
            List<int> sequenceList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < sequenceList.Count; i++)
            {
                if (primaList.Contains(sequenceList[i]))
                {
                    primaList.Remove(sequenceList[i]);
                }
                else
                {
                    primaList.Add(sequenceList[i]);
                }

            }
            return primaList;
        }
    }
}
