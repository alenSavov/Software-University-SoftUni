namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using BookShop.Models;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {

            var context = new BookShopContext();
            using (context)
            {
                string input = Console.ReadLine();
                var result = GetBooksByCategory(context, input);
                Console.WriteLine(result);
            }
        }
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] genres = input.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var booksCat =
                context.Books
               .Where(x => x.BookCategories.Select(l => l.Category.Name.ToLower()).Intersect(genres).Any())
               .OrderBy(b => b.Title)
               .Select(b => b.Title)
               .ToArray();

            return String.Join(Environment.NewLine, booksCat);
        }
    }
}