using Wpm.Managment.Domain.ValueObjects;
using Wpm.SharedKernel;

namespace Wpm.Managment.Domain.Entities;

public class Breed : DomainEntity
{
    public string Name { get; init; }

    public WeightRange MaleIdealWeight { get; init; }
    public WeightRange FemaleIdealWeight { get; init; }

    public Breed(Guid id, string name, WeightRange maleIdealWeight, WeightRange femaleIdealWeight)
    {
        Id = id;
        Name = name;
        MaleIdealWeight = maleIdealWeight;
        FemaleIdealWeight = femaleIdealWeight;
    }
}