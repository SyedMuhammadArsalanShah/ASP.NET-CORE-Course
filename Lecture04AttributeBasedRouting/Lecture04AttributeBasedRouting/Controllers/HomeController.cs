using Microsoft.AspNetCore.Mvc;

namespace Lecture04AttributeBasedRouting.Controllers
{

    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        //[Route("[action]")]

        public IActionResult Index()
        {
            return View();
        }

        //[Route("~/")]
        [Route("Home/About")]
        public IActionResult Data()
        {
            return View("~/Views/Home/About.cshtml");
        }


        [Route("Home/Details/{id?}")]
        public int Detail(int? id)
        {
            return id ?? 1;
        }



    }
}
