using FinSAD.Domain.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace FinSAD.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public ICollection<Transaction> Transactions { get; set; } = [];
        public ICollection<Budget> Budgets { get; set; } = [];
        public ICollection<Notification> Notifications { get; set; } = [];
        public ICollection<PaymentMethod> PaymentMethods { get; set; } = [];
        public ICollection<Card> Cards { get; set; } = [];

        public void Register() { }
        public void Login() { }
        public void Logout() { }
        public void ResetPassword() { }
        public void UpdateProfile() { }
    }
}