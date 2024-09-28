using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviePages.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; } = default!;
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Page();
            // Save movie db
        }
    }
}
