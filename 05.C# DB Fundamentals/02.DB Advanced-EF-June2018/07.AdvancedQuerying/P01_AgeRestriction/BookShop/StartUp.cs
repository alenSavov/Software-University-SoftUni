namespace BookShop
{
    using BookShop.Data;
    using BookShop.Initializer;
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using BookShop.Models;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            var date = Console.ReadLine();

            using (var db = new BookShopContext())
            {
                var result = GetBooksReleasedBefore(db, date);
                Console.WriteLine(result);
            }
        }

        public static string GetBooksReleasedBefore(BookShopContext db, string date)
        {
            var inputDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = db.Books
                .Where(x => x.ReleaseDate < inputDate)
                .Select(x => new { x.Title, x.ReleaseDate, x.EditionType, x.Price})
                .OrderByDescending(x => x.ReleaseDate)
                .ToList();

            return String.Join(Environment.NewLine, books.Select(x => $"{x.Title} - {x.EditionType} - ${x.Price:F2}"));
        }
    }
}
