using MediatR;

namespace Application.Transactions.Get;

public sealed record GetTransactionsQuery(int CompanyId) : IRequest<IReadOnlyCollection<TransactionResponse>>;