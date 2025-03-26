namespace Domain.Accounts;

public sealed class Account
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public AccountType Type { get; set; }
}