using Domain.Accounts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Configuration;

internal sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Company> builder)
    {
        builder.HasKey(company => company.Id);
        builder.HasMany(company => company.Accounts);
    }
}
