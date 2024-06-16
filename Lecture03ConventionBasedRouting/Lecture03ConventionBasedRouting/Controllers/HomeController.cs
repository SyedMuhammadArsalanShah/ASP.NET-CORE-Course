using Microsoft.AspNetCore.Mvc;

namespace Lecture03ConventionBasedRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
