using Labb_7_XUnit_och_Acceptanstestning.Calculations;

namespace Labb_7_XUnit_och_Acceptanstestning_XUNIT_TEST
{
    public class SubTest
    {
        [Theory]
        [InlineData(25, 75)]
        [InlineData(10, 20)]
        [InlineData(100, 50)]
        [InlineData(0, 0)]
        [InlineData(-5, 5)]
        public void Sub_HandleSubtraction_Get_Correct_Answer(int x, int y)
        {
            // Arrange + Assert + Act
            Assert.Equal(x - y, Subtraction.HandleSubtraction(x, y));
        }
    }
}