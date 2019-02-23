using SIS.MvcFramework.Services;

namespace SIS.MvcFramework
{
    public interface IMvcApplication
    {
        void Configure();

        void ConfigureServices(IServiceCollection collection);
    }
}
