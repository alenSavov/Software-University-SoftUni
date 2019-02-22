using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            int currentOccurences = 0;

            string lastStr = array[0];
            string strToPrint = array[0];


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == lastStr)
                {
                    currentOccurences++;
                }
                else
                {
                    if (currentOccurences == 3)
                    {
                        strToPrint = lastStr;
                    }
                    currentOccurences = 1;
                }
                lastStr = array[i];

            }
            if (currentOccurences == 3)
            {
                strToPrint = lastStr;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(strToPrint + " ");
            }
            Console.WriteLine();
        }
    }
}
