using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class FinancialGoalConfiguration : IEntityTypeConfiguration<FinancialGoal>
{
    public void Configure(EntityTypeBuilder<FinancialGoal> builder)
    {
        builder.HasKey(g => g.Id);
        builder.OwnsOne(g => g.CurrentAmount);
        builder.OwnsOne(g => g.TargetAmount);
    }
}