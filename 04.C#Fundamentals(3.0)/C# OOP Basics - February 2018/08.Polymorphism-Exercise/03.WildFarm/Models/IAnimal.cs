using System;
using System.Collections.Generic;
using System.Text;


public interface IAnimal
{
    string Name { get; }
    double Weight { get; }
    double FoodEaten { get; }

    string ProduceSound();
    void IncreaseWeight(Food food);
}

