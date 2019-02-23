using SIS.HTTP.Requests.Contracts;
using SIS.HTTP.Responses.Contracts;

namespace CakesWebApp.Controllers
{
    public class AccountController : BaseController
    {
        public IHttpResponse Register(IHttpRequest request)
        {
            return this.View("Register");
        }

        public IHttpResponse Login(IHttpRequest request)
        {
            return this.View("Login");
        }

        public IHttpResponse DoRegister(IHttpRequest request)
        {
            return new HtmlResult("REGISTERED");
        }
    }
}
