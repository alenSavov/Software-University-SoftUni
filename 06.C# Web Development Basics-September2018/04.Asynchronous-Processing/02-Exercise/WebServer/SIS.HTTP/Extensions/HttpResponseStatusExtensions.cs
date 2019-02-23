namespace SIS.HTTP.Extensions
{
    using System.Net;  

    public static class HttpResponseStatusExtensions
    {
        public static string GetResponseLine(this HttpStatusCode statusCode)
            => $"{(int) statusCode} {statusCode}";
    }
}
