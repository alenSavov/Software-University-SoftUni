using System;
using System.Net;

namespace _01.URL_Decode
{
    public class StartUp
    {
        public static void Main()
        {
            var encodedUrl = "http://www.google.bg/search?q=C%23";

             var decodedUrl = WebUtility.UrlDecode(encodedUrl);
            Console.WriteLine(decodedUrl);
        }
    }
}
