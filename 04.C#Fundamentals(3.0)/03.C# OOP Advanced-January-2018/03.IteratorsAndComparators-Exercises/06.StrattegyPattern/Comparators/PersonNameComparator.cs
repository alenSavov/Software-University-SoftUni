using System;
using System.Collections.Generic;
using System.Text;


public class PersonNameComparator : IComparer<Person>
{


    public int Compare(Person firstPerson, Person secondPerson)
    {
        var comparison = firstPerson.Name.Length - secondPerson.Name.Length;

        return comparison == 0
            ? (int)(char.ToLower(firstPerson.Name[0]) - char.ToLower(secondPerson.Name[0]))
            : comparison;
    }
}

