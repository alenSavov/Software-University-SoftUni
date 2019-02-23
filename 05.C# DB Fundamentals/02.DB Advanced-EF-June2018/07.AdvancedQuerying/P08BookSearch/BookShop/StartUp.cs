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
            var command = Console.ReadLine();

            using (var db = new BookShopContext())
            {
                var result = GetBookTitlesContaining(db, command);
                Console.WriteLine(result);
            }
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(x => x.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(x => x.Title)
                .Select(x => x.Title)
                .ToList();

            return String.Join(Environment.NewLine, books);
        }
    }
}
