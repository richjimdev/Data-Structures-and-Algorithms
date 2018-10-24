# First-in, First-out Animal Shelter

## Challenge
Create an Animal Shelter Queue that can take in Dogs and Cats and has the ability to Dequeue a requested animal, returning that type of animal at the frontmost of the queue.

## Approach & Efficiency
The bigO efficiency is O(n) for dequeue. We needed to dequeue whatever is at the front until we found the specific type we were looking for. This ensured we got the first in of that type and we were able to repeat the pattern to return the queue to normal state after dequeue.

## Solution
![](/assets/animal-shelter.jpg)
