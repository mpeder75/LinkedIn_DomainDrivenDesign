namespace Wpm.SharedKernel
{
    public abstract class DomainEntity
    {
        // Guid - struct der sikre at objekter er unikt
        // init gør at property kan settes ved oprettelse, men gøres immutable bagefter.
        public Guid Id { get; init; }

        // No-args constructor - Sikre at entity Guid er unik når objekt oprettes
        // Guid.NewGuid() - Opretter en unik Guid for hele solution
        protected DomainEntity()
        {
            Id = Guid.NewGuid();
        }


        public bool Equals(DomainEntity? other)
        {
            return other?.Id == Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as DomainEntity);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(DomainEntity? left, DomainEntity? right)
        {
            return left?.Id == right?.Id;
        }

        public static bool operator !=(DomainEntity? left, DomainEntity? right)
        {
            return left?.Id != right?.Id;
        }
    }
}



