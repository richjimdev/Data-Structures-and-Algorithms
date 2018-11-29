# Graphs

## Challenge
A Graph is a non-linear data structure consisting of nodes and edges. The nodes are sometimes also referred to as vertices and the edges are lines or arcs that connect any two nodes in the graph.

## Approach & Efficiency
I used a List to hold all my nodes, and my node class holds it's respective edges using Tuples.
BigO
Add: T: 1, Space: 1
Add Edge: T: N, Space: 1
Neighbors: T: N, Space: N
Find: T: N, Space: 1

## API
Add: Adds a new node to the graph with no edges
Find: Finds a node in graph
AddEdge: Adds an edge between two existing nodes in graph
Append: Adds a new node and edge to a parent node in graph
Neighbors: Returns all nodes that are linked to the input node
GetNodes: Returns all nodes in graph
Count: Returns number of nodes in graph
