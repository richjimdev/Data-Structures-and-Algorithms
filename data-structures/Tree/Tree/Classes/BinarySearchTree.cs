using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        public void Add(Node node, Node root)
        {
            if (node.Value == root.Value)
                throw new Exception("Value already in tree");

            if (node.Value < root.Value)
            {
                if (root.Left == null)
                {
                    root.Left = node;
                }
                else
                {
                    Add(node, root.Left);
                }
            }
            else if (node.Value > root.Value)
            {
                if (root.Right == null)
                {
                    root.Right = node;
                }
                else
                {
                    Add(node, root.Right);
                }
            }
        }

        public Node Search(Node node, Node root)
        {
            if (node.Value == root.Value)
                return root;

            else if (node.Value < root.Value)
            {
                if (root.Left == null)
                {
                    return null;
                }
                else
                {
                    return Search(node, root.Left);
                }
            }
            else if (node.Value > root.Value)
            {
                if (root.Right == null)
                {
                    return null;
                }
                else
                {
                    return Search(node, root.Right);
                }
            }
            return null;
        }
    }
}
