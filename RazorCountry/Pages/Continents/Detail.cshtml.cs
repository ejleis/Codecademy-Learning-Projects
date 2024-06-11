using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCountry.Data;
using RazorCountry.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorCountry.Pages.Continents
{
    public class DetailModel : PageModel
    {
        private readonly CountryContext _context;

        public DetailModel(CountryContext context)
        {
            _context = context;
        }

        public Continent Continent { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            //Continent = await _context.Continents.FindAsync(id);
            // OR LINQ approach
            Continent = await _context.Continents
                .Include(c => c.Countries)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);



            if (Continent == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
