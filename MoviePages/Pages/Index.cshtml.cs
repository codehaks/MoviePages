using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviePages.Data;

namespace MoviePages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MovieDbContext _db;

        public IndexModel(MovieDbContext db)
        {
            _db = db;
        }

        public IList<Movie>? MovieList { get; set; }
        public async Task<IActionResult> OnGet()
        {
            MovieList = await _db.Movies.ToListAsync();
            return Page();

        }
    }
}
