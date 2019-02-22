using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, double> products = new Dictionary<string, double>();

            string productName = input[0];
            double price = double.Parse(input[1]);

            while (input[0] != "end")
            {
                productName = input[0];
                price = double.Parse(input[1]);

                
                if (!products.ContainsKey(productName))
                {
                    products[productName] = price;
                }
                else
                {
                    if (products[productName] > price)
                    {
                        products[productName] = price;
                    }

                }           
                                                          
                                      

                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            double sumOfValues = products.Sum(p => p.Value);

            if (budget < sumOfValues)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                products = products
                    .OrderBy(k => k.Key.Length)
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var item in products)
                {
                    Console.WriteLine($"{item.Key} costs {item.Value:F2}");
                }
            }


        }
    }
}
