using Domain.Transactions;
using Domain.Users;

namespace Domain.Accounts;

public sealed class Account
{
    public int Id { get; set; }
    public Company Company { get; set; }
    public string Reference { get; set; }
    public string Name { get; set; }
    public AccountType Type { get; set; }
    public ICollection<TransactionDetail> TransactionDetails { get; set; }
}