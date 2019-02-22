using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<product>[A-Z][a-z]+):(?<price>[0-9]{2}.[0-9]{2})\b";
            var regex = new Regex(pattern);
            var input = Console.ReadLine();
            var regexProductAndPrice = regex.Match(input);

            var productsAndPrices = new Dictionary<string, decimal>();

            while (input != "bill")
            {
                var result = regexProductAndPrice.Success;
                Console.WriteLine(result);

               // if (regexProductAndPrice.Success)
               // {
               // var product = regexProductAndPrice.Groups["product"].Value;
               // var price = decimal.Parse(regexProductAndPrice.Groups["price"].Value);
               //
               //
               // }



                input = Console.ReadLine();
            }
        }
    }
}
