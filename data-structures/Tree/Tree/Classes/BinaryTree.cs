using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }


        public List<Node> result = new List<Node>();

        public List<Node> PreOrder(Node root)
        {
            result.Add(root);
            if (root.Left != null)
                PreOrder(root.Left);
            if (root.Right != null)
                PreOrder(root.Right);

            return result;
        }

        public List<Node> InOrder(Node root)
        {
            if (root.Left != null)
                PreOrder(root.Left);
            result.Add(root);
            if (root.Right != null)
                PreOrder(root.Right);

            return result;
        }

        public List<Node> PostOrder(Node root)
        {
            if (root.Left != null)
                PreOrder(root.Left);
            if (root.Right != null)
                PreOrder(root.Right);
            result.Add(root);

            return result;
        }
    }
}
