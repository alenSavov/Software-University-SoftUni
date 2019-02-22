using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    public const string NAME_ERROR = "Name cannot be empty";
    public const string MONEY_ERROR = "Money cannot be negative";

    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.BagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(NAME_ERROR);
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(MONEY_ERROR);
            }
            this.money = value;
        }
    }

    public List<Product> BagOfProducts
    {
        get { return bagOfProducts; }
        set { bagOfProducts = value; }
    }

    public void Print()
    {

        if (this.BagOfProducts.Count != 0)
        {
            Console.WriteLine($"{this.Name} - {string.Join(", ", bagOfProducts)}");
        }
        else
        {
            Console.WriteLine($"{this.Name} - Nothing bought");
        }

    }

}

