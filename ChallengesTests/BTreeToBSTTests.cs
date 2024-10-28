using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
     public class BTreeToBSTTests
    {
        [Fact]
        public void ConvertToBST_ExampleTree_ConvertsCorrectly()
        {
            // Arrange: Set up the binary tree from the example
            BinaryTree Btree = new BinaryTree(40);
            Btree.Root.Left = new TNode(10);
            Btree.Root.Right = new TNode(50);
            Btree.Root.Left.Left = new TNode(5);
            Btree.Root.Left.Right = new TNode(30);
            Btree.Root.Right.Right = new TNode(60);
            Btree.Root.Left.Right.Left = new TNode(20);
            Btree.Root.Left.Right.Right = new TNode(35);

            // Act: Convert the tree to a BST
            Btree.ConvertToBST();

            // Assert: Check that the in-order traversal is sorted
            List<int> result = Btree.InOrderTraversal(Btree.Root);
            List<int> expected = new List<int> { 5, 10, 20, 30, 35, 40, 50, 60 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToBST_LeftSkewedTree_ConvertsCorrectly()
        {
            // Arrange: Set up a left-skewed binary tree
            BinaryTree Btree = new BinaryTree(10);
            Btree.Root.Left = new TNode(20);
            Btree.Root.Left.Left = new TNode(30);

            // Act: Convert the tree to a BST
            Btree.ConvertToBST();

            // Assert: Check that the in-order traversal is sorted
            List<int> result = Btree.InOrderTraversal(Btree.Root);
            List<int> expected = new List<int> { 10, 20, 30 }; // Same structure, sorted values
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToBST_RightSkewedTree_ConvertsCorrectly()
        {
            // Arrange: Set up a right-skewed binary tree
            BinaryTree Btree = new BinaryTree(30);
            Btree.Root.Right = new TNode(20);
            Btree.Root.Right.Right = new TNode(10);

            // Act: Convert the tree to a BST
            Btree.ConvertToBST();

            // Assert: Check that the in-order traversal is sorted
            List<int> result = Btree.InOrderTraversal(Btree.Root);
            List<int> expected = new List<int> { 10, 20, 30 }; // Same structure, sorted values
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertToBST_EmptyTree_NoChange()
        {
            // Arrange: Set up an empty tree
            BinaryTree Btree = new BinaryTree(0);

            // Act: Convert the tree to a BST
            Btree.ConvertToBST();

            // Assert: Verify that the tree is still empty
            List<int> result = Btree.InOrderTraversal(Btree.Root);
            Assert.Empty(result);
        }

        [Fact]
        public void ConvertToBST_SingleNodeTree_NoChange()
        {
            // Arrange: Set up a single-node tree
            BinaryTree Btree = new BinaryTree(42);

            // Act: Convert the tree to a BST
            Btree.ConvertToBST();

            // Assert: Verify the tree has the same single node
            List<int> result = Btree.InOrderTraversal(Btree.Root);
            List<int> expected = new List<int> { 42 };
            Assert.Equal(expected, result);
        }
    }
}
