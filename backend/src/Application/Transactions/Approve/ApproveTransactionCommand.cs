using MediatR;

namespace Application.Transactions.Approve;

public sealed record ApproveTransactionCommand(int TransactionId) : IRequest;