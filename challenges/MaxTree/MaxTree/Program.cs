using System;
using Tree.Classes;

namespace MaxTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(new Node(1));
            tree.Root.Left = new Node(5);
            tree.Root.Left.Left = new Node(20);
            tree.Root.Right = new Node(15);
            tree.Root.Right.Right = new Node(50);

            int result = FindMax(tree.Root);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Take a binary tree, traverse it, and return the highest value found in the tree.
        /// </summary>
        /// <param name="node">Root node of tree</param>
        /// <returns>Max Value</returns>
        public static int FindMax(Node node)
        {
            int max = node.Value;
            int leftMax = (node.Left != null) ? FindMax(node.Left) : Int32.MinValue;
            int rightMax = (node.Right != null) ? FindMax(node.Right) : Int32.MinValue;

            if (leftMax > max) max = leftMax;
            if (rightMax > max) max = rightMax;

            return max;
        }
    }
}
