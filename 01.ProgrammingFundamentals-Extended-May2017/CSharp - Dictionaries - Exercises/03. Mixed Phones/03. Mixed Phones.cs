using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputValue = Console.ReadLine().Split(new char[] { ' ', ':' }).ToArray();

            SortedDictionary<string, long> phoneEntries = new SortedDictionary<string, long>();

            while (inputValue[0] != "Over")
            {

                var firstElement = inputValue[0];
                var secondElement = inputValue[3];

                long numberOne;
                if (long.TryParse(firstElement , out numberOne))
                {                                    
                 
                    phoneEntries.Add(secondElement, numberOne);
                }
                long numberTwo;
                if (long.TryParse(secondElement, out numberTwo))
                {
                    
                    phoneEntries.Add(firstElement, numberTwo);
                }

                inputValue = Console.ReadLine().Split(new char[] { ' ', ':' }).ToArray();
            }

            foreach (var item in phoneEntries)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} ");
            }
        }
    }
}
