using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<string> words = Console.ReadLine()
             .ToLower()
            .Split(new char[] { '.',',',':',';','(', ')','[', ']','"','\'','\\','/','!','?',' '}, StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .Where(w => w.Length < 5)
            .OrderBy(w => w)
            .ToList();

            Console.WriteLine(string.Join(", ", words));


        }
    }
}
