using Labb_7_XUnit_och_Acceptanstestning.Calculations;

namespace Labb_7_XUnit_och_Acceptanstestning_XUNIT_TEST
{
    public class DivTest
    {
        [Theory]
        [InlineData(100, 10, 10)]
        [InlineData(50, 2, 25)]
        [InlineData(30, 5, 6)]
        [InlineData(12, 3, 4)]
        [InlineData(0, 1, 0)]
        public void Div_HandleDivision_Get_Correct_Answer(decimal x, decimal y, decimal expected)
        {
            // Arrange + Assert + Act
            Assert.Equal(expected, Division.HandleDivision(x, y));
        }
    }
}