using FinSAD.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace FinSAD.Persistence
{
    public class DataDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FinanceReport> FinanceReports { get; set; }
        public DbSet<FinancialGoal> FinancialGoals { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<RecurringTransaction> RecurringTransactions { get; set; }

        public DataDbContext(DbContextOptions<DataDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataDbContext).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings =>
                warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}
