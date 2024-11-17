namespace Wpm.Managment.Domain.ValueObjects;

public record BreedId
{
    public Guid Value { get; set; }
    public IBreedService BreedService { get; set; }

    public BreedId(Guid value, IBreedService breedService)
    {
        BreedService = breedService;

        ValidateBreed(value);

        Value = value;
    }

    // Valider om Breed er valid
    private void ValidateBreed(Guid value)
    {
        if (BreedService.GetBreed(value) == null)
        {
            throw new ArgumentException("Breed does not exist");
        }
    }
}