using FinSAD.Domain.Entities;
using FinSAD.Persistence.Seed;
using Microsoft.EntityFrameworkCore;

namespace FinSAD.Persistence
{
    public class DataDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
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

            modelBuilder.Seed();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataDbContext).Assembly);
        }
    }
}
