using Labb_7_XUnit_och_Acceptanstestning;
using Labb_7_XUnit_och_Acceptanstestning.UI;
using Moq;

namespace Labb_7_XUnit_och_Acceptanstestning_XUNIT_TEST
{
    public class InputTest
    {
        [Fact]
        public void GetDecimalInput_ValidInput_ReturnsDecimal()
        {
            // Arrange
            string prompt = "Enter a decimal value: ";
            string input = "7";
            decimal expected = 7;

            // Mock Console.ReadLine()
            var consoleMock = new Mock<TextReader>();
            consoleMock.Setup(c => c.ReadLine())
                .Returns(input);

            // Act
            decimal actual = Inputs.GetDecimalInput(prompt, consoleMock.Object);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDecimalInput_InvalidInput_RetriesUntilValidInput()
        {
            // Arrange
            string prompt = "Enter a decimal value: ";
            string invalidInput = "abc";
            string validInput = "5,8";
            decimal expected = 5.8M;

            // Mock Console.ReadLine()
            var consoleMock = new Mock<TextReader>();
            consoleMock.SetupSequence(c => c.ReadLine())
                .Returns(invalidInput)
                .Returns(validInput);

            // Act
            decimal actual = Inputs.GetDecimalInput(prompt, consoleMock.Object);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
