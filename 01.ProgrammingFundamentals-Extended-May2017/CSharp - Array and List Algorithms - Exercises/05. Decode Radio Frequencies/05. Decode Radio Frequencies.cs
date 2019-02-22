using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputFrequencies = Console.ReadLine()
                .Split()
                .ToList();

            List<char> endMessage = new List<char>();

            for (int i = 0; i < inputFrequencies.Count; i++)
            {
                string[] tokens = inputFrequencies[i].Split('.');

                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char)firstFreq;
                char secondLetter = (char)secondFreq;

                if (firstLetter != 0)
                {
                    endMessage.Insert(i, firstLetter);
                }
                if (secondLetter != 0)
                {
                    endMessage.Insert(endMessage.Count - 1 - i , secondLetter);
                }

            }
            endMessage.Reverse();
            Console.WriteLine(string.Join("" , endMessage));

        }
    }
}
