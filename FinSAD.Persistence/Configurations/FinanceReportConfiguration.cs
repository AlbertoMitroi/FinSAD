using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class FinanceReportConfiguration : IEntityTypeConfiguration<FinanceReport>
{
    public void Configure(EntityTypeBuilder<FinanceReport> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Format).HasConversion<string>();
    }
}