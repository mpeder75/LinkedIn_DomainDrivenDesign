namespace Wpm.Managment.Domain.ValueObjects
{
    public class Age : IEquatable<Age>
    {
        public int Value { get; }

        public Age(int value)
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative", nameof(value));

            Value = value;
        }

        public bool Equals(Age? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Age)obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(Age? left, Age? right)
        {
            if (left is null) return right is null;
            return left.Equals(right);
        }

        public static bool operator !=(Age? left, Age? right)
        {
            return !(left == right);
        }
    }
}