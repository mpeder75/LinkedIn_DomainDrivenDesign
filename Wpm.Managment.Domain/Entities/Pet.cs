using Wpm.Managment.Domain.Base;
using Wpm.Managment.Domain.ValueObjects;

namespace Wpm.Managment.Domain.Entities;

public class Pet : DomainEntity<Pet>
{
    public Name Name { get; init; }
    public Age Age { get; init; }
    public string Color { get; set; }
    public decimal Weight { get; set; }
    public SexOfPet SexOfPet { get; set; }

    public Pet(Name name, Age age)
    {
        Name = name;
        Age = age;
    }


    // Constructor for testing purposes
    public Pet(Guid id, Name name, Age age) : this(name, age)
    {
        Id = id;
    }
}

public enum SexOfPet
{
    Male,
    Female
}