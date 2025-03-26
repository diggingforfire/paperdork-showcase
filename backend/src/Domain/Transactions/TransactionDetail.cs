namespace Domain.Transactions;

public sealed class TransactionDetail
{
    public int Id { get; set; }
    public int TransactionId { get; set; }
    public int AccountId { get; set; }
    public decimal CreditAmount { get; set; }
    public decimal DebitAmount { get; set; }
}