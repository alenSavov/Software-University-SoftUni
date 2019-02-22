using System;


public class Program
{
    public static void Main(string[] args)
    {       
        Dough dough;
        Pizza pizza;

        try
        {
            string[] pizzaInfo = Console.ReadLine().Split();
            string pizzaName = pizzaInfo[1];
            pizza = new Pizza(pizzaName);

            string[] doughInfo = Console.ReadLine().Split();
            string flour = doughInfo[1];
            string bakingTech = doughInfo[2];
            double weight = double.Parse(doughInfo[3]);
            dough = new Dough(flour.ToLower(), bakingTech.ToLower(), weight);

            pizza.PizzaDought = dough;

            string toppingInfo;

            while ((toppingInfo = Console.ReadLine()) != "END")
            {
                string[] toppingParams = toppingInfo.Split();

                string toppingName = toppingParams[1].ToLower();
                double toppingWeight = double.Parse(toppingParams[2]);
                Topping topping = new Topping(toppingName, toppingWeight);

                pizza.Add(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.PizzaCalories():f2} Calories.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }




    }



}

