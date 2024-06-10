using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCountry.Data;
using RazorCountry.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RazorCountry.Pages.Countries
{
    public class EditModel : PageModel
    {
        private readonly CountryContext _context;

        public EditModel(CountryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {

            if (id == null)
            {
                Country = new Country();
            }
            else
            {
                Country = await _context.Countries.FindAsync(id);

                if (Country == null) return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (!ModelState.IsValid) return Page();

            if (id == null)
            {
                _context.Countries.Add(Country);
            }
            else
            {
                _context.Attach(Country).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
