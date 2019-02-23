using System.Net;

namespace SIS.MvcFramework
{
    public static class StringExtensions
    {
        public static string Capitalize(this string text)
        {
            return WebUtility.UrlDecode(text);
        }

        public static decimal ToDecimalOrDefault(this string input)
        {
            if (decimal.TryParse(input, out var result))
            {
                return result;
            }

            return default(decimal);
        }
    }
}
