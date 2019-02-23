namespace SIS.HTTP.Responses.Contracts
{
    using SIS.HTTP.Cookies;
    using SIS.HTTP.Cookies.Contracts;
    using SIS.HTTP.Headers;
    using System.Net;

    public interface IHttpResponse
    {
        HttpStatusCode StatusCode { get; set; }

        HttpHeaderCollection Headers { get; }

        byte[] Content { get; set; }

        void AddHeader(HttpHeader header);

        IHttpCookieCollection Cookies { get; }

        void AddCookie(HttpCookie cookie);

        byte[] GetBytes();
    }
}
