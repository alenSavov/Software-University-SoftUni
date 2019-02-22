using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age)
    {
        this.age = age;
        this.name = "No name";
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
