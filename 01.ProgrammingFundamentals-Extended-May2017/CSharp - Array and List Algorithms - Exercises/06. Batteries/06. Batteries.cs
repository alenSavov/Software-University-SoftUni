using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "print")
            {
                if (commands == "add")
                {
                    AddElements(integersInput);  
                }
                else if (commands == "addMany")
                {
                    addManyElements(integersInput);
                }
                else if (commands == "contains")
                {
                    ContainsElement(integersInput); 
                }
                else if (commands == "remove")
                {
                    RemoveElements(integersInput);
                }
                else if (commands == "shift")
                {
                    
                }
                else if (commands == "sumPair")
                {
                    
                }
                commands = Console.ReadLine(); 
                if (commands == "print") 
                {
                    PrintResult(integersInput);
                }
            }             
             

           

        }

        private static void addManyElements(List<int> integersInput)
        {
            for (int i = 0; i < integersInput.Count; i++)
            {
                int index = int.Parse(Console.ReadLine());
                List<int> value = Console.ReadLine().Split().Select(int.Parse).ToList();
                List<int> tResult = integersInput.SelectMany(index);
                
            }
        }

        private static void AddElements(List<int> integersInput)
        {
            int[] inputIndexAndValue = new int[1];
            inputIndexAndValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            integersInput.Insert(inputIndexAndValue[0], inputIndexAndValue[1]);
        }

        private static void PrintResult(List<int> integersInput)
        {
            Console.WriteLine(string.Join(" ", integersInput));
        }

        private static void RemoveElements(List<int> integersInput)
        {
            integersInput.RemoveAt(int.Parse(Console.ReadLine()));
        }

        private static void ContainsElement(List<int> integers)
        {
            if (integers.Contains(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
