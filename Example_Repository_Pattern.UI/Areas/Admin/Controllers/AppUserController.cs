using Example_Repository_Pattern.DAL.ORM.Entity.Concrete;
using Example_Repository_Pattern.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example_Repository_Pattern.UI.Areas.Admin.Controllers
{
    public class AppUserController : BaseController
    {
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser data)
        {
            service.AppUserService.Add(data);
            return Redirect("/Admin/AppUser/List");
        }

        public ActionResult List()
        {
            List<AppUser> model = service.AppUserService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            AppUser appUser = service.AppUserService.GetByID(id);
            AppUserDTO model = new AppUserDTO();
            model.ID = appUser.ID;
            model.FirstName = appUser.FirstName;
            model.LastName = appUser.LastName;
            model.UserName = appUser.UserName;
            model.Email = appUser.Email;
           // model.Role = appUser.(Enum.GetName(Role));
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(AppUserDTO data)
        {
            AppUser app = service.AppUserService.GetByID(data.ID);
            app.FirstName = data.FirstName;
            app.LastName = data.LastName;
            app.UserName = data.UserName;
            app.Email = data.Email;
            //app.Role = data.Role;
            service.AppUserService.Update(app);
            return Redirect("/Admin/AppUser/List");
        }
       
        public ActionResult Delete(Guid id)
        {
            service.AppUserService.Remove(id);
            return Redirect("/Admin/AppUser/List");
        }
    }
}