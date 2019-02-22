using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNames = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Action<IEnumerable<string>> print = collection => Console.WriteLine(string.Join(Environment.NewLine, collection.Select(name => $"Sir {name}")));
            print(inputNames);
        }
    }        
}
