using FluentAssertions;
using Calculator.Process;

namespace CalculatorTests
{
    public class UnitTest1
    {
        private readonly Adding adding = new Adding();

        [Fact]
        public void CanAddTest()
        {
            // Arrange
            int a = 10;
            int b = 20;
            string operation = "Add";

            int expected = 30;

            // Act
            var result = adding.Add(a, b);

            // Assert
            result.Should().Be(expected);
            
        }
    }
}