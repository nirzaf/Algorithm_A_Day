﻿using Algorithm_A_Day.RandomEasy;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Algorith_A_Day.Tests.RandomEasy
{
    public class RichestCustomerWealthLc1672ETests
    {
        private readonly RichestCustomerWealthLc1672E _sut;
        public RichestCustomerWealthLc1672ETests()
        {
            _sut = new RichestCustomerWealthLc1672E();
        }



        [Theory]
        [ClassData(typeof(RichestTestData))]
        public void MaximumWealth_MaxWealth_WhenValidMatrixPassed(int expected, int[][] accounts) 
        { 
            //Arrange

            //Act
            var actual = _sut.MaximumWealth(accounts);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(RichestFaultyData))]
        public void MaximumWealth_ReturnsZero_WhenNegativeOrZeroPassed(int expected, int[][] accounts)
        {
            //Arrange

            //Act
            var actual = _sut.MaximumWealth(accounts);
            //Assert
            Assert.Equal(expected, actual);
        }




        public class RichestTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 10, new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } } };
                yield return new object[] { 17, new int[][] { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } } };
                yield return new object[] { 6, new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } } };              
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
        
        public class RichestFaultyData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { 0, new int[][] {  } };
                yield return new object[] { 0, null };
                
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
