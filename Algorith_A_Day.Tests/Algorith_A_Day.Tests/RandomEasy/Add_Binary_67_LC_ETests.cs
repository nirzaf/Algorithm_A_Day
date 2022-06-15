using Algorithm_A_Day.RandomEasy;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class AddBinary67LcETests
    {
        private readonly AddBinary67LcE _sut;
        public AddBinary67LcETests()
        {
            _sut = new AddBinary67LcE();
        }


        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        public void AddBinary_ReturnsString_When2ProperStringsPassed(string a, string b, string expected)
        {
            //Arrange

            //Act
            var actual = _sut.AddBinary(a, b);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
