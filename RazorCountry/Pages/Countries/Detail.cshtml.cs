using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCountry.Data;
using RazorCountry.Models;
using System.Threading.Tasks;

namespace RazorCountry.Pages.Countries
{
    public class DetailModel : PageModel
    {
        private readonly CountryContext _context;

        public DetailModel(CountryContext context)
        {
            _context = context;
        }

        public Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            Country = await _context.Countries.FindAsync(id);

            if (Country == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
