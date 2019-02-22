using CSharpBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CSharpBlog.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (var db = new BlogDbContext())
            {
                var articles = db.Articles
                    .Include(a => a.Author)
                    .ToList();

                return View(articles);
            }

        }      
      
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
               var article = db.Articles
                    .Where(a => a.Id == id)
                    .Include(a => a.Author)
                    .FirstOrDefault();

                if (article == null )
                {
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                }

                return View(article);
            }


        }

        // GET: Article/Create        
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    var authorId = db.Users
                        .Where(u => u.UserName == this.User.Identity.Name)
                        .First()
                        .Id;

                    article.AuthorId = authorId;

                    db.Articles.Add(article);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(article);
        }

        //Get:Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                var article = db.Articles
                     .Where(a => a.Id == id)
                     .Include(a => a.Author)
                     .FirstOrDefault();

                if (article == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                }

                return View(article);
            }
        }

        //POST: Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                var article = db.Articles
                     .Where(a => a.Id == id)
                     .Include(a => a.Author)
                     .FirstOrDefault();

                if (article == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.NotFound);
                }

                if (CanEdit(article) == false)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }

                db.Articles.Remove(article);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            
        }

        //
        // GET: Article/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                var article = db.Articles
                    .Where(a => a.Id == id)
                    .First();

                if (article == null)
                {
                    return HttpNotFound();
                }

                if (!CanEdit(article))
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }

                var model = new ArticleViewModel
                {
                    Id = article.Id,
                    Title = article.Title,
                    Content = article.Content
                };

                return View(model);
            }
        }

        // POST: Article/Edit
        [HttpPost]
        public ActionResult Edit(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    var article = db.Articles
                        .FirstOrDefault(a => a.Id == model.Id);

                    if (article == null)
                    {
                        return HttpNotFound();
                    }

                    if (!CanEdit(article))
                    {
                        return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                    }

                    article.Title = model.Title;
                    article.Content = model.Content;

                    db.Entry(article).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }

        public bool CanEdit(Article article)
        {
            bool isAdmin = this.User.IsInRole("Admin");
            bool isAuthor = article.IsAuthor(this.User.Identity.Name);

            return (isAdmin || isAuthor);
        }


    }
}