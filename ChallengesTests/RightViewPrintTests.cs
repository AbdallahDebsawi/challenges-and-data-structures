using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class RightViewPrintTests
    {
        [Fact]
        public void TestRightViewExampleTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(2);
            Btree.Insert(3);
            Btree.Insert(5);
            Btree.Insert(4);
            Btree.Insert(6);
            Btree.Root.Left.Left.Right = new TNode(7); // Manually inserting node 7

            // Act & Assert
            List<int> expectedRightView = new List<int> { 2, 5, 6, 7 };
            var actualRightView = CaptureRightView(Btree);
            Assert.Equal(expectedRightView, actualRightView);
        }

        [Fact]
        public void TestRightViewWithOnlyRightNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(1);
            Btree.Insert(2);
            Btree.Insert(3);
            Btree.Insert(4);

            // Act & Assert
            List<int> expectedRightView = new List<int> { 1, 2, 3, 4 };
            var actualRightView = CaptureRightView(Btree);
            Assert.Equal(expectedRightView, actualRightView);
        }

        // Helper method to capture right view values
        private List<int> CaptureRightView(BinaryTree tree)
        {
            List<int> rightView = new List<int>();
            if (tree.Root == null) return rightView;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                TNode rightmostNode = null;

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    rightmostNode = currentNode;

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                rightView.Add(rightmostNode.Value);
            }

            return rightView;
        }
    }
}
