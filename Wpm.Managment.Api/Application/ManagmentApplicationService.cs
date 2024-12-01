using Wpm.Managment.Api.Application.Command;
using Wpm.Managment.Domain;
using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;

namespace Wpm.Managment.Api.Application;

public class ManagmentApplicationService
{
    private readonly IBreedService _breedService;

    public ManagmentApplicationService(IBreedService breedService)
    {
        _breedService = breedService;
    }

    public async Task Handle(CreatePetCommand command)
    {
        var breedId = new BreedId(command.BreedId, _breedService);

        var newPet = new Pet(command.Id,
            command.Name,
            command.Age,
            command.Color,
            command.SexOfPet,
            breedId);
    }
}
