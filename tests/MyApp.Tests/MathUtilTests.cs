using Xunit;
using MyApp;

namespace MyApp.Tests
{
    public class MathUtilTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            int a = 2, b = 3;

            // Act
            int result = MathUtil.Add(a, b);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            // Arrange
            int a = 4, b = 5;

            // Act
            int result = MathUtil.Multiply(a, b);

            // Assert
            Assert.Equal(20, result);
        }
    }
}