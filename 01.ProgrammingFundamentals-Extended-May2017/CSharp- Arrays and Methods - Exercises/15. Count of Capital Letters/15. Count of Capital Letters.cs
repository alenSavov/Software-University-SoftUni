using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Count_of_Capital_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            int count = 0;
            char[] symbol = new char[1];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 1)
                {
                    continue;
                }
                else
                {
                    symbol = array[i].ToCharArray();
                }
                if (symbol[0] < 91 && symbol[0] >= 65 )
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
