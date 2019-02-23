using System;
using System.Net;

namespace _02.ValidateURL
{
    public class StartUp
    {
        public static void Main()
        {
            var encodedUrlInput = Console.ReadLine();
            var decodedUrl = WebUtility.UrlDecode(encodedUrlInput);

            var uri = new Uri(decodedUrl);

            Console.WriteLine($"Protocol:{uri.Scheme}");
            Console.WriteLine($"Host:{uri.Host}");
            Console.WriteLine($"Port:{uri.Port}");
            Console.WriteLine($"Path:{uri.AbsolutePath}");

            string pathAndQuryString = uri.PathAndQuery;

            if (pathAndQuryString.Length > 1)
            {
                Console.WriteLine($"Query:{pathAndQuryString}");
            }

            var fragment = uri.Fragment;

            if (fragment.Length > 1)
            {
                Console.WriteLine($"Fragment:{fragment.Substring(1)}");
            }
        }
    }
}
