using System;
using System.Collections.Generic;
using Tree.Classes;

namespace BreadthFirstSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree arbol = new BinaryTree(new Node(1));
            arbol.Root.Left = new Node(2);
            arbol.Root.Right = new Node(3);
            arbol.Root.Left.Left = new Node(4);
            arbol.Root.Left.Right = new Node(5);
            arbol.Root.Right.Left = new Node(6);
            arbol.Root.Right.Right = new Node(7);

            BFS(arbol);
        }

        public static void BFS(BinaryTree tree)
        {
            Queue<Node> q = new Queue<Node>();

            if (tree.Root != null)
                q.Enqueue(tree.Root);

            else return;

            while (q.Count > 0)
            {
                Node current = q.Peek();
                Console.Write(current.Value);

                if (current.Left != null)
                    q.Enqueue(current.Left);

                if (current.Right != null)
                    q.Enqueue(current.Right);

                q.Dequeue();
            }
        }
    }
}
