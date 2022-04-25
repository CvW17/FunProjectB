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
    public class DetailsModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public DetailsModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        public Cities Cities { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cities = await _context.Cities.FirstOrDefaultAsync(m => m.ID == id);

            if (Cities == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
