using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Student : Human
{
    private const string FALCULTY_NUMBER_ERROR = "Invalid faculty number!";

    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    private string FacultyNumber
    {
        get
        {
            return facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 || (value.Any(ch => !Char.IsLetterOrDigit(ch))))
            {
                throw new ArgumentException(FALCULTY_NUMBER_ERROR);
            }
            this.facultyNumber = value;
        }
    }
    

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");

        return sb.ToString().TrimEnd();
    }
}

