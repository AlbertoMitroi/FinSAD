using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinSAD.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasMany(u => u.Transactions).WithOne(t => t.User).HasForeignKey(t => t.UserId);
            builder.HasMany(u => u.Budgets).WithOne(b => b.User).HasForeignKey(b => b.UserId);
            builder.HasMany(u => u.Notifications).WithOne(n => n.User).HasForeignKey(n => n.UserId);
            builder.HasMany(u => u.PaymentMethods).WithOne(p => p.User).HasForeignKey(p => p.UserId);
        }
    }
}