using System;
using System.Collections.Generic;
using System.Text;


public class Tire
{
    private int age;
    private double pressure;

    public Tire(double pressure, int age)
    {
        this.pressure = pressure;
        this.age = age;
    }

    public double Pressure => this.pressure;
}

