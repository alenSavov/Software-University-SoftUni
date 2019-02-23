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
                var result = GetAuthorNamesEndingIn(db, command);
                Console.WriteLine(result);
            }
        }

        public static string GetAuthorNamesEndingIn(BookShopContext db, string command)
        {
            int length = command.Length;

            var fullNames = db.Authors
                .Where(x => x.FirstName.Substring(x.FirstName.Length - length, length) == command)
                .OrderBy(x => x.FirstName).ThenBy(x => x.LastName)
                .OrderBy(x => x.FirstName)
                .ToList();
          
            var result = string.Join(Environment.NewLine, fullNames.Select(x => x.FirstName + " " + x.LastName));
            return result;
        }
    }
}
