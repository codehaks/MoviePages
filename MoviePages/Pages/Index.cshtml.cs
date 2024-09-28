using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviePages.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Movie>? MovieList { get; set; }
        public void OnGet()
        {
            var movies = new List<Movie>
{
    new Movie { Name = "Titanic", Year = 1997 },
    new Movie { Name = "The Shawshank Redemption", Year = 1994 },
    new Movie { Name = "The Godfather", Year = 1972 },
    new Movie { Name = "The Dark Knight", Year = 2008 },
    new Movie { Name = "Pulp Fiction", Year = 1994 },
    new Movie { Name = "Forrest Gump", Year = 1994 },
    new Movie { Name = "Inception", Year = 2010 },
    new Movie { Name = "Fight Club", Year = 1999 },
    new Movie { Name = "The Matrix", Year = 1999 },
    new Movie { Name = "The Lord of the Rings: The Return of the King", Year = 2003 }
};

            MovieList=movies;

        }
    }
}
