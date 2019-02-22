using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : ICar
{
    private string model;
    private string driver;

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
    }

    public string Driver
    {
        get { return driver; }
        private set { driver = value; }
    }

    public string Model
    {
        get { return model; }
        private set { model = value; }
    }

    public string PushTheGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Model}/{this.UseBrakes()}/{this.PushTheGasPedal()}/{this.Driver}");

        return sb.ToString();
    }
}

