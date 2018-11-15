using Hashtables.Classes;
using System;
using System.Collections.Generic;
using Tree.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree a = new BinaryTree(new Node(150));
            BinaryTree b = new BinaryTree(new Node(42));

            a.Root.Left = new Node(100);
            a.Root.Right = new Node(250);

            b.Root.Left = new Node(100);
            b.Root.Right = new Node(600);

            List<string> result = Intersect(a, b);

            foreach (string dup in result)
                Console.WriteLine(dup);
        }

        /// <summary>
        /// Take two tree inputs and return a list of inputs only found in both trees
        /// </summary>
        /// <param name="a">Tree one</param>
        /// <param name="b">Tree two</param>
        /// <returns>A list of the intersected values</returns>
        public static List<string> Intersect(BinaryTree a, BinaryTree b)
        {
            Hashtable hs = new Hashtable();

            List<Node> aNodes = a.PreOrder(a.Root);
            List<Node> bNodes = b.PreOrder(b.Root);

            List<string> duplicates = new List<string>();

            foreach (Node node in aNodes)
            {
                hs.Add(node.Value.ToString(), "");
            }

            foreach (Node node in bNodes)
            {
                if (hs.Contains(node.Value.ToString()))
                    duplicates.Add(node.Value.ToString());
            }

            return duplicates;
        }
    }
}
