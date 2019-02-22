using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RabbitHole
{
    public class RabbitHole
    {
        public static void Main()
        {
            List<string> command = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());

            int currentIndex = 0;
            bool isDeadFromBomb = false;

            while (energy > 0)
            {
                isDeadFromBomb = false;
                string[] currentCommand = command[currentIndex].Split('|');
                string action = currentCommand[0];

                if (action == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }

                int value = int.Parse(currentCommand[1]);

                switch (action)
                {
                    case "Left":
                        currentIndex = Math.Abs(currentIndex - value) % command.Count;
                        energy -= value;
                        break;

                    case "Right":
                        currentIndex = (currentIndex + value) % command.Count;
                        energy -= value;
                        break;

                    case "Bomb":
                        command.RemoveAt(currentIndex);
                        currentIndex = 0;
                        energy -= value;
                        isDeadFromBomb = true;
                        break;
                }

                if (command[command.Count - 1] != "RabbitHole")
                {
                    command.RemoveAt(command.Count - 1);
                }
                command.Add("Bomb|" + energy);


                if (energy <= 0 && isDeadFromBomb)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else if (energy <= 0 && !isDeadFromBomb)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
            }
        }
    }
}