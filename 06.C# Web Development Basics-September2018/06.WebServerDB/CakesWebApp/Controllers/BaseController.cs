namespace CakesWebApp.Controllers
{
    using SIS.HTTP.Responses.Contracts;
    using SIS.WebServer.Results;
    using System.IO;
    using System.Net;

    public abstract class BaseController
    {
        protected IHttpResponse View(string viewName)
        {
            var content = File.ReadAllText("Views/" + viewName + ".html");
            return new HtmlResult(content, HttpStatusCode.OK);
        }
    }
}
