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
    public class DeleteModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public DeleteModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Continents = await _context.Continents.FindAsync(id);

            if (Continents != null)
            {
                _context.Continents.Remove(Continents);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
