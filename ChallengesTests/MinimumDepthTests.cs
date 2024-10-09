using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
   public class MinimumDepthTests
    {
        [Fact]
        public void Test_TreeWithMultipleNodes()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);

            int result = Btree.FindMinimumDepth();

            Assert.Equal(2, result); // The shortest path is through node 3 (Depth: 2)
        }

        [Fact]
        public void Test_EmptyTree()
        {
            BinaryTree Btree = new BinaryTree(1);

            int result = Btree.FindMinimumDepth();

            Assert.Equal(0, result); // Empty tree should return 0
        }

        [Fact]
        public void Test_SingleNodeTree()
        {
            BinaryTree Btree = new BinaryTree(1);

            int result = Btree.FindMinimumDepth();

            Assert.Equal(1, result); // Single node tree should return 1
        }

        [Fact]
        public void Test_SkewedTree()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Right = new TNode(2);
            Btree.Root.Right.Right = new TNode(3);
            Btree.Root.Right.Right.Right = new TNode(4);

            int result = Btree.FindMinimumDepth();

            Assert.Equal(4, result); // Skewed tree should return the height, which is 4
        }
    }
}
