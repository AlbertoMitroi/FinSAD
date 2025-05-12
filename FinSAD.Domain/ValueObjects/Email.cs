namespace FinSAD.Domain.ValueObjects
{
    public sealed class Email
    {
        public string Address { get; }

        private Email() { }

        public Email(string address)
        {
            if (string.IsNullOrWhiteSpace(address) || !address.Contains("@"))
                throw new ArgumentException("Invalid email address.");

            Address = address;
        }

        public override bool Equals(object? obj)
            => obj is Email e && Address == e.Address;

        public override int GetHashCode() => Address.GetHashCode();
        public override string ToString() => Address;
    }
}