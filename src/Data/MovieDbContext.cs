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
            new Movie { Id = 10, Name = "The Lord of the Rings: The Return of the King", Year = 2003 }
        );
    }

}
