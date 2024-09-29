using Microsoft.EntityFrameworkCore;

namespace MoviePages.Data;

public class MovieDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=movies.db");
        // base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = 1, Name = "Titanic", Year = 1997 },
            new Movie { Id = 2, Name = "The Shawshank Redemption", Year = 1994 },
            new Movie { Id = 3, Name = "The Godfather", Year = 1972 },
            new Movie { Id = 4, Name = "The Dark Knight", Year = 2008 },
            new Movie { Id = 5, Name = "Pulp Fiction", Year = 1994 },
            new Movie { Id = 6, Name = "Forrest Gump", Year = 1994 },
            new Movie { Id = 7, Name = "Inception", Year = 2010 },
            new Movie { Id = 8, Name = "Fight Club", Year = 1999 },
            new Movie { Id = 9, Name = "The Matrix", Year = 1999 },
            new Movie { Id = 10, Name = "The Lord of the Rings: The Return of the King", Year = 2003 },
            // Adding 20 more movies
            new Movie { Id = 11, Name = "Gladiator", Year = 2000 },
            new Movie { Id = 12, Name = "The Lion King", Year = 1994 },
            new Movie { Id = 13, Name = "Schindler's List", Year = 1993 },
            new Movie { Id = 14, Name = "Goodfellas", Year = 1990 },
            new Movie { Id = 15, Name = "Star Wars: Episode IV - A New Hope", Year = 1977 },
            new Movie { Id = 16, Name = "Avengers: Endgame", Year = 2019 },
            new Movie { Id = 17, Name = "Saving Private Ryan", Year = 1998 },
            new Movie { Id = 18, Name = "The Silence of the Lambs", Year = 1991 },
            new Movie { Id = 19, Name = "Jurassic Park", Year = 1993 },
            new Movie { Id = 20, Name = "The Departed", Year = 2006 },
            new Movie { Id = 21, Name = "The Prestige", Year = 2006 },
            new Movie { Id = 22, Name = "Memento", Year = 2000 },
            new Movie { Id = 23, Name = "The Green Mile", Year = 1999 },
            new Movie { Id = 24, Name = "Braveheart", Year = 1995 },
            new Movie { Id = 25, Name = "American Beauty", Year = 1999 },
            new Movie { Id = 26, Name = "The Usual Suspects", Year = 1995 },
            new Movie { Id = 27, Name = "The Avengers", Year = 2012 },
            new Movie { Id = 28, Name = "The Wolf of Wall Street", Year = 2013 },
            new Movie { Id = 29, Name = "Django Unchained", Year = 2012 },
            new Movie { Id = 30, Name = "Interstellar", Year = 2014 }
        );
    }

}
