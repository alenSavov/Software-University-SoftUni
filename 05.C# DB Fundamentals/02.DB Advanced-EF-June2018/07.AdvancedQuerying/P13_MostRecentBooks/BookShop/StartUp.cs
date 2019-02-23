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
                string result = GetMostRecentBooks(context);
                Console.WriteLine(result);
            }
        }
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var info = context.Categories
                              .Select
                              (
                                    x => new
                                    {
                                        Name = x.Name,

                                        Count = x.CategoryBooks.Count,

                                        CategoryBooks = x.CategoryBooks
                                                         .OrderByDescending(l => l.Book.ReleaseDate.Value)
                                                         .Take(3)
                                                         .Select(j => new { Title = j.Book.Title, Year = j.Book.ReleaseDate })
                                    }
                              )
                              .OrderBy(x => x.Name)
                              .ToList();


            return String.Join(Environment.NewLine, info.Select(x => $"--{x.Name}" +
                               Environment.NewLine +
                   string.Join(Environment.NewLine, x.CategoryBooks.Select(y => $"{y.Title} ({y.Year.Value.Year})"))));
        }
    }
}
