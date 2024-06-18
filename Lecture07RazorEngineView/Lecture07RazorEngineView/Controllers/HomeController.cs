using Microsoft.AspNetCore.Mvc;

namespace Lecture07RazorEngineView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
