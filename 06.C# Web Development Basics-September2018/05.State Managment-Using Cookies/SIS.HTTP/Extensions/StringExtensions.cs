namespace SIS.HTTP.Extensions
{
    using System;
    using System.Linq;

    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{nameof(input)} cannot be null!");
            }

            return Char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }            
    }
}
