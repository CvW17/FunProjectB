#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FunProjectB.Data;
using FunProjectB.Models;

namespace FunProjectB.Pages.Continent
{
    public class CreateModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public CreateModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Continents Continents { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Continents.Add(Continents);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
