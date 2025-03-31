using Domain.Accounts;

namespace Domain.Transactions;

public sealed class TransactionDetail
{
    public int Id { get; set; }
    public Transaction Transaction { get; set; }
    public Account Account { get; set; }
    public decimal CreditAmount { get; set; }
    public decimal DebitAmount { get; set; }
}