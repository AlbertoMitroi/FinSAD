using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

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

            // Seed user
            var testUser = new User
            {
                Id = 1,
                UserName = "testUserName",
                NormalizedUserName = "TestUserName",
                Email = "test@gmail.com",
                NormalizedEmail = "TEST@GMAIL.COM",
                EmailConfirmed = true,
                SecurityStamp = "A1B2C3D4-E5F6-7890-1234-56789ABCDEF0"
            };

            var hasher = new PasswordHasher<User>();
            testUser.PasswordHash = hasher.HashPassword(testUser, "Parola@123");

            builder.HasData(testUser);
        }
    }
}
