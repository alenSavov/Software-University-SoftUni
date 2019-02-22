using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> word = new List<string>();
            List<int> occurrencecCount = new List<int>();

            List<string> input = Console.ReadLine().Split().ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (!word.Contains(input[i]))
                {
                    word.Add(input[i]);
                    occurrencecCount.Add(1);
                }
                else
                {
                    int indexOfValue = word.IndexOf(input[i]);
                    occurrencecCount[indexOfValue]++;
                }
            }

            for (int firstUnsorted = 0; firstUnsorted < occurrencecCount.Count - 1; firstUnsorted++)
            {
                var i = firstUnsorted + 1;

                while (i > 0)
                {
                    if (occurrencecCount[i - 1] < occurrencecCount[i])
                    {
                        int tempCount = occurrencecCount[i];
                        occurrencecCount[i] = occurrencecCount[i - 1];
                        occurrencecCount[i - 1] = tempCount;

                        string tempWord = word[i];
                        word[i] = word[i - 1];
                        word[i - 1] = tempWord;
                    }
                    i--;
                }
            }


            for (int i = 0; i < word.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:F2}%)",
                    word[i],
                    occurrencecCount[i],
                    ((double)occurrencecCount[i] / (double)input.Count) * 100);
            }


        }
    }
}

