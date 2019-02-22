using System;
using System.Collections.Generic;
using System.Text;


public class Worker : Human
{
    private const string WEEK_SALARY_ERROR = "Expected value mismatch! Argument: weekSalary";
    private const string WORKING_HOURS_ERROR = "Expected value mismatch! Argument: workHoursPerDay";
    private const decimal WEEK_SALARY = 10;
    private const int WORKING_DAYS_IN_WEEK = 5;
    
    private decimal weekSalary;
    private double workingHours;

    public Worker(string firstName, string lastName, decimal weekSalary, double workingHourPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkingHoursPerDay = workingHourPerDay;
    }

    private decimal WeekSalary
    {
        get
        {
            return weekSalary;
        }
        set
        {
            if (value <= WEEK_SALARY)
            {
                throw new ArgumentException(WEEK_SALARY_ERROR);
            }
           this.weekSalary = value;
        }
    }

    private double WorkingHoursPerDay
    {
        get
        {
            return workingHours;
        }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException(WORKING_HOURS_ERROR);
            }
            this.workingHours = value;
        }
    }

    private decimal GetMoneyPerHour()
    {
        var moneyPerHour = weekSalary / WORKING_DAYS_IN_WEEK;
         moneyPerHour /= (decimal)workingHours;

        return moneyPerHour;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:F2}")
            .AppendLine($"Hours per day: {this.WorkingHoursPerDay:F2}")
            .AppendLine($"Salary per hour: {GetMoneyPerHour():F2}");

        return sb.ToString().TrimEnd();
    }
}


