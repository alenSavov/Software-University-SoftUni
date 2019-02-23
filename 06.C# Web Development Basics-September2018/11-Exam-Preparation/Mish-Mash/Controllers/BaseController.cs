using Mish_Mash.Data;
using SIS.Framework.Controllers;

namespace Mish_Mash.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            this.Db = new ApplicationDbContext();
        }

        protected ApplicationDbContext Db { get; set; }
    }    
}
