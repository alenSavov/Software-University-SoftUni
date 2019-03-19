using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "az sam balgarche aha aaaa mndaaaa";
            var nov = Regex.Split(text, @"a").Where(p => p != "").Where(p => p != " ").ToArray();
            
        }
    }
}
