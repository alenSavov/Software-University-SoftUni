using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexMon
{
    class Program
    {
        static void Main(string[] args)
        {
            string bojoPattern = @"([a-zA-Z]+\-[a-zA-Z]+)";
            string didiPattern = @"([^a-zA-Z-]+)";

            string input = Console.ReadLine();

            while(true)
            {
                var didiMatch = Regex.Match(input, didiPattern);
                if (!didiMatch.Success)
                {
                    break;
                }
                Console.WriteLine(didiMatch.ToString());
                var lenght = input.Length - 1;
                var index = input.IndexOf(didiMatch.ToString()[0]);
                var didiLenght = didiMatch.ToString().Length;
                var remove = index + didiLenght;
                input = input.Remove(0, remove);

                var bojoMatch = Regex.Match(input, bojoPattern);
                if (!bojoMatch.Success)
                {
                    break;
                }
                Console.WriteLine(bojoMatch.ToString());
                index = input.IndexOf(bojoMatch.ToString()[0]);
                var bojoLenght = bojoMatch.ToString().Length;
                remove = index + bojoLenght;
                input = input.Remove(0, remove);
            }
        }
    }
}
