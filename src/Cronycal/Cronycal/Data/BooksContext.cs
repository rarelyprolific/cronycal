using Cronycal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cronycal.Data;

public class BooksContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();

    // FIXME: Added so I can generate SQL via `dotnet ef migrations script --idempotent --context Cronycal.Data.BooksContext`
    // Replace OnConfiguring with a IDesignTimeDbContextFactory later.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer();
    }
}
