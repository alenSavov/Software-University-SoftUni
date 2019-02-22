using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            string delimiter = Console.ReadLine();
            var firstDelimiter = delimiter[0];
            string secondDelimiter = "";

            foreach (char c in delimiter)
            {
                if (c == ' ')
                {
                    secondDelimiter = c;
                }
            }

        }
    }
}
