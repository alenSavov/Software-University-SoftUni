using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        while (input != "end")
        {
            var workingString = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s.Trim())
            .ToArray();
            var values = workingString[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();
            for (int i = 0; i < values.Length; i++)
            {
                if (workingString[0].Contains("{" + i + "}"))
                {
                    workingString[0] = workingString[0].Replace("{" + i + "}", values[i]);
                }
            }
            Console.WriteLine(workingString[0]);
            input = Console.ReadLine();
        }
    }
}