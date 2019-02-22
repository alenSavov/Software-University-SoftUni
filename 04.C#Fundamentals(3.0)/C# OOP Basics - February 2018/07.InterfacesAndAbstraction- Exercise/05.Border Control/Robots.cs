using System;
using System.Collections.Generic;
using System.Text;


public class Robots : IIdentable
{
    private string model;
    private string id;

    public Robots(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Id
    {
        get { return id; }
        private set { id = value; }
    }

    public string Model
    {
        get { return model; }
        private set { model = value; }
    }

}

