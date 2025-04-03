using MediatR;

namespace Application.Transactions.Details;

public sealed record GetTransactionDetailsQuery(int TransactionId) : IRequest<IReadOnlyCollection<TransactionDetailResponse>>;