namespace FinSAD.Domain.ValueObjects
{
    public sealed class PasswordHash
    {
        public string Hash { get; }

        private PasswordHash() { }

        public PasswordHash(string hash)
        {
            if (string.IsNullOrWhiteSpace(hash))
                throw new ArgumentException("Hash cannot be null or empty.");

            Hash = hash;
        }

        public override bool Equals(object? obj)
            => obj is PasswordHash p && Hash == p.Hash;

        public override int GetHashCode() => Hash.GetHashCode();
    }
}