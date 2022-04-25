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

namespace FunProjectB.Pages.Country
{
    public class DeleteModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public DeleteModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Countries Countries { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Countries = await _context.Countries.FirstOrDefaultAsync(m => m.ID == id);

            if (Countries == null)
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

            Countries = await _context.Countries.FindAsync(id);

            if (Countries != null)
            {
                _context.Countries.Remove(Countries);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
