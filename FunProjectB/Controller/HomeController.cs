using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FunProjectB.Controller
{
    public class HomeController : Controller
    {
        public SelectList Continents { get; set; }
        public SelectList Countries { get; set; }
        public SelectList Cities { get; set; }

        public ActionResult Index()
        {
            return Json(Continents, JsonRequestBehaviour.AllowGet);
        }

        public ActionResult getCountry(int ID)
        {
            var country = Countries.Where(c => c.Continent)
            return Json(Continents, JsonRequestBehaviour.AllowGet);
        }
    }
}
