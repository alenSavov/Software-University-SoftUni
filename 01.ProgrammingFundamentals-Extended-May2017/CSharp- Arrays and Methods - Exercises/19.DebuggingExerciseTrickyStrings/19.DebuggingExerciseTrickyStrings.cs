using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.DebuggingExerciseTrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            string[] currentString = new string[numberOfStrings];


            for (int i = 0; i < numberOfStrings; i++)
            {
                currentString[i] = Console.ReadLine();
            }
            Console.Write(string.Join(delimiter,currentString));
            Console.WriteLine();
        }
    }
}

