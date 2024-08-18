using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class SecondMaxValueTests
    {
        [Fact]
        public void FindSecondMax_ShouldReturnSecondMaxValue()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(10);
            Btree.Root.Left = new TNode(5);
            Btree.Root.Right = new TNode(20);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(15);
            Btree.Root.Right.Right = new TNode(25);

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Equal(20, secondMax);
        }

        [Fact]
        public void FindSecondMax_ShouldReturnNull_WhenTreeHasLessThanTwoUniqueValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(10);
            Btree.Root.Left = new TNode(10);
            Btree.Root.Right = new TNode(10);

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Null(secondMax);
        }

        [Fact]
        public void FindSecondMax_ShouldReturnSecondMaxValue_WithNegativeValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(-10);
            Btree.Root.Left = new TNode(-20);
            Btree.Root.Right = new TNode(-5);
            Btree.Root.Left.Left = new TNode(-30);
            Btree.Root.Left.Right = new TNode(-15);

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Equal(-10, secondMax);
        }

        [Fact]
        public void FindSecondMax_ShouldReturnNull_ForSingleNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(10);

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Null(secondMax);
        }

        [Fact]
        public void FindSecondMax_ShouldReturnNull_ForEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(0);  // No nodes actually added, so effectively empty

            Btree.Root = null; // Explicitly set to null to simulate empty tree

            // Act
            int? secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Null(secondMax);
        }
    }
}

