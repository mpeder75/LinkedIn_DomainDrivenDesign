using Wpm.Managment.Domain.Entities;

namespace Wpm.Managment.Domain.Base
{
    public abstract class DomainEntity<T> : IEquatable<T> where T : DomainEntity<T>
    {
        // Guid til entities
        // init gør at property kan settes ved oprettelse, men gøres immutable bagefter.
        public Guid Id { get; init; }

        // No-args constructor - Sikre at entity Guid er unik når objekt oprettes
        protected DomainEntity()
        {
            Id = Guid.NewGuid();
        }


        public bool Equals(T? other)
        {
            return other?.Id == Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as T);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(DomainEntity<T>? left, DomainEntity<T>? right)
        {
            return left?.Id == right?.Id;
        }

        public static bool operator !=(DomainEntity<T>? left, DomainEntity<T>? right)
        {
            return left?.Id != right?.Id;
        }
    }
}



