using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviePages.Data;

namespace MoviePages.Pages
{
    public class EditModel : PageModel
    {
        private readonly MovieDbContext _db;

        public EditModel(MovieDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Movie? Movie { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            Movie = await _db.Movies.FindAsync(id);
            if (Movie == null) return Page();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var movie = await _db.Movies.FindAsync(Movie.Id);
            if (movie == null) return Page();

            movie.Name = Movie.Name;
            movie.Year = Movie.Year;

            await _db.SaveChangesAsync();
            return RedirectToPage("index");
        }
    }
}
