using System;
using System.Collections.Generic;
using System.Text;


public class Product
{
    public const string NAME_ERROR = "Name cannot be empty";
    public const string MONEY_ERROR = "Money cannot be negative";

    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(NAME_ERROR);
            }
            name = value;
        }
    }

    public decimal Cost
    {
        get { return cost; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(MONEY_ERROR);
            }
            cost = value;
        }
    }

    public override string ToString()
    {
        return this.Name;
    }

}

