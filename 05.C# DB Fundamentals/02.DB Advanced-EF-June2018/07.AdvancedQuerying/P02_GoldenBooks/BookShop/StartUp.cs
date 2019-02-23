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
            
            using (var db = new BookShopContext())
            {
                var result = GetGoldenBooks(db);

                Console.WriteLine(result);
            }
        }

        public static string GetGoldenBooks(BookShopContext db)
        {
            var books = db.Books
                .Where(x => x.EditionType.ToString() == "Gold" && x.Copies < 5000)
                .OrderBy(x => x.BookId)                
                .Select(x => x.Title)
                .ToList();

            var result = String.Join(Environment.NewLine, books);
            

            return result;
        }
    }
}
