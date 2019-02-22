using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            var words = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            
            Func<string, bool> cheker = w => w[0] == w.ToUpper()[0];

            words.Where(cheker)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
                
        }
    }
}
