using Wpm.Managment.Domain;
using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;

namespace Wpm.Managment.Api.Infrastructure
{
    public class BreedService : IBreedService
    {

        public readonly List<Breed> breeds =
        [
            new Breed(Guid.Parse("e3ff6a5c-7bbb-464e-ae62-be450a4a380e"),  
                "Beagle", new WeightRange(10m, 20m), new WeightRange(11, 18)),

            new Breed(Guid.Parse("5bede4bf-fe4e-46ad-aa0a-c94d15dd1fe7"),
                "Golden retriver", new WeightRange(28m, 40m), new WeightRange(24, 34)),

        ];

        public Breed? GetBreed(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("BreedId not valid");
            }
            var result = breeds.Find(breeds => breeds.Id == id);
            return result ?? throw new ArgumentException("Breed was not found");
        }
    }
}
