
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Transactions.Details;

public sealed class GetTransactionDetailsQueryHandler(IPaperdorkContext context) : IRequestHandler<GetTransactionDetailsQuery, IReadOnlyCollection<TransactionDetailResponse>>
{
    public async Task<IReadOnlyCollection<TransactionDetailResponse>> Handle(GetTransactionDetailsQuery request, CancellationToken cancellationToken)
    {
        var transactionDetails = await context.Transactions
            .AsNoTracking()
            .Include(t => t.TransactionDetails)
            .Where(transaction => transaction.Id == request.TransactionId)
            .SelectMany(transaction => transaction.TransactionDetails)
            .Select(detail => new TransactionDetailResponse
            {
                Id = detail.Id,
                TransactionId = request.TransactionId,
                CreditAmount = detail.CreditAmount,
                DebitAmount = detail.DebitAmount,
                AccountReference = detail.Account.Reference
            })
            .ToListAsync(cancellationToken);

        return transactionDetails.AsReadOnly();
    }
}