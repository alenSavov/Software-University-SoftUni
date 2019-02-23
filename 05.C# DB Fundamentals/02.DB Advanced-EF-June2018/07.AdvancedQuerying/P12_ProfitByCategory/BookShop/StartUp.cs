namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using BookShop.Models;

    public class StartUp
    {
        public static void Main()
        {
            var context = new BookShopContext();
            using (context)
            {
                var result = GetTotalProfitByCategory(context);
                Console.WriteLine(result);
            }
        }
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categories = context.Categories
                        .Select(x => new { x.Name, Profit = x.CategoryBooks.Sum(l => l.Book.Copies * l.Book.Price) })
                        .OrderByDescending(l => l.Profit)
                        .ThenBy(x => x.Name)
                        .ToList();

            return String.Join(Environment.NewLine, categories.Select(e => $"{e.Name} ${e.Profit:F2}"));
        }
    }
}
