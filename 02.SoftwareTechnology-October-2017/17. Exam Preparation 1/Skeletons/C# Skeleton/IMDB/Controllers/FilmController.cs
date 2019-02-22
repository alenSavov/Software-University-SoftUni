using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new IMDBDbContext())
            {
                var film = db.Film.Tolist();
                return View(film);
            }
        }
    }
}


[HttpGet]
[Route("create")]
public ActionResult Create()
{
    //TODO: Implement me ...
    return View();
}

[HttpPost]
[Route("create")]
[ValidateAntiForgeryToken]
public ActionResult Create(Film film)
{
    //TODO: Implement me ...
    return View();
}

[HttpGet]
[Route("edit/{id}")]
public ActionResult Edit(int? id)
{
    //TODO: Implement me ...
    return View();
}

[HttpPost]
[Route("edit/{id}")]
[ValidateAntiForgeryToken]
public ActionResult EditConfirm(int? id, Film filmModel)
{
    //TODO: Implement me ...
    return View();
}

[HttpGet]
[Route("delete/{id}")]
public ActionResult Delete(int? id)
{
    //TODO: Implement me ...
    return View();
}

[HttpPost]
[Route("delete/{id}")]
[ValidateAntiForgeryToken]
public ActionResult DeleteConfirm(int? id, Film filmModel)
{
    //TODO: Implement me ...
    return View();
}

