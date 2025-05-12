using FinSAD.Domain.ValueObjects;

namespace FinSAD.Domain.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public Money Limit { get; set; } = new Money(0, "USD");
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public int Month { get; set; }
        public int Year { get; set; }
        public int? CategoryId { get; set; }

        public void CheckIfExceeded() { }
    }
}