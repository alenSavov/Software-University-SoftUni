using System;
using System.Collections.Generic;
using System.Text;

public class DateModifier
{
    public string StartDate { get; set; }

    public string EndDate { get; set; }

    public DateModifier(string firstDate, string secondDate)
    {
        StartDate = firstDate;
        EndDate = secondDate;
    }

    public double differenceBetweenDate(string firstDateString, string secondDateString)
    {
        DateTime firstDate = DateTime.Parse(firstDateString);
        DateTime secondDate = DateTime.Parse(secondDateString);

        var biggerDate = DateTime.Compare(firstDate, secondDate);
        double result;
        if (biggerDate < 0)
        {
            result = (secondDate - firstDate).TotalDays;
        }
        else if (biggerDate == 0)
        {
            result = 0;
        }
        else
        {
            result = (firstDate - secondDate).TotalDays;
        }

        return result;
    }
}

