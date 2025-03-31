using Domain.Users;

namespace Domain.Transactions;

public sealed class Transaction
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Reference { get; set; }
    public DateTime Timestamp { get; set; }
    public TransactionState Status { get; set; }
    public Company Company { get; set; }
    public ICollection<TransactionDetail> TransactionDetails { get; set; }
}