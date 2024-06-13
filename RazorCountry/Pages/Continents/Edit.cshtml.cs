using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCountry.Data;
using RazorCountry.Models;
using System.Threading.Tasks;

namespace RazorCountry.Pages.Continents
{
    public class EditModel : PageModel
    {
        private readonly CountryContext _context;

        public EditModel(CountryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Continent Continent { get; set; }


        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                Continent = new Continent();
            }
            else
            {
                Continent = await _context.ContinentsDbSet.FindAsync(id);

                if (Continent == null)
                {
                    return NotFound();
                }
            }
            return Page();
        } // end of OnGetAsync method

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (!ModelState.IsValid) return Page();

            if (id == null)
            {
                _context.ContinentsDbSet.Add(Continent);
            }
            else
            {
                _context.Attach(Continent).State = EntityState.Modified;
            } 

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        } 
    }
}
