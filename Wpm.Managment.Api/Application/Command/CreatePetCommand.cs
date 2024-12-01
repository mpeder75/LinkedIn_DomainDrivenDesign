using Wpm.Managment.Domain.Entities;

namespace Wpm.Managment.Api.Application.Command;

// Man kan bruge records i stedet for class, da de er imutable
public record CreatePetCommand(
    Guid Id,
    string Name,
    int Age,
    string Color,
    SexOfPet SexOfPet,
    Guid BreedId)
{
}
