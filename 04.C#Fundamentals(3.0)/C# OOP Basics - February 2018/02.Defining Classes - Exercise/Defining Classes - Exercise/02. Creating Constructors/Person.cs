using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private int age;
    private string name;


    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }
    public Person(int age) : this()
    {
        Age = age;
    }
    public Person(string name, int age) : this(age)
    {
        Name = name;
        Age = age;
    }


    //public string Name
    //{
    //    get => this.name;
    //    set => this.name = value;
    //}
    public string Name { get; set; }

    //public int Age
    //{
    //    get => this.age;
    //    set => this.age = value;
    //}
    public int Age { get; set; }

}

