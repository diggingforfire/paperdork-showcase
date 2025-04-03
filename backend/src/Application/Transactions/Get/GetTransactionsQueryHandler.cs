using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Transactions.Get;

internal sealed class GetTransactionsQueryHandler(IPaperdorkContext context) : IRequestHandler<GetTransactionsQuery, IReadOnlyCollection<TransactionResponse>>
{
    public async Task<IReadOnlyCollection<TransactionResponse>> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
    {
        var transactions = await context.Transactions
            .AsNoTracking()
            .Where(transaction => transaction.Company.Id == request.CompanyId)
            .Select(transaction => new TransactionResponse
            {
                Id = transaction.Id,
                Description = transaction.Description,
                Reference = transaction.Reference,
            })
            .ToListAsync(cancellationToken);

        return transactions.AsReadOnly();
    }
}
