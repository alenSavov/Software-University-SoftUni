using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            var stackMax = new Stack<long>();
            stackMax.Push(long.MinValue);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                switch (command[0])
                {
                    case 1:
                        if (command.Length > 1)
                        {
                            stack.Push(command[1]);
                            if (command[1] >= stackMax.Peek())
                            {
                                stackMax.Push(command[1]);
                            }
                        }
                        break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            var popped = stack.Pop();

                            if (popped == stackMax.Peek())
                            {
                                stackMax.Pop();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine(stackMax.Peek());
                        break;
                }
            }
        }
    }
}
