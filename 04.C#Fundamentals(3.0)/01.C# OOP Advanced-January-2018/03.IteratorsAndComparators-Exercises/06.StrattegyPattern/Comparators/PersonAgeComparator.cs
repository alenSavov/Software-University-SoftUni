using System;
using System.Collections.Generic;
using System.Text;


public class PersonAgeComparator : IComparer<Person>
{
    public int Compare(Person firstPeson, Person secondPerson)
    {
        return firstPeson.Age - secondPerson.Age;
    }
}

