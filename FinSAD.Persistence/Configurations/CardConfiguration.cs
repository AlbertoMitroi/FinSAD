using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasOne<User>()
               .WithMany(u => u.Cards)
               .HasForeignKey("UserId")
               .OnDelete(DeleteBehavior.Cascade);

        builder.Property(c => c.Currency)
               .IsRequired()
               .HasMaxLength(4);

        builder.Property(c => c.Amount)
               .IsRequired();

        builder.Property(c => c.Holder)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(c => c.Expiry)
               .IsRequired();

        builder.Property(c => c.Cvv)
               .IsRequired()
               .HasMaxLength(3);

        builder.Property(c => c.CurrencyLogo)
               .IsRequired();

        builder.Property(c => c.ProviderLogo)
               .IsRequired();
    }
}
