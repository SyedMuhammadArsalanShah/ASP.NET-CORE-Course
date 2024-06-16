using Microsoft.AspNetCore.Mvc;

namespace Lecture04AttributeBasedRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
