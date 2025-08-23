using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviePages.Data;

namespace MoviePages.Pages
{
    public class CreateModel : PageModel
    {
        private readonly MovieDbContext _db;

        public CreateModel(MovieDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Movies.Add(Movie);
            await _db.SaveChangesAsync();

            return RedirectToPage("index");
        }
    }
}
