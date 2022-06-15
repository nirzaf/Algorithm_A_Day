using Algorithm_A_Day.RandomEasy;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{

    //Arrange

    //Act

    //Assert
    public class HowNumberLc1365ETests
    {
        private readonly HowNumberLc1365E _sut;
        public HowNumberLc1365ETests()
        {
            _sut = new HowNumberLc1365E();
        }


        [Theory]
        [InlineData(new int[] { 4, 0, 1, 1, 3 }, new int[] { 8, 1, 2, 2, 3 })]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 7, 7, 7, 7 })]
        public void SmallerNumbersThanCurrent_ReturnsArray_WhenValidArrIsPassed(int[] expected, int[] nums)
        {
            //Arrange

            //Act
            var result = _sut.SmallerNumbersThanCurrent(nums);
            //Assert
            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(new int[] {  }, new int[] {  })]
        [InlineData(new int[] {  }, null)]
        public void SmallerNumbersThanCurrent_ReturnsEmptyArray_WhenInEmptyArrOrNullIsPassed(int[] expected, int[] nums)
        {
            //Arrange

            //Act
            var result = _sut.SmallerNumbersThanCurrent(nums);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
