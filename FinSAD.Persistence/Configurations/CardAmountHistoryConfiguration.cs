using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinSAD.Persistence.Configurations
{
    public class CardAmountHistoryConfiguration : IEntityTypeConfiguration<CardAmountHistory>
    {
        public void Configure(EntityTypeBuilder<CardAmountHistory> builder)
        {
            builder.HasKey(h => h.Id);

            builder.HasOne(h => h.Card)
                .WithMany(c => c.AmountHistory)
                .HasForeignKey(h => h.CardId);

            builder.Property(h => h.Year).IsRequired();
            builder.Property(h => h.Month).IsRequired();
            builder.Property(h => h.Amount).HasColumnType("decimal(18,2)");
        }
    }
}
