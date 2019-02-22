using System;
using System.Collections;
using System.Collections.Generic;

namespace _09._Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = Fibonacci(n);
            Console.WriteLine(result);
        }

        private static long Fibonacci(int n)
        {
            var stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);
            stack.Push(1);

            for (int i = 3; i <= n; i++)
            {
                long firstDigit = stack.Pop();
                long secondDigit = stack.Peek();
                stack.Push(firstDigit);

                var currentFibonacci = firstDigit + secondDigit;
                stack.Push(currentFibonacci);
            }
            return stack.Peek();
        }
    }
}
