namespace _04.Exam_Shopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExamShopping
    {
        public static void Main()
        {
            Dictionary<string, int> quantitiesAndProductsFromShop = new Dictionary<string, int>();

            string[] currentProducts = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            //For adding stuffs
            while (currentProducts[0] != "shopping")
            {
                string productName = currentProducts[1];
                int quantiti = int.Parse(currentProducts[2]);

                if (!quantitiesAndProductsFromShop.ContainsKey(productName))
                {
                    quantitiesAndProductsFromShop[productName] = 0;
                }
                quantitiesAndProductsFromShop[productName] += quantiti;


                currentProducts = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }

            //For buyng stuffs
            currentProducts = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            while (currentProducts[0] != "exam")
            {

                string productName = currentProducts[1];
                int quantiti = int.Parse(currentProducts[2]);

                //if the product dosnt exeist
                if (!quantitiesAndProductsFromShop.ContainsKey(productName))
                {
                    Console.WriteLine($"{productName} doesn't exist");
                }
                else
                {
                    if (quantitiesAndProductsFromShop[productName] > 0)
                    {
                        quantitiesAndProductsFromShop[productName] -= quantiti;
                    }
                    else if (quantitiesAndProductsFromShop[productName] <= 0)
                    {
                        quantitiesAndProductsFromShop[productName] = 0;
                        Console.WriteLine($"{productName} out of stock");
                    }
                }

                currentProducts = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            }


            quantitiesAndProductsFromShop = quantitiesAndProductsFromShop
                .Where(v => v.Value > 0)
                .ToDictionary(k => k.Key, v => v.Value);


            foreach (var prduct in quantitiesAndProductsFromShop)
            {
                Console.WriteLine($"{prduct.Key} -> {prduct.Value}");
            }
        }
    }
}