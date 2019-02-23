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
            int year = int.Parse(Console.ReadLine());

            using (var db = new BookShopContext())
            {
               var result = GetBooksNotRealeasedIn(db, year);

                Console.WriteLine(result);
            }
        }

        public static string GetBooksNotRealeasedIn(BookShopContext db, int year)
        {
            var titles = db.Books
                 .Where(x => x.ReleaseDate.Value.Year.ToString() != year.ToString())
                 .Select(x => new { x.Title, x.BookId })
                 .OrderBy(x => x.BookId)
                 .ToList();

            var resultSet = "";
            foreach (var title in titles)
            {
                resultSet += ($"{title.Title}") + Environment.NewLine;
            }

            return resultSet;
        }
    }
}
