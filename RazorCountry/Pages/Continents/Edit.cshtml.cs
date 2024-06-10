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

        //3
        [BindProperty]
        public Continent Continent { get; set; }

        // 4
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                Continent = new Continent();
            }
            else
            {
                Continent = await _context.Continents.FindAsync(id);

                if (Continent == null)
                {
                    return NotFound();
                }
            }
            return Page();
        } // end of OnGetAsync method

        // 5
        public async Task<IActionResult> OnPostAsync(string id)
        {
            // 6
            if (!ModelState.IsValid)
            {
                return Page();
            }// end of 6

            // 7
            if (id == null)
            {
                _context.Continents.Add(Continent);
            }
            else
            {
                _context.Attach(Continent).State = EntityState.Modified;
            } //end of 7

            //8
            await _context.SaveChangesAsync();

            //9
            return RedirectToPage("./Index");
        } //end of 5
    }
}
