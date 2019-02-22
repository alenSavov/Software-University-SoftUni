using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(repeatedString(str, count));     
        }

        private static string repeatedString(string str, int count)
        {
            string repetedString = string.Empty;
            for (int i = 1; i < count; i++)
            {
                Console.Write(str , count);
            }
            return str;
        }
    }
}
