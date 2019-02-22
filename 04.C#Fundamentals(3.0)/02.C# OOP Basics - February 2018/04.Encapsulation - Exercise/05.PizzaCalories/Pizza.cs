using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Pizza
{
    private string name;
    private Topping topping;
    private Dough pizzaDough;

    public Pizza()
    {
        this.Toppings = new List<Topping>();
    }

    public Pizza(string name) : this()
    {
        this.Name = name;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new Exception("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }

    public Topping Topping
    {
        get { return topping; }
        set { topping = value; }
    }

    public Dough PizzaDought
    {
        get { return pizzaDough; }
        set { pizzaDough = value; }
    }

    public List<Topping> Toppings { get; }

    public void Add(Topping topping)
    {
        if (this.Toppings.Count >= 10)
        {
            throw new Exception("Number of toppings should be in range [0..10].");
        }
        this.Toppings.Add(topping);
    }

    public double PizzaCalories()
    {
        double totalToppingCalories = this.Toppings.Select(c => c.ToppingCalories()).Sum();

        return this.PizzaDought.DoughCalories() + totalToppingCalories; 
    }

}

