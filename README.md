Author: Giruba Beulah SE

# RemoveDuplicatesFromString
C# program to remove duplicates from a string

Logic/Algorithm:
1. If the input string is null or empty, return the input string - No processing can be done
2. If the input string is not null or empty, do the following

   2.a Convert the input string to a char array.

   2.b Sort the char array
   
   2.c Iterate over the array with two counters, one the loop counter and the other counter to keep track of unique character insertion
   
      2.c.1 Place the current char in the 'other' counter index in the charArray
      2.c.2 While the next element/char is equal to the current element/char, increment loop counter
   
   2.d Return a new string with the char array.
