﻿using System;
using System.Net;

namespace CakesWebApp.Extensions
{
    public static class StringExtensions
    {
        public static string UrlDecode(this string input)
        {
            return WebUtility.UrlDecode(input);
        }
    }
}
