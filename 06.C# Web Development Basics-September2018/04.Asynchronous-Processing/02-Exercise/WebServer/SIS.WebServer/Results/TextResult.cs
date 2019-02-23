namespace SIS.WebServer.Results
{
    using SIS.HTTP.Headers;
    using SIS.HTTP.Responses;
    using System;
    using System.Net;
    using System.Text;

    public class TextResult : HttpResponse
    {
        public TextResult(string content, HttpStatusCode statusCode) 
            : base(statusCode)
        {
            this.Headers.Add(new HttpHeader("Content-Type", "text-plain"));
            this.Content = Encoding.UTF8.GetBytes(content);
        }
    }
}
