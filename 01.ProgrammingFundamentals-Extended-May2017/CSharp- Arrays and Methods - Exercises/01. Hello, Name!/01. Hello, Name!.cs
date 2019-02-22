using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            PrintNameWithHello(name);

        }
        static string PrintNameWithHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
    }
}
