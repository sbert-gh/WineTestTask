using Microsoft.EntityFrameworkCore;
using WineCatalog.Core.Models;

namespace WineCatalog.Infrastructure;

public class WineDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "WineCatalog");
    }

    public DbSet<Wine> Wines => Set<Wine>();
}
