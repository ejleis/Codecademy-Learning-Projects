using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string SortField { get; set; }

        public SelectList Continents { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedContinent {  get; set; }

        public async Task OnGetAsync()
        {
            var countries = from country in _context.Countries
                            select country;

            if (!string.IsNullOrEmpty(SearchString))
            {
                countries = countries.Where(cty => cty.Name == SearchString);
            }

            switch (SortField)
            {
                case "ID":
                    countries = countries.OrderBy(cty => cty.ID);
                    break;
                case "Name":
                    countries = countries.OrderBy(cty => cty.Name);
                    break;
                case "ContinentID":
                    countries = countries.OrderBy(cty => cty.ContinentID);
                    break;
            }

            if (!string.IsNullOrEmpty(SelectedContinent))
            {
                countries = countries.Where(c => c.ContinentID == SelectedContinent);
            }

            // NOTE: You can use 'var' here instead of IQueryable<string>
            // using IQueryable<string> just explicitly telling anyone who reads this code(or compiler rather) that it's a query result of strings
            IQueryable<string> continentQuery = from c in _context.Continents
                                                orderby c.ID
                                                select c.ID;

            Continents = new SelectList(await continentQuery.ToListAsync());

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
