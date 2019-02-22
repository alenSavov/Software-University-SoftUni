using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        var buyersData = new HashSet<IBuyer>();

        IBuyer buyer;

        for (int i = 0; i < numberOfPeople; i++)
        {
            var inputInfo = Console.ReadLine().Split();

            if (inputInfo.Length == 4)
            {
                buyer = new Citizen(inputInfo[0], int.Parse(inputInfo[1]), inputInfo[2], inputInfo[3]);
                buyersData.Add(buyer);
            }
            if (inputInfo.Length == 3)
            {
                buyer = new Rebel(inputInfo[0], int.Parse(inputInfo[1]), inputInfo[2]);
                buyersData.Add(buyer);
            }
        }

        var buyerName = Console.ReadLine();
        while (buyerName != "End")
        {
            foreach (var b in buyersData.Where(b => b.Name == buyerName))
            {
                b.BuyFood();
            }
            buyerName = Console.ReadLine();
        }

        var totalAmountOfFood = buyersData.Sum(b => b.Food);
        Console.WriteLine(totalAmountOfFood);
    }
}

