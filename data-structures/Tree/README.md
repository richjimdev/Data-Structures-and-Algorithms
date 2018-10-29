# Trees

## Challenge
Create a binary tree and a binary search tree, along with traversal methods and search methods.

## Approach & Efficiency
Binary trees can contain 0-2 children, Left and Right. Each traversal method returns the values of the tree.
BIG-O Efficiency of Traversals:
Time: O(n)
Space: O(h), h = height of tree (or call stack, since it is a recursive method)

Binary Search Trees are sorted.
BIG-O efficiency of Search:
Time: O(logN)
Space: O(h)

## API
BINARY TREE:
Root: Sets root of the tree.
PreOrder: Traverse tree using an order of Root-Left-Right
InOrder: Traverse tree using an order of Left-Root-Right
PostOrder: Traverse tree using an order of Left-Right-Root

BINARY SEARCH TREE:
Add: Adds a node to the left or right of tree depending if value is smaller or greater than root (including subtrees)
Search: Finds the value in the tree and returns the node