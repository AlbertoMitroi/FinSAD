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

            // Seed data pentru ultimele 12 luni
            var historyEntries = new List<CardAmountHistory>();
            var baseDate = new DateTime(2025, 5, 1);
            var fixedAmounts = new List<decimal[]>
            {
                new decimal[] { 2719, 3120, 1998, 4400, 3888, 5221, 3790, 6100, 2890, 3333, 4122, 3911 },
                new decimal[] { 1280, 1402, 1500, 1421, 1600, 1580, 1700, 1900, 2100, 2000, 1850, 1755 },
                new decimal[] { 730, 820, 790, 880, 860, 840, 920, 1010, 980, 940, 895, 875 }
            };

            int historyId = 1;
            for (int cardIndex = 0; cardIndex < 3; cardIndex++)
            {
                for (int i = 0; i < 12; i++)
                {
                    var date = baseDate.AddMonths(-i);
                    historyEntries.Add(new CardAmountHistory
                    {
                        Id = historyId++,
                        CardId = cardIndex + 1,
                        Year = date.Year,
                        Month = date.Month,
                        Amount = fixedAmounts[cardIndex][i]
                    });
                }
            }

            builder.HasData(historyEntries);
        }
    }
}
