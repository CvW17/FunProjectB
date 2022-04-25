#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FunProjectB.Data;
using FunProjectB.Models;

namespace FunProjectB.Pages.City
{
    public class IndexModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public IndexModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        public IList<Cities> Cities { get;set; }

        public async Task OnGetAsync()
        {
            Cities = await _context.Cities.ToListAsync();
        }
    }
}
