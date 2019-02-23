using SIS.HTTP.Enums;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer.Results;

namespace IRunes.App.Controllers
{
    public class HomeControllers : BaseController
    {
        public IHttpResponse Index(IHttpRequest request) => this.View();
    }
}
