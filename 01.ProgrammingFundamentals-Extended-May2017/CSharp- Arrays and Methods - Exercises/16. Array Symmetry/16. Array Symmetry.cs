using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            bool isSymmetryc = true;

            for (int i = 0; i < array.Length / 2 ; i++)
            {
                if (array[i] != array[array.Length - i -1])
                {
                    isSymmetryc = false;
                    break;
                }
            }
            if (isSymmetryc)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            

            
        }
    }
}
