using Cronycal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cronycal.Data;

public class BooksContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();
}
