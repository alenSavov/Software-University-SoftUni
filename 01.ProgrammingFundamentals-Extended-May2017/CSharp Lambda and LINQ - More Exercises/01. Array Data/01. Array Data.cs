using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console.ReadLine()
                .Split( ' ' )
                .Select(int.Parse)
                .ToList();


            initialList = initialList
                .Where(num => num >= initialList.Average())
                .OrderBy(num => num)
                .ToList();
            
            string command = Console.ReadLine();
            switch (command)
            {
                
                case "Max":
                    Console.WriteLine(initialList.Max());
                    break;

                case "Min":
                    Console.WriteLine(initialList.Min());                     
                    break;


                case "All":
                    Console.WriteLine(string.Join(" ", initialList));
                    break;
            }
        }
    }
}
