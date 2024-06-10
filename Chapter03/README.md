# Chapter 3 Summary

## Key Concepts

## List Pattern Matching with Arrays
| Example | Description |
|------|-------------------|
| [] | Matches an empty array or collection |
| [..] | Matches an array or collection with any number of items, including 0, so [..] must come after [] if you need to switch on both
| [_] | Matches a list with any single item |
| [int item1] or [var item1] | Matches a list with any single item and can use the value in the return expression by reffering to item1 |
| [7, 2] | Matches exactly a list of two items with those values in that order|
| [_, _] | Matches a list with any two values |
| [var item1, var item2] | Matches a list with any two items and can use the values in the return expression by referring to item1 and item2 |
| [_, _, _] | Matches a list with any three items |
| [var item1, ..] | Matches a list with one or more items, can refer to the value of the first item in its return expression by referring to item1 |
| [var firstItem, .., var lastItem] | Matches a list with two or more items, can refer to the value of the first and last item in its return expression by referring to firstItem and lastItem |
| [.., var lastItem] | Matches a list with one or more items, can refer to the value of the last item in its return expression by referring to lastItem |

## Array Types
| Type of Array | Declaration Syntax |
|------|-------------------|
| One Dimension | datatype[], i.e. string[] |
| Two Dimensions | string[,] |
| Three Dimensions | string[,,] |
| Ten Dimensions | [,,,,,,,,,] |
| Array of arrays aka two-dimensional jagged array | string[][] |
| Array of arrays of arrays aka three-dimensional jagged array | string[][][] |


## Practice Questions


## Projects List


