using Microsoft.EntityFrameworkCore;
using LibraryAPI.Models;

namespace LibraryAPI.DatabaseContext;

public class ContextDataBase : DbContext
{
    public ContextDataBase(DbContextOptions options) : base(options)
    {
    }

    // Model - Tables
    public DbSet<User> Users { get; set; }
    public DbSet<Login> Logins { get; set; }
    
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookRent> BookRents { get; set; }
}