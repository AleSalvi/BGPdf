using System.Web.Mvc;

namespace APINetFramework.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        public ActionResult Index()
        {
            ViewData["Title"] = "Home Page";

            return View();
        }
    }
}