using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;
using Xunit;

namespace Wpm.Managment.Domain.Tests;

public class UnitTestBreed
{
    [Fact]
    public void BreedId_Should_Be_Valid()
    {
        // Arrange
        var breedService = new FakeBreedService();
        var id = breedService.breeds[0].Id;  // opsætter at det er en beagle

        // Act
        var breedId = new BreedId(id, breedService);

        // Assert
        Assert.NotNull(breedId);
    }

    public void BreedId_Should_Not_Be_Valid()
    {
        // Arrange
        var breedService = new FakeBreedService();
        var id = Guid.NewGuid();

        // Assert
        Assert.Throws<ArgumentException>(() =>
        {
            var breedId = new BreedId(id, breedService);

        });
    }
}
