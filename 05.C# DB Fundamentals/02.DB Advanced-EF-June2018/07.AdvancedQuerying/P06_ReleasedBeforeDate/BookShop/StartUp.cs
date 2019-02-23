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
               string result = GetBooksByAgeRestriction(db, command);

                Console.WriteLine(result);
            }
        }

        public static string GetBooksByAgeRestriction(BookShopContext db, string command)
        {
            var titles = db.Books
                .Where(b => String.Equals(command, b.AgeRestriction.ToString(), StringComparison.InvariantCultureIgnoreCase))
                .Select(b => b.Title).OrderBy(x => x)
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

    }
}
