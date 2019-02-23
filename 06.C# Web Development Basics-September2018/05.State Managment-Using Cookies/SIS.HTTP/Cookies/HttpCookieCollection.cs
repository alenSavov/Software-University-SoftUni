namespace SIS.HTTP.Cookies
{
    using SIS.HTTP.Cookies.Contracts;
    using SIS.HTTP.Requests;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HttpCookieCollection : IHttpCookieCollection
    {
        private readonly Dictionary<string, HttpCookie> cookies;

        public HttpCookieCollection()
        {
            this.cookies = new Dictionary<string, HttpCookie>();
        }

        public void Add(HttpCookie cookie)
        {
            if (cookie == null ||
                string.IsNullOrEmpty(cookie.Key) ||
                string.IsNullOrEmpty(cookie.Value) ||
                this.ContainsCookie(cookie.Key))
            {
                throw new Exception();
            }

            this.cookies.Add(cookie.Key, cookie);
        }

        public bool ContainsCookie(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException($"{nameof(key)} cannot be null!");
            }

            return this.cookies.ContainsKey(key);
        }

        public HttpCookie GetCookie(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException($"{nameof(key)} cannot be null!");
            }

            if (this.ContainsCookie(key))
            {
                return this.cookies[key];
            }

            return null;
        }

        public bool HasCookie()
        {
            return this.cookies.Any();
        }

        public override string ToString()
            => $"{string.Join("; ", this.cookies.Values)}";
    }
}
