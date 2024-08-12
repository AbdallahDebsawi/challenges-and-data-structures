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

        public void PreOrderTraversal(TNode node)
        {
            if (node == null) return;

            Console.Write(node.Value + "  ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void InOrderTraversal(TNode node)
        {
            if (node == null) return;

            InOrderTraversal(node.Left);
            Console.Write(node.Value + "  ");
            InOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(TNode node)
        {
            if (node == null) return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Value + "  ");
        }

        public void Print(TNode node, string indent = "", bool isLeft = true)
        {
            if (node == null)
            {
                Console.WriteLine($"{indent}*");
                return;
            }

            Console.WriteLine($"{indent}{(isLeft ? "├──" : "└──")}{node.Value}");
            indent += isLeft ? "│   " : "    ";
            Print(node.Left, indent, true);
            Print(node.Right, indent, false);
        }

    }
}