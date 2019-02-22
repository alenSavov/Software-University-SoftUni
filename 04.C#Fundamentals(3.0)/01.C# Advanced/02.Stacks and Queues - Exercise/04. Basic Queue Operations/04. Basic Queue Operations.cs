using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var n = input[0];
            var countRemoveElements = input[1];
            var theNumber = input[2];
            var inputNumbers = Console.ReadLine()
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(inputNumbers[i]);
            }
            for (int i = 0; i < countRemoveElements; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (queue.Contains(theNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
            }

        }
    }
}
