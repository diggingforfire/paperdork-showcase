using Application;
using Domain.Accounts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public sealed class PaperdorkContext(DbContextOptions<PaperdorkContext> options) 
    : DbContext(options), IPaperdorkContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Account> Accounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PaperdorkContext).Assembly);

    }
}
