using Domain.Accounts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Application;

public interface IPaperdorkContext
{
    DbSet<Company> Companies { get; }
    DbSet<Account> Accounts { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
