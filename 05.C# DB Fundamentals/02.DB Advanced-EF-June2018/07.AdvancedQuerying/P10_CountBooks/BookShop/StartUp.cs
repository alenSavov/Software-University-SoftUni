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
                int length = int.Parse(Console.ReadLine());
                var result = CountBooks(context, length);
                Console.WriteLine(result);
            }
        }
        public static int CountBooks(BookShopContext context, int length)
        {
            var books = context.Books
                        .Where(x => x.Title.Length > length)
                        .Count();

            return books;
        }
    }
}
