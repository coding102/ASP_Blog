using ASP_Blog.Infrastructure;
using System.Web.Mvc;

namespace ASP_Blog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        public ActionResult Index ()
        {
            return View();
        }
    }
}