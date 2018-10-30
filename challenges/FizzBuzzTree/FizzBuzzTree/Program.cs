using System;
using Tree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree myTree = new BinaryTree(new Node(3));
            myTree.Root.Left = new Node(7);
            myTree.Root.Right = new Node(5);
            myTree.Root.Left.Left = new Node(5);
            myTree.Root.Left.Right = new Node(15);
            myTree.Root.Right.Left = new Node(2);
            myTree.Root.Right.Right = new Node(15);

            FizzBuzz(myTree.Root);
        }

        /// <summary>
        /// Take a tree, traverse the nodes, and output fizz/buzz/fizzbuzz depending on node's vaue
        /// </summary>
        /// <param name="node">Root node of tree</param>
        public static void FizzBuzz(Node node)
        {
            int x = node.Value;

            if (x % 15 == 0) Console.WriteLine("FizzBuzz!");
            else if (x % 5 == 0) Console.WriteLine("Buzz!");
            else if (x % 3 == 0) Console.WriteLine("Fizz");
            else Console.WriteLine(x);

            if (node.Left != null) FizzBuzz(node.Left);
            if (node.Right != null) FizzBuzz(node.Right);
        }
    }
}
