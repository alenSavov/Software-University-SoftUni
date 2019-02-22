using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Append_Lists
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();


            var itemResults = new List<string>();

            foreach (var item in items)
            {
                List<string> numbers = item.Split(' ').ToList();

                foreach (var num in numbers)
                {
                    if (num != "") itemResults.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", itemResults));
        }
    }
}