using FinSAD.Domain.Enums;
using FinSAD.Domain.ValueObjects;

namespace FinSAD.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public Money Amount { get; set; } = new Money(0, "USD");
        public string Name { get; set; } = string.Empty;
        public TransactionKind TransactionKind { get; set; }
        public string Description { get; set; } = string.Empty;
        public int? CategoryId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public int? PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }
        public Location Location { get; set; } = new Location(string.Empty, string.Empty);

        public void Create() { }
        public void Edit() { }
        public void Delete() { }
    }
}