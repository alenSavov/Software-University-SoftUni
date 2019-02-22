using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regexHappyEmo = new Regex(@"((:\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;))");
            var regexSadEmo = new Regex(@"((:\(|D\:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|\];))");

            var happyMatch = regexHappyEmo.Matches(input);
            var sadMatch = regexSadEmo.Matches(input);

            double countHappyEmo = 0;
            double countSadEmo = 0;

            foreach (Match match in happyMatch)
            {
                countHappyEmo = happyMatch.Count;
            }
            foreach (Match match in sadMatch)
            {
                countSadEmo = sadMatch.Count;
            }
            double happyIndex = countHappyEmo / countSadEmo;
            if (happyIndex < 1)
            {
                Console.WriteLine($"Happiness index: {happyIndex:F2} :(");
                Console.WriteLine($"[Happy count: {countHappyEmo}, Sad count: {countSadEmo}]");
            }
            else if (happyIndex == 1)
            {
                Console.WriteLine($"Happiness index: {happyIndex:F2} :|");
                Console.WriteLine($"[Happy count: {countHappyEmo}, Sad count: {countSadEmo}]");
            }
            else if (happyIndex > 1.00 && happyIndex < 2.00)
            {
                Console.WriteLine($"Happiness index: {happyIndex:F2} :)");
                Console.WriteLine($"[Happy count: {countHappyEmo}, Sad count: {countSadEmo}]");
            }
            else if (happyIndex >= 2)
            {
                Console.WriteLine($"Happiness index: {happyIndex:F2} :D");
                Console.WriteLine($"[Happy count: {countHappyEmo}, Sad count: {countSadEmo}]");
            }
        }
    }
}
