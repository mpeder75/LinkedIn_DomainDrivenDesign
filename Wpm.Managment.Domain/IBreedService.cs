using Wpm.Managment.Domain.Entities;

namespace Wpm.Managment.Domain;

public interface IBreedService
{
    Breed? GetBreed(Guid id);
}