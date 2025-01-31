using Microsoft.EntityFrameworkCore;
using MovieAppWeb.Models;

namespace MovieAppWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
    {
        
    }
    public DbSet<Category> Categories { get; set; }
}