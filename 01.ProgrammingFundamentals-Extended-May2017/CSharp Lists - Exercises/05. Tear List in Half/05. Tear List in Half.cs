using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> leftHalf = new List<int>();
            List<int> rightHalf = new List<int>();

            
            for (int i = 0; i < inputNumbers.Count / 2; i++)
            {
                leftHalf.Add(inputNumbers[i]);     
            }

            for (int i = inputNumbers.Count / 2; i < inputNumbers.Count; i++)
            {
                rightHalf.Add(inputNumbers[i]);
            }

            List<int> result = new List<int>();

            for (int i = 0; i < rightHalf.Count; i++)
            {
                //separete the number and get the first digit and last digit
                var leftNum = leftHalf[i];
               var rightNum = rightHalf[i];

                //add the numbers to the new list
                var first = rightNum / 10;
                var second = rightNum % 10;

                result.Add(first);
                result.Add(leftNum);
                result.Add(second);
            }                               
                Console.WriteLine(string.Join(" ", result));
      
        }
    }
}
