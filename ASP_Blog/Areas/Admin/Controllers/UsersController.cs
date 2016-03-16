
using ASP_Blog.Infrastructure;
using System.Web.Mvc;

namespace ASP_Blog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTabAttribute("users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}