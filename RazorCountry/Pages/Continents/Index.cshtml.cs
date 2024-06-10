using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorCountry.Pages.Continents
{
    public class IndexModel : PageModel
    {
        private readonly CountryContext _context;

        public IndexModel(CountryContext context)
        {
            _context = context;
        }

        public List<Continent> Continents { get; set; }

        public async Task OnGetAsync()
        {
            Continents = await _context.Continents.ToListAsync();
        }

        [BindProperty]
        public string id { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (id == null)
            {
                return NotFound();
            }

            Continent Continent = await _context.Continents.FindAsync(id);

            if (Continent != null)
            {
                _context.Continents.Remove(Continent);
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
