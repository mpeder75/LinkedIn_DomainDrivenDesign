namespace Wpm.Managment.Domain.ValueObjects
{
    public class Name : IEquatable<Name>
    {
        public string EntityName { get; }

        public Name(string entityName)
        {
            if (string.IsNullOrWhiteSpace(entityName))
                throw new ArgumentException("Name cannot be empty", nameof(entityName));

            EntityName = entityName;
        }
        
        public bool Equals(Name? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return EntityName == other.EntityName;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Name)obj);
        }

        public override int GetHashCode()
        {
            return EntityName.GetHashCode();
        }

        public static bool operator ==(Name? left, Name? right)
        {
            if (left is null) return right is null;
            return left.Equals(right);
        }

        public static bool operator !=(Name? left, Name? right)
        {
            return !(left == right);
        }
    }
}
