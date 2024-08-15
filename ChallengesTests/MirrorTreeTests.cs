using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class MirrorTreeTests
    {
        [Fact]
        public void MirrorTree_ShouldMirrorCorrectly()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(4);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(12);
            Btree.Root.Left.Right = new TNode(9);

            // Act
            Btree.MirrorTree(Btree.Root);
            List<int> mirroredInorder = Btree.InOrderTraversal(Btree.Root);

            // Assert
            Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
        }

        [Fact]
        public void MirrorTree_ShouldHandleSingleNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(4);

            // Act
            Btree.MirrorTree(Btree.Root);
            List<int> inorder = Btree.InOrderTraversal(Btree.Root);

            // Assert
            Assert.Equal(new List<int> { 4 }, inorder);
        }

        [Fact]
        public void MirrorTree_ShouldHandleEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(0);
            Btree.Root = null;  // Making the tree empty

            // Act
            Btree.MirrorTree(Btree.Root);
            List<int> inorder = Btree.InOrderTraversal(Btree.Root);

            // Assert
            Assert.Empty(inorder);
        }
    }
}

