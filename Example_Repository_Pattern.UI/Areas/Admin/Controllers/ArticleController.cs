using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using Example_Repository_Pattern.UI.Areas.Admin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_Repository_Pattern.UI.Areas.Admin.Controllers
{
    public class ArticleController : BaseController
    {
        // GET: Admin/Article
        public ActionResult Add()
        {
            AddArticleVM model = new AddArticleVM()
            {
                Categories = service.CategoryService.GetActive(),

                AppUsers = service.AppUserService.GetActive(),
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Article data)
        {
            service.ArticleService.Add(data);
            return Redirect("/Admin/Article/List");
        }

        public ActionResult List()
        {
            List<Article> model = service.ArticleService.GetActive();
            return View(model);
        }
    }
}