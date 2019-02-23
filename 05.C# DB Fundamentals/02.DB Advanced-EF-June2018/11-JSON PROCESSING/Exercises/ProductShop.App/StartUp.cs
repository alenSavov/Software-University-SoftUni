namespace ProductShop.App
{
    using AutoMapper;

    using Data;
    using Newtonsoft.Json;
    using ProductShop.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });
            var mapper = config.CreateMapper();

            var context = new ProductShopContext();
            // ADD USERS
            // var jsonString = File.ReadAllText("../../../json/users.json");
            //
            // var desealizedUsers = JsonConvert.DeserializeObject<User[]>(jsonString);
            //
            // var users = new List<User>();
            //
            // foreach (var user in desealizedUsers)
            // {
            //     if (IsValid(user))
            //     {
            //         users.Add(user);
            //     }
            // }
            //
            // context.Users.AddRange(users);
            // context.SaveChanges();


            // ADD Products
            // var jsonString = File.ReadAllText("../../../Json/products.json");
            // var deserializedProducts = JsonConvert.DeserializeObject<Product[]>(jsonString);
            //
            // var products = new List<Product>();
            //
            // foreach (var product in deserializedProducts)
            // {
            //     if (!IsValid(product))
            //     {
            //         continue;
            //     }
            //
            //     var sellerId = new Random().Next(1, 35);
            //     var buyerId = new Random().Next(35, 57);
            //
            //     var random = new Random().Next(1, 4);
            //
            //     product.SellerId = sellerId;
            //     product.BuyerId = buyerId;
            //
            //     if (random == 3)
            //     {
            //         product.BuyerId = null;
            //     }
            //
            //     products.Add(product);
            //
            // }
            //
            // context.Products.AddRange(products);
            // context.SaveChanges();

            // ADD CATEGORIES
            //var jsonStirng = File.ReadAllText("../../../json/categories.json");
            //var deserializedCategories = JsonConvert.DeserializeObject<Category[]>(jsonStirng);

            //var categories = new List<Category>();

            //foreach (var category in deserializedCategories)
            //{
            //    if (!IsValid(category))
            //    {
            //        continue;
            //    }

            //    categories.Add(category);
            //}

            //context.Categories.AddRange(categories);
            //context.SaveChanges();

            // ADD CategoryProducts
            //var categoryProducts = new List<CategoryProduct>();
            //
            //foreach (var p in context.Products)
            //{
            //    Random random = new Random();
            //    int value = random.Next(1, 11);
            //
            //    categoryProducts.Add(new CategoryProduct()
            //    {
            //        ProductId = p.Id,
            //        CategoryId = value
            //    });
            //}
            //
            //context.CategoryProducts.AddRange(categoryProducts);
            //context.SaveChanges();

            // Export products-in-json
            //var products = context.Products
            //                .Where(x => x.Price >= 500 && x.Price <= 1000)
            //                .OrderBy(x => x.Price)
            //                .Select(x => new
            //                {
            //                    name = x.Name,
            //                    price = x.Price,
            //                    seller = x.Seller.FirstName + " " + x.Seller.LastName ?? x.Seller.LastName
            //                }).ToArray();
            //
            //var jsonProducts = JsonConvert.SerializeObject(products, Formatting.Indented);
            //
            //File.WriteAllText("../../../json/products-in-range.json", jsonProducts);


            //  Query2 Successfully Sold Products
            // var users = context.Users
            //                 .Where(x => x.ProductsSold.Count >= 1 && x.ProductsSold.Any(s => s.Buyer != null))
            //                 .OrderBy(x => x.LastName)
            //                 .ThenBy(x => x.FirstName)
            //                 .Select(x => new
            //                 {
            //                     firstName = x.FirstName,
            //                     lastName = x.LastName,
            //                     soldProducts = x.ProductsSold.Where(b => b.Buyer != null)
            //                                                   .Select(v => new
            //                                                   {
            //                                                       name = v.Name,
            //                                                       price = v.Price,
            //                                                       buyerFirstName = v.Buyer.FirstName,
            //                                                       buyerLastName = v.Buyer.LastName
            //                                                   }).ToArray()
            //                 }).ToArray();
            //
            // var jsonProducts = JsonConvert.SerializeObject(users, new JsonSerializerSettings
            // {
            //    Formatting = Formatting.Indented,
            //    NullValueHandling = NullValueHandling.Ignore
            // });
            //
            // File.WriteAllText("../../../json/users-sold-products.json", jsonProducts);

            //  Query 3. Categories By Products Count
            // var products = context.Categories
            //                         .Select(x => new
            //                         {
            //                             category = x.Name,
            //                             productsCount = x.CategoryProducts.Count(),
            //                             averagePrice = x.CategoryProducts.Sum(s => s.Product.Price) / x.CategoryProducts.Count(),
            //                             totalRevenue = x.CategoryProducts.Sum(s => s.Product.Price)
            //                         })
            //                         .OrderByDescending(x => x.productsCount)
            //                         .ToArray();
            //                     
            //
            // var jsonProducts = JsonConvert.SerializeObject(products, Formatting.Indented);
            //
            // File.WriteAllText("../../../categories-by-products.json", jsonProducts);

            //Query 4. Users and Products
            var users = new
            {
                usersCount = context.Users.Count(),
                users = context.Users
                .OrderByDescending(x => x.ProductsSold.Count)
                .ThenBy(l => l.LastName)
                               .Where(x => x.ProductsSold.Count >= 1 && x.ProductsSold.Any(s => s.Buyer != null))
                               .Select(x => new
                               {
                                   firstName = x.FirstName,
                                   lastName = x.LastName,
                                   age = x.Age,
                                   soldProducts = new
                                   {
                                       count = x.ProductsSold.Count(),
                                       products = x.ProductsSold.Select(s => new
                                       {
                                           name = s.Name,
                                           price = s.Price
                                       })
                                   }
                               })
            };

            var jsonProducts = JsonConvert.SerializeObject(users, Formatting.Indented);

            File.WriteAllText("../../../users-and-products.json", jsonProducts);
        }
        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}
