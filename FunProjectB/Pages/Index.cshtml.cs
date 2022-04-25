using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FunProjectB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public IndexModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        public SelectList Continents { get; set; }
        public SelectList Countries { get; set; }
        public SelectList Cities { get; set; }
        public void OnGet()
        {
            this.Continents = new SelectList(this._context.Continents, "ID", "Continent");
            this.Countries = new SelectList(this._context.Countries, "ID", "Country");
            this.Cities = new SelectList(this._context.Cities, "ID", "City");
        }

        //public ActionResult Index()
        //{
        //    return Json(Continents, JsonRequestBehaviour.AllowGet);
        //}

        //public ActionResult getCountry(int ID)
        //{
        //    var country = Countries.Where(c => c.)
        //    return Json(Continents, JsonRequestBehaviour.AllowGet);
        //}
    }
}