using Domain.Accounts;

namespace Domain.Users;

public sealed class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public ICollection<Account> Accounts { get; set; }
}