using Domain.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configuration;

internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.HasKey(transaction => transaction.Id);
        
        builder
            .Property(transaction => transaction.Description)
            .HasMaxLength(255)
            .IsRequired(false);

        builder
            .Property(transaction => transaction.Reference)
            .HasMaxLength(100)
            .IsRequired(false);

        builder
            .HasMany(transaction => transaction.TransactionDetails)
            .WithOne(transactionDetail => transactionDetail.Transaction);
    }
}
