using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            var input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                var personInfo = input[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Person person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            var allProducts = Console.ReadLine();
            var products = new List<Product>();

            var splitAllProducts = allProducts.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitAllProducts.Length; i++)
            {
                var productIndo = splitAllProducts[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    Product product = new Product(productIndo[0], decimal.Parse(productIndo[1]));
                    products.Add(product);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            var purchasesInfo = Console.ReadLine();
            while (purchasesInfo != "END")
            {
                var purchase = purchasesInfo.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var personName = purchase[0];
                var productName = purchase[1];

                Person currentPerson = people.FirstOrDefault(p => p.Name == personName);
                Product currentProduct = products.FirstOrDefault(p => p.Name == productName);

                if (currentPerson.Money < currentProduct.Cost)
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }
                else
                {
                    currentPerson.Money -= currentProduct.Cost;
                    foreach (var person in people.Where(p => p.Name == personName))
                    {
                        person.Money = currentPerson.Money;
                        person.BagOfProducts.Add(currentProduct);
                    }

                    Console.WriteLine($"{personName} bought {productName}");
                }

                purchasesInfo = Console.ReadLine();
            }

            foreach (var pers in people)
            {
                pers.Print();
            }
        }
    }
}
