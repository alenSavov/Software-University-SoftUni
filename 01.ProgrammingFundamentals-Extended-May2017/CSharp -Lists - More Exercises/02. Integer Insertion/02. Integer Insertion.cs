using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var stringInput = Console.ReadLine();
            numbers = Insertion(numbers, stringInput);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> Insertion(List<int> numbers, string stringInput)
        {
            while (stringInput != "end")
            {
                var insertIndex = int.Parse(stringInput[0].ToString());
                var number = int.Parse(stringInput);

                numbers.Insert(insertIndex, number);

                stringInput = Console.ReadLine();
            }
            return numbers;
        }
    }
}
