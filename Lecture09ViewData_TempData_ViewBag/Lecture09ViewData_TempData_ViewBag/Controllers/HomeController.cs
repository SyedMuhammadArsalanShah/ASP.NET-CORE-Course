using Microsoft.AspNetCore.Mvc;

namespace Lecture09ViewData_TempData_ViewBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewData["d1"] = "Ali";
            ViewData["d2"] = 24;
            ViewData["d3"] = DateTime.Now.ToShortDateString();



            String[] students = {"Ali", "Hussain", "Hasan" };
            ViewData["d4"] = students ;

         




      
            return View();
        }

        public IActionResult About()
        {

            TempData["d1"] = "Ali";
            TempData["d2"] = 24;
            TempData["d3"] = DateTime.Now.ToShortDateString();



            String[] students = { "Ali", "Hussain", "Hasan" };
            TempData["d4"] = students;






            return View();
        }

        public IActionResult Contact()
        {


            ViewBag.d1 = "Ali";
            ViewBag.d2 = 24;
            ViewBag.d3 = DateTime.Now.ToShortDateString();



            String[] students = { "Ali", "Hussain", "Hasan" };
            ViewBag.d4 = students;













            return View();
        }





    }
}
