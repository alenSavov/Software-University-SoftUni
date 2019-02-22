using System;
using System.Collections.Generic;

namespace _01._Reverse_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbers = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var stack = new Stack<string>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            Console.WriteLine(string.Join(" ", stack));

        }
    }
}
