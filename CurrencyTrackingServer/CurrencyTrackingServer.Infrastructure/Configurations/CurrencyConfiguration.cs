using CurrencyTrackingServer.Domain.Entities;
using CurrencyTrackingServer.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurrencyTrackingServer.Infrastructure.Configurations;
internal sealed class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.Property(p => p.Amount).HasColumnType("money");
        builder.Property(p => p.Type)
            .HasConversion(type => type.Value, value => CurrencyTypeEnum.FromValue(value));
    }
}
