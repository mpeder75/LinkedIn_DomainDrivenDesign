using Wpm.Managment.Api.Infrastructure;
using Wpm.Managment.Domain;
using Wpm.Managment.Domain.Entities;

namespace Wpm.Managment.Api;

public class ManagmentRepository : IManagmentRepository
{

    private readonly ManagementDbContext ManagmentDbCotext;

    public ManagmentRepository(ManagementDbContext db )
    {
        ManagmentDbCotext = db;
    }

    public Pet? GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Pet> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Insert(Pet pet)
    {
        throw new NotImplementedException();
    }

    public void Update(Pet pet)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}