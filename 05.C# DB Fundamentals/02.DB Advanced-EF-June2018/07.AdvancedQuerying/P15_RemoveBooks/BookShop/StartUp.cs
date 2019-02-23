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
                int result = RemoveBooks(context);
                Console.WriteLine($"{result} books were deleted");

            }
        }
        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books.Where(x => x.Copies < 4200).ToList();

            foreach (var shittyBooks in books)
            {
                context.Books.Remove(shittyBooks);

            }

            context.SaveChanges();

            return books.Count();
        }
    }
}
