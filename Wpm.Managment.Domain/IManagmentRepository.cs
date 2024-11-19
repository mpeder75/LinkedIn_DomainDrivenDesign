using Wpm.Managment.Domain.Entities;

namespace Wpm.Managment.Domain;

public interface IManagmentRepository
{
    Pet? GetById(Guid id);      // Get specific Pet by id

    IEnumerable<Pet> GetAll();  // Get all Pets

    void Insert(Pet pet);       // Insert/Create new Pet

    void Update(Pet pet);       // Update existing Pet

    void Delete(Guid id);       // Delete Pet by id
}

