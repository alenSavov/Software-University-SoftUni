using SIS.HTTP.Requests;
using SIS.HTTP.Responses;

namespace IRunes.App.Controllers
{
    public class UsersController : BaseController
    {
        public IHttpResponse Login(IHttpRequest request) => this.View();

        public IHttpResponse Register(IHttpRequest request) => this.View();
    }
}
