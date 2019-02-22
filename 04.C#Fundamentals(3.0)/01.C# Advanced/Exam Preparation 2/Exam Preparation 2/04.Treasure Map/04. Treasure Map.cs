using System;
using System.Text.RegularExpressions;

namespace _04.Treasure_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"((?<hash>#)|!)[^#!]*?(?<![\w])(?<streetName>[\w]{4})(?![\w])[^#!]*(?<!\d)(?<streetNumber>\d{3})-(?<password>\d{4}|\d{6})(?!\d)[^#!]*?(?(hash)!|#)";
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, pattern);

                  var correctMatch = matches[matches.Count / 2];
                
                string streetName = correctMatch.Groups["streetName"].Value;
                string streetNumber = correctMatch.Groups["streetNumber"].Value;
                string password = correctMatch.Groups["password"].Value;

                Console.WriteLine($"Go to str. {streetName} {streetNumber}. Secret pass: {password}.");
            }
        }
    }
}
