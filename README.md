# Algorithms Code Examples
This is to document my progress in Algorithms.


## Notation Examples
Within NotationExamples.cs there are examples of O(1), O(n) and O(n^2) Big O notation. I did my best to explain how they fit that notation even if the solutions are intentionally terrible for examples' sake.

## Fisher-Yates Shuffle Example
In the FisherYatesShuffle subfolder you'll find a code example for a pretty ordinary Fisher-Yates shuffle. I like what the videos covered but didn't particiularly agree with all the refactoring going on. Breaking it down more seems kind of useless, as I think you can explain what the algorithm does using comments instead of a million functions, so I kept it simple and basic.

## Data Structures
In DataStructures.cs I go through using a Hashtable, some classic Array work, and go over the similiarities and differences of a Stack and Queue. My examples seem a bit lacking as I can't find a very good use for Stack but I'm sure one will present itself! I've used Queues before so I have some experience with how they work.

## Searches

### Linear Search
Just loops over the entire array and compares the value at the index to your target. The slowest one with the worse-case being O(n), fastest being O(1).

### Binary Search
Splits the array into smaller chunks to work towards the target faster. Compares the values in the middle of the array with the target and throws out values it knows it doesn't need to search. Must be sorted. Worst case is O(log n) while the best case is O(1).

### Interpolation Search
Basically the same as the Binary Search algorithm but it uses an algorithm IN the algorithm to find a better comparison than the middle of the array. 
The algorithm in question:
```
index = start + ((target - data[start]) * (end - start) / (data[end] - data[start])) 
```
Much fancier. Does have the requirement that it needs to be sorted AND all the values are uniformly distributed. Best case O(log log n), worse case O(n).