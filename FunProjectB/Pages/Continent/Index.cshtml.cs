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

namespace FunProjectB.Pages.Continent
{
    public class IndexModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public IndexModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        public IList<Continents> Continents { get;set; }

        public async Task OnGetAsync()
        {
            Continents = await _context.Continents.ToListAsync();
        }
    }
}
