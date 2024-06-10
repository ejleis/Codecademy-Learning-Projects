using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GroceryStore.Models;
// below using are default when creating pages, above using are only inserted since it was inserted in Codecademy
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GroceryStore.Pages
{
    public class DetailsModel : PageModel
    {
        List<GroceryItem> Foods = Inventory.ToList();
        public GroceryItem CurrentFood;
        public async Task<IActionResult> OnGetAsync(string name)
        {
            using(StreamWriter writer = new StreamWriter("log.txt", append:true))
            {
                await writer.WriteLineAsync($"{DateTime.Now} {name}");
            }
            CurrentFood = Foods.Find(foodName => foodName.Name == name);
            if (CurrentFood == null) return NotFound();
            return Page();
        }
    }
}
