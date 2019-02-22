using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            int[] secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int m = firstLine[0];
            int n = firstLine[1];

            List<char> outputLine = secondLine
                .Where(num => (num > 64 && num < 91))
                .Skip(m)
                .Take(n)
                .Select(num => (char)num)
                .ToList();

            Console.WriteLine(string.Join("", outputLine));



        }
    }
}
