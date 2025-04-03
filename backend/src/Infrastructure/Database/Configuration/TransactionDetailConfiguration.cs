using Domain.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configuration;

internal class TransactionDetailConfiguration : IEntityTypeConfiguration<TransactionDetail>
{
    public void Configure(EntityTypeBuilder<TransactionDetail> builder)
    {
        builder.ToTable(nameof(Transaction.TransactionDetails));

        builder.HasKey(transactionDetail => transactionDetail.Id);
        
        builder
            .Property(transactionDetail => transactionDetail.CreditAmount)
            .HasPrecision(19, 4);

        builder
            .Property(transactionDetail => transactionDetail.DebitAmount)
            .HasPrecision(19, 4);
    }
}