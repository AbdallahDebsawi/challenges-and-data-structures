using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void Test_MaxLevelNodes_CorrectLevel()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);
            Btree.Root.Left.Left.Left = new TNode(7);

            int maxLevel = Btree.FindMaxLevelNodes();
            Assert.Equal(2, maxLevel);
        }

        [Fact]
        public void Test_SingleNode_Tree()
        {
            BinaryTree Btree = new BinaryTree(1);
            int maxLevel = Btree.FindMaxLevelNodes();
            Assert.Equal(0, maxLevel);
        }

        [Fact]
        public void Test_Empty_Tree()
        {
            BinaryTree Btree = new BinaryTree(0);
            Btree.Root = null;  // Tree is empty
            int maxLevel = Btree.FindMaxLevelNodes();
            Assert.Equal(-1, maxLevel);
        }

        [Fact]
        public void Test_MultipleMaxLevels()
        {
            BinaryTree Btree = new BinaryTree(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Left = new TNode(6);
            Btree.Root.Right.Right = new TNode(7);

            int maxLevel = Btree.FindMaxLevelNodes(); // Multiple levels have max nodes, should return the smallest level
            Assert.Equal(1, maxLevel);
        }
    }
}
