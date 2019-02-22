using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string temp = string.Empty;

            for (int write = 0; write < input.Count; write++)
            {
                for (int sort = 0; sort < input.Count - 1; sort++)
                {
                    if (string.Compare(input[sort] , input[sort + 1]) > 0)
                    {
                        temp = input[sort + 1];
                        input[sort + 1] = input[sort];
                        input[sort] = temp;

                    }
                }
            }
                Console.Write(string.Join(" ",input));
                Console.WriteLine();
            
        }
    }
}
