using Labb_7_XUnit_och_Acceptanstestning.Calculations;
using Labb_7_XUnit_och_Acceptanstestning.Models;
using Labb_7_XUnit_och_Acceptanstestning.UI;
using Moq;
using System.Runtime.CompilerServices;

namespace Labb_7_XUnit_och_Acceptanstestning_XUNIT_TEST
{
    public class AddTest
    {
        [Theory]
        [InlineData(25, 75, 100)]
        [InlineData(50, 50, 100)]
        [InlineData(10, 20, 30)]
        [InlineData(-40, 80, 40)]
        [InlineData(25.5, 75, 100.5)]
        public void Add_HandleAddition_Get_Correct_Answer(decimal x, decimal y, decimal expected)
        {
            // Arrange + Assert + Act
            Assert.Equal(expected, Addition.HandleAddition(x, y)); 
        }
    }
}