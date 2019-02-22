using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library()
            {
                Name = "Prosveta",
                Books = new List<Book>()
            };
            var booksCount = int.Parse(Console.ReadLine());


            for (int i = 0; i < booksCount; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                var releaseData = DateTime.ParseExact(input[3], "dd.MM.yyyy"
                    , CultureInfo.InvariantCulture);
                var isbn = input[4];
                var price = decimal.Parse(input[5]);

                var book = new Book(title, author, publisher, releaseData, isbn, price);
                library.Books.Add(book);
            }
            var authors = library
                .Books.Select(a => a.Author)
                .Distinct()
                .ToArray();

            var authorSales = new List<AuthorInfo>();

            foreach (var author in authors)
            {
                var sales = library.Books
                    .Where(a => a.Author == author)
                    .Sum(a => a.Price);

                var authorInfo = new AuthorInfo()
                {
                    Author = author,
                    Sales = sales
                };
                authorSales.Add(authorInfo);


            }
            authorSales = authorSales
                .OrderByDescending(a => a.Sales)
                .ThenBy(a => a.Author)
                .ToList();

            foreach (var authorSale in authorSales)
            {
                var author = authorSale.Author;
                var sales = authorSale.Sales;
                Console.WriteLine($"{author} -> {sales:f2}");

            }
        }


    }


    class AuthorInfo
    {
        public string Author { get; set; }
        public decimal Sales { get; set; }
    }
    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseData, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseData = releaseData;
            Isbn = isbn;
            Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseData { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }
    }
}
