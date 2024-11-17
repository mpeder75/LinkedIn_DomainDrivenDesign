using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;

namespace Wpm.Managment.Domain;

public class FakeBreedService : IBreedService
{
    public readonly List<Breed> breeds =
    [
        new Breed(Guid.NewGuid(), "Beagle", new WeightRange(10m, 20m), new WeightRange(11, 18)),
        new Breed(Guid.NewGuid(), "Golden retriver", new WeightRange(28m, 40m), new WeightRange(24, 34)),
    ];

    public Breed? GetBreed(Guid id)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentException("Breed not valid");
        }

        var result = breeds.Find(breeds => breeds.Id == id);

        // returnere result hvis det findes, ellers returneres en exception
        return result ?? throw new ArgumentException("Breed was not found");
    }
}