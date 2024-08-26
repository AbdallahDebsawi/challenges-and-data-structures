using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Trees
{
    public class BinaryTree
    {
        public TNode Root { get; set; }

        public BinaryTree(int rootValue)
        {
            Root = new TNode(rootValue);
        }

        public void Insert(int value)
        {
            Insert(Root, value);
        }

        private void Insert(TNode node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new TNode(value);
                }
                else
                {
                    Insert(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TNode(value);
                }
                else
                {
                    Insert(node.Right, value);
                }
            }
        }
        public List<int> LargestLevelValue()
        {
            List<int> largestValues = new List<int>();

            if (Root == null)
                return largestValues;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    if (currentNode.Value > maxAtLevel)
                    {
                        maxAtLevel = currentNode.Value;
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }
        // Mirror the binary tree
        public void MirrorTree(TNode node)
        {
            if (node == null) return;

            MirrorTree(node.Left);
            MirrorTree(node.Right);

            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        // Function to find the second maximum value in the binary tree
        public int? FindSecondMax()
        {
            if (Root == null)
                return null;

            int? max = null;
            int? secondMax = null;

            FindSecondMaxHelper(Root, ref max, ref secondMax);

            return secondMax;
        }
        public int SumOfLeafNodes()
        {
            return SumOfLeafNodes(Root);
        }

        private int SumOfLeafNodes(TNode node)
        {
            if (node == null)
                return 0;

            if (node.Left == null && node.Right == null)
                return node.Value;

            return SumOfLeafNodes(node.Left) + SumOfLeafNodes(node.Right);
        }
        private void FindSecondMaxHelper(TNode node, ref int? max, ref int? secondMax)
        {
            if (node == null)
                return;

            // In-order traversal: left, root, right
            FindSecondMaxHelper(node.Left, ref max, ref secondMax);

            if (max == null || node.Value > max)
            {
                secondMax = max;
                max = node.Value;
            }
            else if (node.Value < max && (secondMax == null || node.Value > secondMax))
            {
                secondMax = node.Value;
            }

            FindSecondMaxHelper(node.Right, ref max, ref secondMax);
        }

    // InOrder Traversal to return a list of node values
    public List<int> InOrderTraversal(TNode node)
        {
            List<int> result = new List<int>();
            InOrderTraversalHelper(node, result);
            return result;
        }

        private void InOrderTraversalHelper(TNode node, List<int> result)
        {
            if (node == null) return;

            InOrderTraversalHelper(node.Left, result);
            result.Add(node.Value);
            InOrderTraversalHelper(node.Right, result);
        }

        public void PreOrderTraversal(TNode node)
        {
            if (node == null) return;

            Console.Write(node.Value + "  ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(TNode node)
        {
            if (node == null) return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + "  ");
        }

        public void Print()
        {
            PrintTree(Root, "", true);
        }

        private void PrintTree(TNode node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "     ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|    ";
                }

                Console.WriteLine(node.Value);

                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }
        }
}