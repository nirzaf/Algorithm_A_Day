using Algorithm_A_Day.DP;
using Xunit;

namespace Algorith_A_Day.Tests.DP
{
    public class ClimbingStairsLc70EDpTests
    {
        private readonly ClimbingStairsLc70EDp _sut;

        public ClimbingStairsLc70EDpTests()
        {
            _sut = new ClimbingStairsLc70EDp();
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(8, 5)]
        public void ClimbStairs_ShouldReturnsInt_WhenPositiveIntPassed(int expected, int n)
        {
            //Arrange
            //Act
            var actual = _sut.ClimbStairs(n);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, -1)]
        [InlineData(0, -3)]
        public void ClimbStairs_ShouldReturnsZero_WhenNegativeIntPassed(int expected, int n)
        {
            //Arrange
            //Act
            var actual = _sut.ClimbStairs(n);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
