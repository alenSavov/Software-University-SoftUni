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
                var result = GetBooksByAuthor(db, command);
                Console.WriteLine(result);
            }
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(x => x.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(x => x.BookId)
                .Select(x => new { x.Title, x.Author.FirstName, x.Author.LastName, x.BookId })
                .ToList();

            var result = string.Join(Environment.NewLine, books.Select(x => x.Title + " " + "(" + x.FirstName + " " + x.LastName + ")"));
            return result;  
        }
    }
}
