using SIS.Framework.Contracts.ActionResults;

namespace SIS.Framework.ActionResults
{
    public class RedirectResult : IRedirectable
    {
        public RedirectResult(string redirectUrl)
        {
            this.RedirectUrl = redirectUrl;
        }

        public string RedirectUrl { get; set; }

        public string Invoke()
        {
            return this.RedirectUrl;
        }
    }
}
