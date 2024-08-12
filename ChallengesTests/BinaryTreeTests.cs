using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class BinaryTreeTests
    {
        [Fact]
        public void PreOrderTraversal_ShouldReturnCorrectOrder()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree(10);
            binaryTree.Insert(5);
            binaryTree.Insert(15);
            binaryTree.Insert(7);

            // Act
            var result = new List<int>();
            CapturePreOrderTraversal(binaryTree.Root, result);

            // Assert
            Assert.Equal(new List<int> { 10, 5, 7, 15 }, result);
        }

        [Fact]
        public void InOrderTraversal_ShouldReturnCorrectOrder()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree(10);
            binaryTree.Insert(5);
            binaryTree.Insert(15);
            binaryTree.Insert(7);

            // Act
            var result = new List<int>();
            CaptureInOrderTraversal(binaryTree.Root, result);

            // Assert
            Assert.Equal(new List<int> { 5, 7, 10, 15 }, result);
        }

        [Fact]
        public void PostOrderTraversal_ShouldReturnCorrectOrder()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree(10);
            binaryTree.Insert(5);
            binaryTree.Insert(15);
            binaryTree.Insert(7);

            // Act
            var result = new List<int>();
            CapturePostOrderTraversal(binaryTree.Root, result);

            // Assert
            Assert.Equal(new List<int> { 7, 5, 15, 10 }, result);
        }

        private void CapturePreOrderTraversal(TNode node, List<int> result)
        {
            if (node == null) return;
            result.Add(node.Value);
            CapturePreOrderTraversal(node.Left, result);
            CapturePreOrderTraversal(node.Right, result);
        }

        private void CaptureInOrderTraversal(TNode node, List<int> result)
        {
            if (node == null) return;
            CaptureInOrderTraversal(node.Left, result);
            result.Add(node.Value);
            CaptureInOrderTraversal(node.Right, result);
        }

        private void CapturePostOrderTraversal(TNode node, List<int> result)
        {
            if (node == null) return;
            CapturePostOrderTraversal(node.Left, result);
            CapturePostOrderTraversal(node.Right, result);
            result.Add(node.Value);
        }
    }
}
