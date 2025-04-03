namespace Application.Transactions.Get;

public sealed class TransactionResponse
{
    public int Id { get; set; }
    public int TransactionId { get; set; }
    public string Description { get; set; }
    public string Reference { get; set; }
}
