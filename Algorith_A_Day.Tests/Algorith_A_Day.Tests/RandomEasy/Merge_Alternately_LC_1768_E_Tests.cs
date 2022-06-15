using Algorithm_A_Day.RandomEasy;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class MergeAlternatelyLc1768ETests
    {
        private MergeAlternatelyLc1768E _sut;
        public MergeAlternatelyLc1768ETests()
        {
            _sut = new MergeAlternatelyLc1768E();
        }

        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("abcd", "pq", "apbqcd")]
        [InlineData("ab", "pqrs", "apbqrs")]
        [InlineData("", "xxx", "xxx")]
        [InlineData("xxx", "", "xxx")]

        public void MergeAlternately_Returns_WhenValidDataPassed(string word1, string word2, string expected)
        {
            //Arrange

            //Act
            var actual = _sut.MergeAlternately(word1, word2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
