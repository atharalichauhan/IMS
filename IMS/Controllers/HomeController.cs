using System.Web.Mvc;

namespace IMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ClientServer()
        {
            return View("400");
        }

        public ViewResult ServerError()
        {
            return View("500");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}