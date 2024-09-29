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

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortBy { get; set; } = "year";

        [BindProperty(SupportsGet = true)]
        public string? SortOrder { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? MinYear { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? MaxYear { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1; // Default page number

        public int PageSize { get; set; } = 10; // Movies per page
        public int TotalPages { get; set; }

        public async Task<IActionResult> OnGet()
        {
            IQueryable<Movie> query = _db.Movies;

            query = ApplySearch(query);
            query = ApplyYearRangeFilter(query);
            query = ApplySortOrder(query);

            int totalMovies = await query.CountAsync();
            TotalPages = (int)Math.Ceiling(totalMovies / (double)PageSize);

            MovieList = await query
                .Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();

            return Page();

        }

        private IQueryable<Movie> ApplySortOrder(IQueryable<Movie> query)
        {
            if (SortBy == "year")
            {
                if (SortOrder == "asc")
                {
                    query = query.OrderBy(m => m.Year);
                }
                else
                          if (SortOrder == "desc")
                {
                    query = query.OrderByDescending(m => m.Year);
                }
            }
            else if (SortBy == "name")
            {
                if (SortOrder == "asc")
                {
                    query = query.OrderBy(m => m.Name);
                }
                else
                        if (SortOrder == "desc")
                {
                    query = query.OrderByDescending(m => m.Name);
                }
            }

            return query;
        }

        private IQueryable<Movie> ApplyYearRangeFilter(IQueryable<Movie> query)
        {
            if (MinYear.HasValue)
            {
                query = query.Where(m => m.Year >= MinYear);
            }

            if (MaxYear.HasValue)
            {
                query = query.Where(m => m.Year <= MaxYear);
            }

            return query;
        }

        private IQueryable<Movie> ApplySearch(IQueryable<Movie> query)
        {
            if (SearchTerm is not null)
            {
                query = query.Where(m => m.Name.Contains(SearchTerm));
            }

            return query;
        }
    }
}
