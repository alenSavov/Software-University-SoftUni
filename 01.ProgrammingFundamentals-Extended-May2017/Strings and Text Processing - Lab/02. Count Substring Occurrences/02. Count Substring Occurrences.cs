using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string searchedString = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(searchedString);

            while (index != -1)
            {
                counter++;
                index = input.IndexOf(searchedString, index + 1);
            }

            Console.WriteLine(counter);




        }
    }
}
