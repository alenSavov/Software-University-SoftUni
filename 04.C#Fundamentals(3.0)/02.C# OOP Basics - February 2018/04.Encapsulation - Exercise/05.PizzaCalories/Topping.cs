using System;
using System.Collections.Generic;
using System.Text;


public class Topping
{
    private const double BASE_CALORIES = 2;
    private const double MEAT_CALORIES = 1.2; 
    private const double VEGGIES_CALORIES = 0.8;
    private const double CHEESE_CALORIES = 1.1;
    private const double SAUSE_CALORIES = 0.9;

  
    private string typeTopping;
    private double weight;

    public Topping(string toppingType, double weight)
    {
        this.TypeTopping = toppingType;
        this.Weight = weight;

    }

    public string TypeTopping
    {
        get { return typeTopping; }
       private set
        {
            if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
            {
                var valueName = value[0].ToString().ToUpper() + value.Substring(1);
                throw new Exception($"Cannot place {valueName} on top of your pizza.");
            }
            typeTopping = value;
        }
    }

    public double Weight
    {
        get { return weight; }
       private set
        {
            if (value < 1 || value > 50)
            {
                var valueName = this.typeTopping[0].ToString().ToUpper() + this.typeTopping.Substring(1);
                throw new Exception($"{valueName} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public double ToppingCalories()
    {
        return BASE_CALORIES * weight * ToppingModifier(); 
    }

    private double ToppingModifier()
    {
        if (this.TypeTopping == "meat")
        {
            return MEAT_CALORIES;
        }
        else if (this.TypeTopping == "veggies")
        {
            return VEGGIES_CALORIES;
        }
        else if (this.TypeTopping == "cheese")
        {
            return CHEESE_CALORIES;
        }
        else
        {
           return SAUSE_CALORIES;
        }
    }

    public static implicit operator Topping(List<Topping> v)
    {
        throw new NotImplementedException();
    }
}

