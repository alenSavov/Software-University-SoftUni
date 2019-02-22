using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputSequence = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, HashSet<string>> topics = new Dictionary<string, HashSet<string>>();

            while (inputSequence[0] != "filter")
            {
                string nameOfTopics = inputSequence[0];
                List<string> nameOfTags = inputSequence[1]
                    .Split(new string[] { ", "},StringSplitOptions.RemoveEmptyEntries).ToList();
                

                if (!topics.ContainsKey(nameOfTopics))
                {
                    topics[nameOfTopics] = new HashSet<string>();
                }
                foreach (var tag in nameOfTags)
                {
                    topics[nameOfTopics].Add(tag);
                }

                
                inputSequence = Console.ReadLine()
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            string[] inputLine = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();


            foreach (var item in topics)
            {
                bool contains = true;

                for (int i = 0; i < inputLine.Length; i++)
                {
                    if (!item.Value.Contains(inputLine[i]))
                    {
                        contains = false;
                        break;
                    }
                }

                if (contains)
                {
                    Console.WriteLine($"{item.Key} | #{string.Join(", #", item.Value)}");
                }
            }


        }
    }
}
