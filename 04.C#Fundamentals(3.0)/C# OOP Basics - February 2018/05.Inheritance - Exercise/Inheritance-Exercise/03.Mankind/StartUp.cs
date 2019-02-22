using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var data = new List<Human>();

        try
        {
            var studentInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var studenFirsName = studentInfo[0];
            var studentLastName = studentInfo[1];
            var studentFacultyNum = studentInfo[2];
            Student student = new Student(studenFirsName, studentLastName, studentFacultyNum);

            var workerInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var workerFirstName = workerInfo[0];
            var workerLastName = workerInfo[1];
            var workerSalary = decimal.Parse(workerInfo[2]);
            var workerHours = double.Parse(workerInfo[3]);
            Worker worker = new Worker(workerFirstName, workerLastName, workerSalary, workerHours);

            data.Add(student);
            data.Add(worker);
            foreach (var human in data)
            {
                Console.WriteLine(human);
                Console.WriteLine();

            }            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}

