# Intersection of binary trees

## Challenge
Take in two binary trees and return a list of values that are found on both trees

## Approach & Efficiency
I traversed each tree and saved all nodes into lists. 
I then traversed the first tree list and added the values to a hashtable. 
Finally I traversed list B and checked if each value existed in the hashtable and added it to a result list if it did.
Big O: Time = N, Space = N

## Solution
![](/assets/tree-intersection.jpg)
