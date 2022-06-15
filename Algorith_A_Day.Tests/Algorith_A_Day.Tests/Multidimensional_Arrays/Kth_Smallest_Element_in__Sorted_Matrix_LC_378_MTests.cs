using Algorithm_A_Day.Multidimensional_Arrays;
using System;
using Xunit;

namespace Algorith_A_Day.Tests.Multidimensional_Arrays
{
    public class KthSmallestElementInSortedMatrixLc378MTests
    {
        private readonly KthSmallestElementInSortedMatrixLc378M _sut;

        public KthSmallestElementInSortedMatrixLc378MTests()
        {
            _sut = new KthSmallestElementInSortedMatrixLc378M();
        }

        [Theory]
        [InlineData(13, 8)]
        public void KthSmallest_ReturnInt_WhenNoduplicates(int expected, int k)
        {
            //Arrange
            var matrix = new int[][] { new int[] { 1, 5, 9 }, new int[] { 10, 11, 13 }, new int[] { 12, 13, 15 } };
            //Act
            var actual =_sut.KthSmallest1(matrix, k);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, 2)]
        public void KthSmallest_ReturnInt_WhenWithDuplicates(int expected, int k)
        {
            //Arrange
            var matrix = new int[][] { new int[] { 1, 2}, new int[] { 1, 3} };
            //Act
            var actual =_sut.KthSmallest1(matrix, k);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 8)]
        public void KthSmallest_Return0_WhenMatrixIsNullOrEmpty(int expected, int k)
        {
            //Arrange
            var matrix = Array.Empty<int[]>();
            int[][] matrix2 = null;
            //Act
            // bad practice but for some reason can't pass matrix as a parameter here
            var actual = _sut.KthSmallest1(matrix, k);
            var actual2 = _sut.KthSmallest1(matrix2, k);
            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected, actual2);
        }
    }
}
