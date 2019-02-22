namespace _02.Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, string> defaultValue = new Dictionary<string, string>();

            while (input[0] != "end")
            {
                string key = input[0];
                string value = input[1];

                defaultValue[key] = value;

                input = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            string givenDefaultValue = Console.ReadLine();

            Dictionary<string, string> originalValues = defaultValue
                .Where(a => a.Value != "null")
                .OrderByDescending(v => v.Value.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            Dictionary<string, string> nullValues = defaultValue
                .Where(v => v.Value == "null")
                .ToDictionary(k => k.Key, v => givenDefaultValue);

            Dictionary<string, string> result = originalValues
                .Concat(nullValues)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

        }
    }
}