using System;
using System.Collections.Generic;
using Tree.Classes;

namespace Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node node1 = new Node(1);

            BinaryTree tree = new BinaryTree(node1);

            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);

            List<Node> preResult = tree.PreOrder(tree.Root);
            Console.WriteLine("PreOrder Traversal: " + Print(preResult));
            tree.result.Clear();

            List<Node> inResult = tree.InOrder(tree.Root);
            Console.WriteLine("InOrder Traversal: " + Print(inResult));
            tree.result.Clear();

            List<Node> postResult = tree.PostOrder(tree.Root);
            Console.WriteLine("PostOrder Traversal: " + Print(inResult));
            tree.result.Clear();
        }

        /// <summary>
        /// Helper method to print node values
        /// </summary>
        /// <param name="ordered">result of a traversal</param>
        /// <returns>string of values</returns>
        public static string Print(List<Node> ordered)
        {
            string result = "";
            foreach (Node node in ordered)
            {
                result = result + node.Value + " ";
            }
            return result;
        }
    }
}
