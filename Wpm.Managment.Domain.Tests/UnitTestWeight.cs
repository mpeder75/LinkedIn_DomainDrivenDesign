using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;
using Wpm.SharedKernel;
using Xunit;

namespace Wpm.Managment.Domain.Tests;

public class UnitTestWeight
{
    [Fact]
    public void Weight_should_not_be_equal()
    {
        // Arrange
        var w1 = new Weight(20.5m);
        var w2 = new Weight(18.5m);

        // Assert
        Assert.True(w1 != w2);
    }

    [Fact]
    public void WeightClass_should_be_ideal()
    {
        // Arrange
        var breedService = new FakeBreedService();
        var breedId = new BreedId(breedService.breeds[0].Id, breedService);
        var pet = new Pet(Guid.NewGuid(), "Gianni", 13, "Black", SexOfPet.Male, breedId);

        // Act
        pet.SetWeight(10, breedService);

        // Assert
        Assert.True(pet.WeightClass == WeightClass.Ideal);
    }
}
