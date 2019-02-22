using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfNames = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> filter = n => n.Length <= lengthOfNames;
            var result = names.Where(filter);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
