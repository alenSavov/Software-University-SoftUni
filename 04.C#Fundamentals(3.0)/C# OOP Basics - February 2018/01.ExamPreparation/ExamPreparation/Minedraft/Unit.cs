using System;
using System.Collections.Generic;
using System.Text;


public abstract class Unit
{
    public string Id { get; set; }
    public abstract string Type { get; }

    protected Unit(string id)
    {
        Id = id;
    }
}

