# Chapter 8 Summary

## Key Concepts

## Common .NET Number Types
| Namespace | Example Type(s) | Description |
|-----------|-----------------|-------------|
| System | SByte, Int16, Int32, Int64, Int128 | Integers: 0 and positive and negative whole numbers. |
| System | Byte, UInt16, UInt32, UInt64, UInt128 | Cardinals: 0 and positive whole numbers. |
| System | Half, Single, Double | Reals: Floating-point numbers. |
| System | Decimal | Accurate reals: Used in science, engineering or financials. |
| System.Numerics | BigInteger, Complex, Quarternion | Arbitrarily large integers, complex numbers and quaterion numbers. |

## Common .NET Text Types
| Namespace | Type | Description |
|-----------|-----------------|-------------|
| System | Char | Storage for a single text character |
| System | String | Storage for multiple text characters |
| System.Text | StringBuilder | Efficiently manipulates strings |
| System.Text.RegularExpressions | Regex | Efficiently pattern-matches strings |

## String Members
| Member | Description |
|--------|-------------|
| Trim, TrimStart, TrimEnd | These methods trim whitespace characters such as space, tab, and carriage return from the start and/or end. |
| ToUpper, ToLower | These convert all the characters into uppercase or lowercase. | 
| Insert, Remove | These methods insert or remove some text. |
| Replace | This replaces some text with other text. |
| string.Empty | This can be used instead of allocating memory each time you use a literal string value using an empty pair of double quotes (""). |
| string.Concat | This concatenates two string variables. The + operator does the equivalent when used between string operands. |
| string.Join | This concatenates one or more string variables with a character in between each one. |
| string.IsNullOrEmpty | This checks whether a string variable is null or empty. |
| string.IsNullOrWhiteSpace | This checks whether a string variable is null or whitespace; that is a mix of any number of horizontal and vertical spacing characters, for example, tab, space, carriage return, line feed, and so on. |
| string.Format | An alternative method to string interpolation for outputting formatted string values, which uses positioned instead of named parameters. |

## Projects List
* WorkingWithNumbers
* WorkingWithText

## Practice Questions
 
## My takeaways / Questions / Notes