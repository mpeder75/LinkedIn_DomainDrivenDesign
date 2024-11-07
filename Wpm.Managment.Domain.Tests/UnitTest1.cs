using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;
using Xunit;

namespace Wpm.Managment.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void Pet_should_be_equal()
    { 
        // Arrange
        var id = Guid.NewGuid();
        var pet1 = new Pet(id, new Name("Buddy"), new Age(13));
        var pet2 = new Pet(id, new Name("Nina"), new Age(13));


        // Act

        // Assert
        Assert.True(pet1.Equals(pet2));
    }

    [Fact]
    public void Pet_should_be_equal_using_operators()
    {
        // Arrange
        var id = Guid.NewGuid();
        var pet1 = new Pet(id, new Name("Buddy"), new Age(13));
        var pet2 = new Pet(id, new Name("Nina"), new Age(13));


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
        var pet1 = new Pet(id1, new Name("Buddy"), new Age(13));
        var pet2 = new Pet(id2, new Name("Buddy"), new Age(13));

        // Assert
        Assert.True(pet1 != pet2);
    }
}
