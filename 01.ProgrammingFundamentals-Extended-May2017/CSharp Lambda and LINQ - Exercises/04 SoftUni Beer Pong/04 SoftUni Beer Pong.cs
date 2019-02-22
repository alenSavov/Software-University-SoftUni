using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, Dictionary<string, int>> playersInformations = new Dictionary<string, Dictionary<string, int>>();

            while (inputData[0] != "stop the game")
            {
                string playerName = inputData[0];
                string teamName = inputData[1];
                int playerPoints = int.Parse(inputData[2]);

                if (!playersInformations.ContainsKey(teamName))
                {
                    playersInformations[teamName] = new Dictionary<string, int>();
                }
                if (playersInformations[teamName].Count < 3)
                {
                    playersInformations[teamName][playerName] = playerPoints;
                }


                inputData = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            playersInformations = playersInformations
                .Where(v => v.Value.Keys.Count == 3)
                .OrderByDescending(v => v.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);

            int indexer = 1;
            foreach (var team in playersInformations)
            {
                Console.WriteLine($"{indexer}. {team.Key}; Players:");

                var player = team.Value
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var person in player)
                {
                    Console.WriteLine($"###{person.Key}: {person.Value}");
                }
                indexer++;
            }

        }
    }
}
