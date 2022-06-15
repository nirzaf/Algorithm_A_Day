using Algorithm_A_Day.RandomEasy;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class NumberOfStepsToZeroLc1342ETests
    {
        private readonly NumberOfStepsToZeroLc1342E _sut;
        public NumberOfStepsToZeroLc1342ETests()
        {
            _sut = new NumberOfStepsToZeroLc1342E();
        }

        [Theory]
        [InlineData(6, 14)]
        [InlineData(4, 8)]
        public void NumbersOfSteps_ReturnsInt_WhenNonNegativeIntPassed(int expected, int num)
        {
            //Arrange

            //Act
            var actual = _sut.NumberOfSteps(num);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, -2)]
        public void NumbersOfSteps_ReturnsZero_WhenNegativeOrZeroPassed(int expected, int num)
        {
            //Arrange

            //Act
            var actual = _sut.NumberOfSteps(num);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
