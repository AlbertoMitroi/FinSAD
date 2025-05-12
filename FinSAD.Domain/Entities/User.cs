using FinSAD.Domain.ValueObjects;

namespace FinSAD.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public Email Email { get; set; }
        public PasswordHash PasswordHash { get; set; }

        public ICollection<Transaction> Transactions { get; set; } = [];
        public ICollection<Budget> Budgets { get; set; } = [];
        public ICollection<Notification> Notifications { get; set; } = [];
        public ICollection<PaymentMethod> PaymentMethods { get; set; } = [];

        public void Register() { }
        public void Login() { }
        public void Logout() { }
        public void ResetPassword() { }
        public void UpdateProfile() { }
    }
}