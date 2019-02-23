namespace IRunes.App.Controllers
{
    using SIS.HTTP.Enums;
    using SIS.HTTP.Responses;
    using SIS.WebServer.Results;

    using System.IO;
    using System.Runtime.CompilerServices;

    public abstract class BaseController
    {
        private const string RootDirectoryRelativePath = "../../../";
        private const string ViewFolderName = "Views";
        private const string ControllerDefaultName = "Controller";
        private const string HtmlFileExtension = ".html";
        private const string DirectorySeparator = "/";

        private string GetCurrentControllerName() => this.GetType().Name.Replace(ControllerDefaultName, string.Empty);

        protected IHttpResponse View([CallerMemberName] string viewName = "")
        {
            string filePath = RootDirectoryRelativePath + ViewFolderName + DirectorySeparator
                + this.GetCurrentControllerName() + DirectorySeparator + viewName + HtmlFileExtension;

            if (!File.Exists(filePath))
            {
                return new BadRequestResult($"View {viewName} not found.", HttpResponseStatusCode.NotFound);
            }

            var fileContent = File.ReadAllText(filePath);

            var response = new HtmlResult(fileContent, HttpResponseStatusCode.Ok);
            return response;
        }
    }
}