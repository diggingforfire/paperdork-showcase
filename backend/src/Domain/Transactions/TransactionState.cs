namespace Domain.Transactions;

public enum TransactionState
{
    Draft = 0,
    PendingApproval = 1,
    Approved = 2,
    Finalized = 3,
    Canceled = 4
}