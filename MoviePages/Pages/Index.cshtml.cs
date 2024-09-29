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

        [BindProperty(SupportsGet =true)]
        public string? SearchTerm { get; set; }
        public async Task<IActionResult> OnGet()
        {
            IQueryable<Movie> query = _db.Movies;

            if (SearchTerm is not null)
            {
                query=query.Where(m=>m.Name.Contains(SearchTerm));
            }

            MovieList = await query.ToListAsync();
            return Page();

        }
    }
}
