using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parser = n => double.Parse(n);

             Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Select(n => n * 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:f2}"));

           
        }
    }
}
