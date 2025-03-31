using Domain.Accounts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configuration;

internal sealed class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(account => account.Id);
        
        builder
            .Property(account => account.Reference)
            .HasMaxLength(50)
            .IsRequired();

        builder
            .Property(account => account.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .HasMany(account => account.TransactionDetails)
            .WithOne(transaction => transaction.Account)
            .OnDelete(DeleteBehavior.NoAction);
    }
}