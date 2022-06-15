using Algorithm_A_Day.RandomEasy;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class MajorityElementLc169ETests
    {
        private readonly MajorityElementLc169E _sut;

        public MajorityElementLc169ETests()
        {
            _sut = new MajorityElementLc169E();
        }

        [Theory]
        [InlineData(3, new int[] { 3, 2, 3 })]
        [InlineData(2, new int[] { 2, 2, 1, 1, 1, 2, 2 })]
        public void MajorityElement_ReturnsInt_WhenValidArrayPassed(int expected, int[] nums)
        {
            //Arrange

            //Act
            var actual = _sut.MajorityElement(nums);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
