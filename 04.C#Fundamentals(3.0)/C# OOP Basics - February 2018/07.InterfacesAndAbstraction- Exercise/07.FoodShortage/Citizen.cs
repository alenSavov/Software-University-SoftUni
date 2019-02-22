using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IBuyer
{
    public Citizen(string name, int age, string id, string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthday;
        this.Food = 0;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public string Id { get; private set; }

    public string Birthdate { get; private set; }

    public int Food { get; private set; }

    public void BuyFood()
    {
        Food += 10;
    }
}

