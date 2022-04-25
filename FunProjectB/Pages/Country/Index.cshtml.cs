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
    public class IndexModel : PageModel
    {
        private readonly FunProjectB.Data.Context _context;

        public IndexModel(FunProjectB.Data.Context context)
        {
            _context = context;
        }

        public IList<Countries> Countries { get;set; }

        public async Task OnGetAsync()
        {
            Countries = await _context.Countries.ToListAsync();
        }
    }
}
