namespace Wpm.Managment.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void Pet_should_be_equal()
    {
        // Arrange
        var id = Guid.NewGuid();
        var pet1 = new Pet { Id = id};
        var pet2 = new Pet { Id = id};

        // Act

        // Assert
        Assert.True(pet1.Equals(pet2));
    }

    [Fact]
    public void Pet_should_be_equal_using_operators()
    {
        // Arrange
        var id = Guid.NewGuid();
        var pet1 = new Pet { Id = id};
        var pet2 = new Pet { Id = id};

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
      
        // Act
        var pet1 = new Pet { Id = id1};
        var pet2 = new Pet { Id = id2};

        // Assert
        Assert.True(pet1 != pet2);
    }


}
