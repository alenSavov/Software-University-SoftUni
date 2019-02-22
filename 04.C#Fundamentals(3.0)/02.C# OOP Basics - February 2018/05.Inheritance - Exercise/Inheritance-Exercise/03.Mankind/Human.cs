using System;
using System.Collections.Generic;
using System.Text;


public class Human
{
    private const string FIRST_NAME_ERROR = "Expected upper case letter! Argument: firstName";
    private const string FIRST_NAME_LENGTH_ERROR = "Expected length at least 4 symbols! Argument: firstName";
    private const string LAST_NAME_ERROR = "Expected upper case letter! Argument: lastName";
    private const string LAST_NAME_LENGTH_ERROR = "Expected length at least 3 symbols! Argument: lastName ";
    private string firtName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    protected string FirstName
    {
        get
        {
            return firtName;
        }
        set
        {
            if (char.IsUpper(value[0]) == false)
            {
                throw new ArgumentException(FIRST_NAME_ERROR);
            }
            if (value.Length < 4)
            {
                throw new ArgumentException(FIRST_NAME_LENGTH_ERROR);
            }
           this.firtName = value;
        }
    }

    protected string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            if (char.IsUpper(value[0]) == false)
            {
                throw new ArgumentException(LAST_NAME_ERROR);
            }
            if (value.Length < 3)
            {
                throw new ArgumentException(LAST_NAME_LENGTH_ERROR);
            }
            this.lastName = value;
        }
    }

}

