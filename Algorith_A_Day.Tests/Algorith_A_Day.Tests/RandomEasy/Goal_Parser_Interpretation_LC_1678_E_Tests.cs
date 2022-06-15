using Algorithm_A_Day.RandomEasy;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class GoalParserInterpretationLc1678ETests
    {
        private GoalParserInterpretationLc1678E _sut;
        public GoalParserInterpretationLc1678ETests()
        {
            _sut = new GoalParserInterpretationLc1678E();
        }


        [Theory]
        [InlineData("Goal", "G()(al)")]
        [InlineData("Gooooal", "G()()()()(al)")]
        [InlineData("alGalooG", "(al)G(al)()()G")]
        public void Interpret_ReturnsValidString_WhenValidStringPassed(string expected, string command)
        {
            //Arrange

            //Act
            var actual = _sut.Interpret(command);
            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("", null)]
        [InlineData("", "")]
        public void Interpret_ReturnsEmptyString_WhenEmptyOrNullPassed(string expected, string command)
        {
            //Arrange

            //Act
            var actual = _sut.Interpret(command);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
