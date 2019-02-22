using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    chars[i] -= (char)numbers[i];
                }
                else
                {
                    chars[i] += (char)numbers[i];
                }
                Console.Write(chars[i]);
            }
            Console.WriteLine();
        }
    }
}
