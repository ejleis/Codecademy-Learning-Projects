using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCountry.Data;
using RazorCountry.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RazorCountry.Pages.Countries
{
    public class DetailModel : PageModel
    {
        private readonly CountryContext _context;

        public DetailModel(CountryContext context)
        {
            _context = context;
        }

        public CountryStat Country { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var country = from c in _context.CountriesDbSet
                          where c.CountryID == id
                          select new CountryStat
                          {
                              CountryID = c.CountryID,
                              ContinentID = c.ContinentID,
                              Name = c.Name,
                              Population = c.Population,
                              Area = c.Area,
                              UnitedNationsDate = c.UnitedNationsDate,
                              Density = c.Population / c.Area
                          };

            Country = await country.SingleOrDefaultAsync();
            // Country = await _context.CountriesDbSet.FindAsync(id);

            if (Country == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
