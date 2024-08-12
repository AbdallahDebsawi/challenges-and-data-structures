using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Trees
{
    public class BinarySearchTree : BinaryTree
    {
        public BinarySearchTree(int rootValue) : base(rootValue) { }

        public void Add(int value)
        {
            Insert(value);
        }

        public bool Contains(int value)
        {
            return Contains(Root, value);
        }

        private bool Contains(TNode node, int value)
        {
            if (node == null) return false;
            if (node.Value == value) return true;
            if (value < node.Value) return Contains(node.Left, value);
            else return Contains(node.Right, value);
        }

        public void Remove(int value)
        {
            Root = Remove(Root, value);
        }

        private TNode Remove(TNode node, int value)
        {
            if (node == null) return null;

            if (value < node.Value)
            {
                node.Left = Remove(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Remove(node.Right, value);
            }
            else
            {
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left;

                TNode minNode = FindMin(node.Right);
                node.Value = minNode.Value;
                node.Right = Remove(node.Right, minNode.Value);
            }

            return node;
        }

        private TNode FindMin(TNode node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }
    }
}
