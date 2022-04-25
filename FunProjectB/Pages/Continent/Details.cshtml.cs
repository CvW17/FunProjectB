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
    public class DetailsModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public DetailsModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        public Continents Continents { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Continents = await _context.Continents.FirstOrDefaultAsync(m => m.ID == id);

            if (Continents == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
