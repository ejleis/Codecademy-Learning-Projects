using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace RazorCountry.Pages.Countries
{
    public class IndexModel : PageModel
    {
        private readonly CountryContext _context;

        public IndexModel(CountryContext context)
        {
            _context = context;
        }

        public List<Country> Countries { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var countries = from country in _context.Countries
                            select country;
            if(!string.IsNullOrEmpty(SearchString))
            {
                countries = countries.Where(cty => cty.Name == SearchString);
            }
            Countries = await countries.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Country Country = await _context.Countries.FindAsync(id);

            if (Country != null)
            {
                _context.Countries.Remove(Country);
            }

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
