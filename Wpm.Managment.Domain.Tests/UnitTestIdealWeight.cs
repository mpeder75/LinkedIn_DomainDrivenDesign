using Wpm.Managment.Domain.Entities;
using Wpm.Managment.Domain.ValueObjects;
using Xunit;

namespace Wpm.Managment.Domain.Tests;

public class UnitTestIdealWeight
{
    [Fact]
    public void WeighRange_should_be_equal()
    {
        // Arrange
        var w1 = new WeightRange(10.5m, 20.5m);
        var w2 = new WeightRange(10.5m, 20.5m);

        // Assert
        Assert.True(w1 == w2);
    }
}
