using Microsoft.AspNetCore.Mvc;

namespace FunProjectB.Controller
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public JsonResult getCountry(int? country)
        //{

        //}
    }
}
