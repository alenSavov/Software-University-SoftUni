using System;
using System.Collections.Generic;
using System.Text;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
    {
        this.FuelConsumptionPerKm += carACExtraConsumption;
    }
}

