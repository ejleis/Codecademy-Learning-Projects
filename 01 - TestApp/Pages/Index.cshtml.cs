using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _01___TestApp.Pages
{
    public class IndexModel : PageModel
    {
        private int age;
        public int BirthYear = 1995;
        public int CurrentYear = 2023;
        public int Age {
            get
            {
                return age;
            } 
            private set{
                age = CurrentYear - value;
            }
        }
        public string Birthday {  get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Age = BirthYear;
            Birthday = new DateOnly(1995, 09, 27).ToShortDateString();

        }
    }
}
