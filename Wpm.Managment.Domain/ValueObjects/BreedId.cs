namespace Wpm.Managment.Domain.ValueObjects;

public record BreedId
{
   public IBreedService BreedService { get; set; }
   public Guid Value { get; set; }

   public BreedId(Guid value)
   {
       Value = value;
   }

   public BreedId(Guid value, IBreedService breedService)
    {
        BreedService = breedService;

        ValidateBreed(value);

        Value = value;
    }
    
    public static BreedId Create(Guid value)
    {
        return new BreedId(value);
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