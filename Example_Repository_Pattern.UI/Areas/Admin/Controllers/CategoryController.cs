using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using Example_Repository_Pattern.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_Repository_Pattern.UI.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Category data)
        {
            service.CategoryService.Add(data);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult List()
        {
            List<Category> model = service.CategoryService.GetActive();
            return View(model);
        }
        public ActionResult Update(Guid id)
        {
            Category category = service.CategoryService.GetByID(id);
            CatergoryDTO model = new CatergoryDTO();
            model.ID = category.ID;
            model.Name = category.Name;
            model.Description = category.Description;
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(CatergoryDTO data)
        {
            Category category = service.CategoryService.GetByID(data.ID);
            category.Name = data.Name;
            category.Description = data.Description;
            service.CategoryService.Update(category);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult Delete(Guid id)
        {
            service.CategoryService.Remove(id);
            return Redirect("/Admin/Category/List");
        }
    }
}