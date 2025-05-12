using FinSAD.Domain.Entities;
using FinSAD.Domain.Enums;
using FinSAD.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace FinSAD.Persistence.Seed
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Users
            modelBuilder.Entity<User>().HasData(
                new { Id = 1 }
            );
            modelBuilder.Entity<User>().OwnsOne(u => u.Email).HasData(
                new { UserId = 1, Address = "albertomitroi@gmail.com" }
            );
            modelBuilder.Entity<User>().OwnsOne(u => u.PasswordHash).HasData(
                new { UserId = 1, Hash = "hashed@password@123" }
            );

            // Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Groceries", IsCustom = false },
                new Category { Id = 2, Name = "Entertainment", IsCustom = false },
                new Category { Id = 3, Name = "Custom Category", IsCustom = true }
            );

            // Payment Methods
            modelBuilder.Entity<PaymentMethod>().HasData(
                new { Id = 1, UserId = 1, Type = PaymentMethodType.CreditCard },
                new { Id = 2, UserId = 1, Type = PaymentMethodType.Cash }
            );

            // Budget
            modelBuilder.Entity<Budget>().HasData(
                new { Id = 1, UserId = 1, CategoryId = 1, Month = 5, Year = 2025 }
            );
            modelBuilder.Entity<Budget>().OwnsOne(b => b.Limit).HasData(
                new { BudgetId = 1, Amount = 500m, Currency = "USD" }
            );

            // Financial Goal
            modelBuilder.Entity<FinancialGoal>().HasData(
                new { Id = 1, Name = "Vacation Fund", Deadline = new DateTime(2025, 12, 31) }
            );
            modelBuilder.Entity<FinancialGoal>().OwnsOne(g => g.TargetAmount).HasData(
                new { FinancialGoalId = 1, Amount = 2000m, Currency = "USD" }
            );
            modelBuilder.Entity<FinancialGoal>().OwnsOne(g => g.CurrentAmount).HasData(
                new { FinancialGoalId = 1, Amount = 600m, Currency = "USD" }
            );

            // Notification
            modelBuilder.Entity<Notification>().HasData(
                new
                {
                    Id = 1,
                    UserId = 1,
                    Message = "You have a new transaction.",
                    Type = "Info",
                    Status = NotificationStatus.Unread,
                    Timestamp = new DateTime(2025, 3, 31)
                }
            );

            // Transaction
            modelBuilder.Entity<Transaction>().HasData(
                new { Id = 1, UserId = 1, Name = "Grocery Shopping", TransactionKind = TransactionKind.Expense, CategoryId = 1, PaymentMethodId = 1, Description = "Bought groceries at Walmart" }
            );
            modelBuilder.Entity<Transaction>().OwnsOne(t => t.Amount).HasData(
                new { TransactionId = 1, Amount = 80m, Currency = "USD" }
            );
            modelBuilder.Entity<Transaction>().OwnsOne(t => t.Location).HasData(
                new { TransactionId = 1, Name = "Walmart", Coordinates = "40.7128,-74.0060" }
            );

            // Finance Report
            modelBuilder.Entity<FinanceReport>().HasData(
                new
                {
                    Id = 1,
                    UserId = 1,
                    Format = ReportFormat.Pdf,
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 3, 31)
                }
            );

            // Recurring Transaction
            modelBuilder.Entity<RecurringTransaction>().HasData(
                new { Id = 1, StartDate = new DateTime(2025, 1, 1), EndDate = new DateTime(2025, 12, 31), Frequency = "Monthly" }
            );

            // Cards for User Alberto Mitroi
            // Cards for User Alberto Mitroi
            modelBuilder.Entity<Card>().HasData(
                new
                {
                    Id = 1,
                    UserId = 1,
                    Currency = "USD",
                    Amount = 27119m,
                    Holder = "Alberto Mitroi",
                    Expiry = new DateTime(2035, 12, 1),
                    Cvv = "**5",
                    CurrencyLogo = "USD.png",
                    ProviderLogo = "citigroup.png"
                },
                new
                {
                    Id = 2,
                    UserId = 1,
                    Currency = "GBP",
                    Amount = 12102m,
                    Holder = "Alberto Mitroi",
                    Expiry = new DateTime(2030, 8, 1),
                    Cvv = "**9",
                    CurrencyLogo = "GBP.png",
                    ProviderLogo = "master card.png"
                },
                new
                {
                    Id = 3,
                    UserId = 1,
                    Currency = "EURO",
                    Amount = 7382m,
                    Holder = "Alberto Mitroi",
                    Expiry = new DateTime(2026, 6, 1),
                    Cvv = "**2",
                    CurrencyLogo = "EURO.png",
                    ProviderLogo = "visa.png"
                }
            );
        }
    }
}
