#region exploring unary operators

int a = 3;
int b = a++; // Postfix operator increments after assignment
WriteLine(($"a is {a} and b is {b}"));

int c = 3;
int d = ++c; // Prefix operator increments before assignment
WriteLine(($"c is {c} and d is {d}"));

#endregion

#region exploring binary operators
int e = 11;
int f = 3;
WriteLine($"e is {e}, f if {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

#endregion

#region exploring assignment operators
int p = 6;
p += 3; // Equivalent to: p = p + 3;
p -= 3; // Equivalent to: p = p - 3;
p *= 3; // Equivalent to: p = p * 3;
p /= 3; // Equivalent to: p = p / 3;
//Test
#endregion

#region null coalescing operators
WriteLine($"Please enter an author name: ");
string? authorName = ReadLine(); // Prompt user to enter an author name.

// The maxLength variable will be the length of authorName if it is not null or 30 if authorName is null
int maxLength = authorName?.Length ?? 30;

// The authorName variable will be "unknown" if authorName was null
authorName ??= "unknown";
WriteLine($"The author's name is {authorName}.");
#endregion

#region Exploring logical operators
bool t = true;
bool z = false;

WriteLine($"AND  | t     | z    ");
WriteLine($"t    | {t & t,-5} | {t & z,-5} ");
WriteLine($"z    | {z & t,-5} | {z & z,-5} ");
WriteLine();
WriteLine($"OR   | t     | z    ");
WriteLine($"t    | {t | t,-5} | {t | z,-5} ");
WriteLine($"z    | {z | t,-5} | {z | z,-5} ");
WriteLine();
WriteLine($"XOR  | t     | z    ");
WriteLine($"t    | {t ^ t,-5} | {t ^ z,-5} ");
WriteLine($"z    | {z ^ t,-5} | {z ^ z,-5} ");

#endregion

#region Exploring conditional logical operators
WriteLine();
// Note that DoStuff will return true
WriteLine($"t & DoStuff() = {t & DoStuff()}");
WriteLine($"z & DoStuff() = {z & DoStuff()}");

WriteLine();
// Note that DoStuff will return true
WriteLine($"t && DoStuff() = {t && DoStuff()}");
WriteLine($"z && DoStuff() = {z && DoStuff()}");
#endregion

#region Exploring bitwise and binary shift operators
WriteLine();

int x = 10;
int y = 6;

WriteLine($"Expression | Decimal |   Binary");
WriteLine($"-------------------------------");
// B:8 means format in binary with 8 digits
WriteLine($"x          |  {x,7} | {x:B8}");
WriteLine($"y          |  {y,7} | {x:B8}");
WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");

#endregion

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}