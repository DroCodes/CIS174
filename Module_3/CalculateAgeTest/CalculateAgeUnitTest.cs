using FirstResponsiveWebAppDaigh.Models;
using Xunit;

namespace CalculateAgeTest
{
    public class CalculateAgeUnitTest
    {
        [Fact]
        public void CalculateValidAge()
        {
            // Arrange
            int? actual, expected = 31;
            // Act
            var model = new CalculateAgeModel();
            model.BirthYear = 1991;
            actual = model.AgeThisYear();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}