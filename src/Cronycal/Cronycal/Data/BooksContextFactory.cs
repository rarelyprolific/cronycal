using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cronycal.Data;

public class BooksContextFactory : IDesignTimeDbContextFactory<BooksContext>
{
    public BooksContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BooksContext>();

        // This is used at design-time but currently requires a real connection string,
        // because EF Core's design-time services will attempt to connect to the database to
        // gather metadata for migrations. However, since the connection string points to a
        // localdb instance, it should not cause issues during development, and it allows
        // EF Core to function properly for design-time operations.
        // FIXME: We can possibly avoid the real connection string by moving the design-time
        // services to a separate class library later.
        optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=Cronycal;Trusted_Connection=True;"
        );

        return new BooksContext(optionsBuilder.Options);
    }
}
