//using challenges_and_data_structures.Data_Structures.Stack___Queue;
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
        // New method: Print the right view of the tree
        public void PrintRightView()
        {
            if (Root == null) return;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count; // Number of nodes at the current level

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();

                    // Print the rightmost node (the last node in this level)
                    if (i == levelSize - 1)
                    {
                        Console.Write(currentNode.Value + " ");
                    }

                    // Enqueue left and right children
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }

            Console.WriteLine();
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
        // Helper method to insert sorted values back into the tree
        private void ConvertToBSTInOrder(TNode node, Queue<int> sortedValues)
        {
            if (node == null) return;

            ConvertToBSTInOrder(node.Left, sortedValues);
            node.Value = sortedValues.Dequeue();
            ConvertToBSTInOrder(node.Right, sortedValues);
        }

        // Main method to convert binary tree to BST
        public void ConvertToBST()
        {
            // Step 1: Collect all values in in-order traversal using provided InOrder method
            List<int> values = InOrderTraversal(Root);

            // Step 2: Sort the values
            values.Sort();

            // Step 3: Convert sorted values list to a queue for easy access
            Queue<int> sortedValues = new Queue<int>(values);

            // Step 4: Traverse tree in-order and assign sorted values to nodes
            ConvertToBSTInOrder(Root, sortedValues);
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
        public int FindMaxLevelNodes()
        {
            if (Root == null) return -1; // Handle empty tree

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            int maxNodes = 0;
            int maxLevel = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count; // Number of nodes at the current level

                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                // Process nodes at the current level
                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                currentLevel++;
            }

            return maxLevel;
        }
        public int FindMinimumDepth()
        {
            if (Root == null)
            {
                return 0;
            }

            // Use BFS approach to find the minimum depth
            Queue<(TNode node, int level)> queue = new Queue<(TNode node, int level)>();
            queue.Enqueue((Root, 1)); // Start from the root node at level 1

            while (queue.Count > 0)
            {
                var (currentNode, currentLevel) = queue.Dequeue();

                // If we find a leaf node, return its level
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    return currentLevel;
                }

                // Add the children to the queue for the next level
                if (currentNode.Left != null)
                {
                    queue.Enqueue((currentNode.Left, currentLevel + 1));
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue((currentNode.Right, currentLevel + 1));
                }
            }

            return 0; // If we don't find any leaf, which should never happen
        }
    }

}