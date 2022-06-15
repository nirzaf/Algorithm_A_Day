﻿using Algorithm_A_Day.BinaryTree;
using Algorithm_A_Day.NodesModels;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Algorith_A_Day.Tests.BinaryTree
{
    public class SameTreeLc100ETests
    {
        private readonly SameTreeLc100E _sut;

        public SameTreeLc100ETests()
        {
            _sut = new SameTreeLc100E();
        }

        [Theory]
        [ClassData(typeof(SameTreeTestData))]
        public void IsSameTree_ReturnsBool_When2TreeNodesPassed(bool expected, TreeNode t1, TreeNode t2)
        {
            //Arrange

            //Act
            var actual = _sut.IsSameTree(t1, t2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class SameTreeTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { true, new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null)),
                                                    new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null)) };
            yield return new object[] { false, new TreeNode(1, new TreeNode(2, null, null), new TreeNode(1, null, null)),
                                                    new TreeNode(1, new TreeNode(1, null, null), new TreeNode(2, null, null)) };
            yield return new object[] { false, new TreeNode(1, new TreeNode(2, null, null)),
                                                    new TreeNode(1, null, new TreeNode(2, null, null)) };
            yield return new object[] { false, null, new TreeNode(1, null, new TreeNode(2, null, null)) };
            yield return new object[] { false, new TreeNode(1, null, new TreeNode(2, null, null)), null };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
