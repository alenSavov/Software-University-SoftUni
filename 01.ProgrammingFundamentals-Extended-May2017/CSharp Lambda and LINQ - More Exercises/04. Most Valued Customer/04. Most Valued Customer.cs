﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MostValuedCustomer
{
    class MostValuedCustomer
    {
        static void Main()
        {
            var productsData = new Dictionary<string, double>();

            string input = Console.ReadLine();
            while (input != "Shop is open")
            {
                string[] inputTokens = input.Split(' ');
                string product = inputTokens[0];
                double price = double.Parse(inputTokens[1]);

                productsData[product] = price;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();


            var customerData = new Dictionary<string, List<string>>();

            while (input != "Print")
            {
                string[] inputTokens = input
                    .Split(new string[] { ": ", ", " },
                    StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "Discount")
                {
                    var discountedProducts = productsData
                        .OrderByDescending(pd => pd.Value)
                        .Take(3)
                        .Select(pd =>
                            new KeyValuePair<string, double>(pd.Key, pd.Value * 0.9));

                    foreach (var discountedProduct in discountedProducts)
                    {
                        productsData[discountedProduct.Key] = discountedProduct.Value;
                    }
                }
                else
                {
                    string customer = inputTokens[0];
                    if (!customerData.ContainsKey(customer))
                    {
                        customerData.Add(customer, new List<string>());
                    }

                    for (int index = 1; index < inputTokens.Length; index++)
                    {
                        string boughtProduct = inputTokens[index];
                        if (productsData.ContainsKey(boughtProduct))
                        {
                            customerData[customer].Add(boughtProduct);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var topCustomer = customerData
                .OrderByDescending(d => d.Value.Sum(product => productsData[product]))
                .First();

            string name = topCustomer.Key;
            List<string> productsBought = topCustomer.Value;
            Console.WriteLine("Biggest spender: {0}", name);
            Console.WriteLine("^Products bought:");

            double total = productsBought.Sum(p => productsData[p]);
            var orderedProducts = productsBought.Distinct().OrderByDescending(p => productsData[p]);
            foreach (var product in orderedProducts)
            {
                Console.WriteLine("^^^{0}: {1:F2}", product, productsData[product]);
            }

            Console.WriteLine("Total: {0:F2}", total);
        }
    }
}