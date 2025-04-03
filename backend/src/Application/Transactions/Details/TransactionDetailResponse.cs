using Domain.Accounts;

namespace Application.Transactions.Details;

public sealed class TransactionDetailResponse
{
    public int Id { get; set; }
    public int TransactionId { get; set; }
    public decimal CreditAmount { get; set; }
    public decimal DebitAmount { get; set; }
    public string AccountReference { get; set; }
}