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
            
            using (var db = new BookShopContext())
            {
                string result = GetBooksByPrice(db);
                Console.WriteLine(result);
            }
        }

        public static string GetBooksByPrice(BookShopContext db)
        {
            var books = db.Books
                .Where(x => x.Price > 40)
                .Select(x => new { x.Title, x.Price })
                .OrderByDescending(x => x.Price)
                .ToList();

            var setOfBooks = "";
            foreach (var book in books)
            {
                setOfBooks += ( $"{book.Title} - ${book.Price:F2}") + Environment.NewLine;
            }

            return setOfBooks;
        }
    }
}
