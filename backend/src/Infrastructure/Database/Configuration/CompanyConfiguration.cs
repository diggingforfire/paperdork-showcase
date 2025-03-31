using Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configuration;

internal sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(company => company.Id);
        
        builder
            .Property(company => company.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder
            .Property(company => company.Address)
            .HasMaxLength(255)
            .IsRequired();

        builder
            .HasMany(company => company.Accounts)
            .WithOne(account => account.Company)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(company => company.Transactions)
            .WithOne(transaction => transaction.Company)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
