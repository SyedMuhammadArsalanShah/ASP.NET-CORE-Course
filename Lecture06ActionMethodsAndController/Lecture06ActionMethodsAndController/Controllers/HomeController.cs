using Microsoft.AspNetCore.Mvc;

namespace Lecture06ActionMethodsAndController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public JsonResult JsonResult()
        {
            var name = "SMASB";
            return Json(new { data = name });
        }



        public ContentResult ContentResult()
        {
            return Content("I am ContentResult");
        }







    }
}
