using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstNumber = numbers[0];
            var lastNumber = numbers[numbers.Count - 1];

            numbers.RemoveAt(0);
            numbers.RemoveAt(numbers.Count - 1);

            numbers.Reverse();

            numbers.Add(lastNumber);
            numbers.Insert(0, firstNumber);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
