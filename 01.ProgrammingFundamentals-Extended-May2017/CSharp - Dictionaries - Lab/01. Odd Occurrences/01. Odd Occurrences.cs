using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<string> words = Console.ReadLine().ToLower().Split().ToList();
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts.Add(word, 1);
                }
            }
                var results = new List<string>();

                foreach (var pair in counts)
                {
                    if (pair.Value % 2 != 0)
                    {
                        results.Add(pair.Key);
                    }

                }
                  Console.WriteLine(string.Join(", " , results));
                
            
            
        }
    }
}
