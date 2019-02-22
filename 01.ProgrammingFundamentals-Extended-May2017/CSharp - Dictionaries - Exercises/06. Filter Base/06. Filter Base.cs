using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputDate = Console.ReadLine()
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> age = new Dictionary<string, int>();
            Dictionary<string, double> salary = new Dictionary<string, double>();
            Dictionary<string, string> position = new Dictionary<string, string>();


            while (inputDate[0] != "filter base")
            {
                int ageOfEmployee;
                double salaryOfEmployee;
                if (int.TryParse(inputDate[1], out ageOfEmployee))
                {
                    age[inputDate[0]] = ageOfEmployee;
                }
                else if (double.TryParse(inputDate[1], out salaryOfEmployee))
                {
                    salary[inputDate[0]] = salaryOfEmployee;
                }
                else
                {
                    position[inputDate[0]] = inputDate[1];
                }
                

                inputDate = Console.ReadLine()
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }

            string informationForEmployee = Console.ReadLine();

            if (informationForEmployee == "Position")
            {
                foreach (var item in position)
                {                    
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"{informationForEmployee}: {item.Value.Trim()}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (informationForEmployee == "Salary")
            {
                foreach (var item in salary)
                {                    
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"{informationForEmployee}: {item.Value:F2}".Trim());
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (informationForEmployee == "Age")
            {
                foreach (var item in age)
                {                    
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"{informationForEmployee}: {item.Value}".Trim());
                    
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
