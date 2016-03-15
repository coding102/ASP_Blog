using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_Blog.ViewModels;

namespace ASP_Blog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
            });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if(!ModelState.IsValid)
                return View(form);

            return Content("The form is valid!");
        }
    }
}