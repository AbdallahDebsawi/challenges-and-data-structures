using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class SumOfLeafsTests
    {
        [Fact]
        public void SumOfLeafNodes_ShouldReturnCorrectSum_ForExampleTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(9);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(12);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(17);
            Btree.Root.Right.Right = new TNode(23);
            Btree.Root.Left.Left.Right = new TNode(4);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(51, leafSum);
        }

        [Fact]
        public void SumOfLeafNodes_ShouldReturnZero_ForEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(0);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(0, leafSum);
        }

        [Fact]
        public void SumOfLeafNodes_ShouldReturnRootValue_ForSingleRootNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(10);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(10, leafSum);
        }

        [Fact]
        public void SumOfLeafNodes_ShouldReturnCorrectSum_ForNegativeLeafValues()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(-10);
            Btree.Root.Left = new TNode(-20);
            Btree.Root.Right = new TNode(5);
            Btree.Root.Left.Left = new TNode(-30);
            Btree.Root.Left.Right = new TNode(-15);

            // Act
            int leafSum = Btree.SumOfLeafNodes();

            // Assert
            Assert.Equal(-60, leafSum);
        }

    }
}
