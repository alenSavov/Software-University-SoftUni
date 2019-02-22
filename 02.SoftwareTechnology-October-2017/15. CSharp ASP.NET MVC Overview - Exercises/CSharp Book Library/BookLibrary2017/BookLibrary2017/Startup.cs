using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookLibrary2017.Startup))]
namespace BookLibrary2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
