using System.Net.Http.Headers;
using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;
using Xunit;

namespace Wpm.Managment.Domain.Tests;

public class UnitTestPet
{
    [Fact]
    public void Pet_should_be_equal()
    { 
        // Arrange
        var id = Guid.NewGuid();
        var breedService = new FakeBreedService();
        var breedId = new BreedId(breedService.breeds[0].Id, breedService);
        var pet1 = new Pet(id, "Gianni", 13, "Black" , SexOfPet.Male, breedId );
        var pet2 = new Pet(id, "Nina", 10, "Black" , SexOfPet.Female, breedId);
        
        // Act

        // Assert
        Assert.True(pet1.Equals(pet2));
    }

    [Fact]
    public void Pet_should_be_equal_using_operators()
    {
        // Arrange
        var id = Guid.NewGuid();
        var breedService = new FakeBreedService();
        var breedId = new BreedId(breedService.breeds[0].Id, breedService);
        var pet1 = new Pet(id, "Gianni", 13, "Black" , SexOfPet.Male, breedId );
        var pet2 = new Pet(id, "Nina", 10, "Black" , SexOfPet.Female, breedId );
        
        // Act

        // Assert
        Assert.True(pet1 == pet2);
    }

    [Fact]
    public void Pet_should_not_be_equal_using_operators()
    {
        // Arrange
        var id1 = Guid.NewGuid();
        var id2 = Guid.NewGuid();
        var breedService = new FakeBreedService();
        var breedId = new BreedId(breedService.breeds[0].Id, breedService);
        var pet1 = new Pet(id1, "Gianni", 13, "Black" , SexOfPet.Male, breedId );
        var pet2 = new Pet(id2, "Nina", 10, "Black" , SexOfPet.Female, breedId );
        
        // Assert
        Assert.True(pet1 != pet2);
    }
}
