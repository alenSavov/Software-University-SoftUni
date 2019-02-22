using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var departmentAndPatients = new Dictionary<string, List<string>>();
            var doctorAndPatients = new Dictionary<string, List<string>>();

            while (input[0] != "Output")
            {
                var department = input[0].Trim();
                var patients = input[3].Trim();
                if (departmentAndPatients.ContainsKey(department) == false)
                {
                    departmentAndPatients.Add(department, new List<string>());
                }
                departmentAndPatients[department].Add(patients);

                var doctor = input[1] + " " + input[2];
                if (doctorAndPatients.ContainsKey(doctor) == false)
                {
                    doctorAndPatients.Add(doctor, new List<string>());
                }
                doctorAndPatients[doctor].Add(patients);

                input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            var command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (command[0] != "End")
            {

                if (command.Count == 1)
                {
                    foreach (var patients in departmentAndPatients[command[0]])
                    {
                        Console.WriteLine(patients);
                    }
                }
                else
                {
                    int roomNumber = 0;
                    if (int.TryParse(command[1], out roomNumber))
                    {
                        var skip = 3 * (roomNumber - 1);
                        foreach (var patient in departmentAndPatients[command[0]].Skip(skip).Take(3).OrderBy(p => p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    else
                    {
                        var doctorName = command[0] + " " + command[1].Trim();
                        foreach (var patient in doctorAndPatients[doctorName].OrderBy(p => p))
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
                command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

        }

    }
}
