namespace SIS.Framework.Contracts.ActionResults
{
    public interface IRedirectable : IActionResult
    {
        string RedirectUrl { get; }
    }
}
