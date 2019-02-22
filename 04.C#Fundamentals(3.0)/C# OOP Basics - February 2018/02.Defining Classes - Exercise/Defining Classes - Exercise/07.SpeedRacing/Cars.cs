using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Cars
{
    public void CarMove(double amountKm)
    {
        if (amountKm <= FuelAmout / FuelConsumptionPerKm)
        {
            DistanceTraveled += amountKm;
            FuelAmout -= FuelConsumptionPerKm * amountKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public Cars(string model, double fuelAmount, double fuelConsuptionPerKm, double distanceTravel)
    {
        Model = model;
        FuelAmout = fuelAmount;
        FuelConsumptionPerKm = fuelConsuptionPerKm;
        DistanceTraveled = distanceTravel;
    }


    public string Model { get; set; }

    public double FuelAmout { get; set; }

    public double FuelConsumptionPerKm { get; set; }

    public double DistanceTraveled { get; set; }
}

