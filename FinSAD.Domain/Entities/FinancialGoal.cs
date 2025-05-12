using FinSAD.Domain.ValueObjects;

namespace FinSAD.Domain.Entities
{
    public class FinancialGoal
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Money? TargetAmount { get; set; }
        public Money? CurrentAmount { get; set; }
        public DateTime Deadline { get; set; }

        public void UpdateProgress() { }
        public void Delete() { }
    }
}