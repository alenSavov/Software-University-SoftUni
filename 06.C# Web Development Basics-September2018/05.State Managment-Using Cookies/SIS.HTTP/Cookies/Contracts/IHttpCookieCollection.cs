namespace SIS.HTTP.Cookies.Contracts
{
    using SIS.HTTP.Requests;
    using System;

    public interface IHttpCookieCollection
    {
        void Add(HttpCookie cookie);

        bool ContainsCookie(string key);

        HttpCookie GetCookie(string key);

        bool HasCookie();
    }
}
