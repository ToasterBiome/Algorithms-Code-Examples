
# Algorithms Code Examples
This is to document my progress in Algorithms. I learned a lot of fundamentals not just within C# but within programming as a whole. Here are some of the things I've learned:


## Notation Examples
Contained within ```NotationExamples.cs```.
Within NotationExamples.cs there are examples of O(1), O(n) and O(n^2) Big O notation. I did my best to explain how they fit that notation even if the solutions are intentionally terrible for examples' sake.

## Fisher-Yates Shuffle Example
Contained within ```/FisherYatesShuffle```.
In the subfolder you'll find a code example for a pretty ordinary Fisher-Yates shuffle. I like what the videos covered but didn't particiularly agree with all the refactoring going on. Breaking it down more seems kind of useless, as I think you can explain what the algorithm does using comments instead of a million functions, so I kept it simple and basic.

## Data Structures Examples
Contained within ```DataStructures.cs```.
In the file I go through using a Hashtable, some classic Array work, and go over the similiarities and differences of a Stack and Queue. My examples seem a bit lacking as I can't find a very good use for Stack but I'm sure one will present itself! I've used Queues before so I have some experience with how they work.

## Search Examples
Contained within ```Searches.cs```.

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

## Tree Examples
Contained within ```TreeExamples.cs```.
For trees I worked off of a directed acyclic graph example that we were given, i've rewritten the code in my own style and walked through with breakpoints to truly understand how it worked. I didn't really understand how it was recursive but I figured it out when the ```currentNode``` kept changing. Very interesting stuff.

### Node
The ```Node``` class contains a char (which is it's 'value') and a ```List<Node>``` of it's children. I like lists because they are simple in their design and easy to understand, I didn't think  I needed to use a dictionary for this example although it may be way slower. It contains the methods ```Add(char val)``` and ```Get(char val)``` to both be able to recursively add children to it in the ```RootNode``` and to peek at the value to traverse the tree.

### RootNode
The starting point or *root* of the tree. It contains the functions for adding a string to the tree and checking if the string is contained within the tree using ```AddChildren(string childWord)``` and ```ContainsChildren(string childWord)```. It uses the functions of ```Add(char val)``` and ```Get(char val)``` within the ```Node``` class to recursively traverse the tree.