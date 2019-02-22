using System;
using System.Collections.Generic;
using System.Text;


public abstract class Feline : Mammal
{
    public Feline(string name, double weight, string livingRegion,string breed)
        : base(name, weight, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed { get; protected set; }
}

