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
             
        }

        public static List<string> Intersect(BinaryTree a, BinaryTree b)
        {
            Hashtable hs = new Hashtable();

            List<Node> aNodes = a.PreOrder(a.Root);
            List<Node> bNodes = a.PreOrder(a.Root);

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
