using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        /// <summary>
        /// Instantiating a tree requires a node to place at root.
        /// </summary>
        /// <param name="root"></param>
        public BinaryTree(Node root)
        {
            Root = root;
        }
        
        public List<Node> result = new List<Node>();

        /// <summary>
        /// Traversing the tree in a pre-order fashion
        /// </summary>
        /// <param name="root">Root of tree</param>
        /// <returns>List of nodes in tree</returns>
        public List<Node> PreOrder(Node root)
        {
            result.Add(root);
            if (root.Left != null)
                PreOrder(root.Left);
            if (root.Right != null)
                PreOrder(root.Right);

            return result;
        }

        /// <summary>
        /// Traversing the tree in an in-order fashion
        /// </summary>
        /// <param name="root">Root of tree</param>
        /// <returns>List of nodes in tree</returns>
        public List<Node> InOrder(Node root)
        {
            if (root.Left != null)
                PreOrder(root.Left);
            result.Add(root);
            if (root.Right != null)
                PreOrder(root.Right);

            return result;
        }

        /// <summary>
        /// Traversing the tree in a post-order fashion
        /// </summary>
        /// <param name="root">Root of tree</param>
        /// <returns>List of nodes in tree</returns>
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
