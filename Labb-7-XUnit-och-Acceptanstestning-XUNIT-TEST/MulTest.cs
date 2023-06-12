using Labb_7_XUnit_och_Acceptanstestning.Calculations;

namespace Labb_7_XUnit_och_Acceptanstestning_XUNIT_TEST
{
    public class MulTest
    {
        [Theory]
        [InlineData(25, 75)]
        [InlineData(10, 20)]
        [InlineData(-5, 5)]
        [InlineData(7, 8)]
        [InlineData(100, 2)]
        public void Mul_HandleMultiplication_Get_Correct_Answer(int x, int y)
        {
            // Arrange + Assert + Act
            Assert.Equal(x * y, Multiplication.HandleMultiplication(x, y));
        }
    }
}