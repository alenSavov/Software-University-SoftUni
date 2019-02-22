using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        var carsData = new List<Cars>().Distinct().ToList();

        for (int i = 0; i < numberOfCars; i++)
        {
            var carsInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var model = carsInput[0];
            var fuelAmount = double.Parse(carsInput[1]);
            var fuelConsumptionPerKm = double.Parse(carsInput[2]);
            var distanceTravel = 0;


            Cars car = new Cars(model, fuelAmount, fuelConsumptionPerKm, distanceTravel);
            carsData.Add(car);
        }

        var input = Console.ReadLine();
        while (input != "End")
        {
            var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var model = inputTokens[1];
            var amountKm = double.Parse(inputTokens[2]);

            
            Cars carToDrive = carsData.First(c => c.Model == model);
            carToDrive.CarMove(amountKm);
                      
            input = Console.ReadLine();
        }
        
        foreach (var car in carsData)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmout:F2} {car.DistanceTraveled}");
        }
    }
}
