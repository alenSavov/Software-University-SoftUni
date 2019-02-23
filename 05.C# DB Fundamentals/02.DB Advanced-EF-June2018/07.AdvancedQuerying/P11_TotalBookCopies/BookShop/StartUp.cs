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
                var result = CountCopiesByAuthor(context);
                Console.WriteLine(result);
            }
        }
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var books = context.Books
                        .Select(x => new { AuthorName = $"{x.Author.FirstName} {x.Author.LastName}", x.Copies })
                        .GroupBy(x => x.AuthorName)
                        .OrderByDescending(x => x.Sum(l => l.Copies))
                        .ToList();

            return String.Join(Environment.NewLine, books.Select(e => $"{e.Key} - {e.Sum(x => x.Copies)}"));
        }
    }
}
