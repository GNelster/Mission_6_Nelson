using Microsoft.EntityFrameworkCore;
namespace Mission_6_Nelson.Models;

// Liason between Database and Program
public class MovieFormContext : DbContext
{
    public MovieFormContext(DbContextOptions<MovieFormContext> options) : base(options)
    {
    }
    
    public DbSet<Movie> Movies { get; set; }
}