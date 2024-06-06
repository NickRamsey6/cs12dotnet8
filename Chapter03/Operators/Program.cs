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
WriteLine($"e * f = {e *  f}");
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

#region exploring logical operators - DOES NOT WORK
bool p = true;
bool q = false;
//WriteLine($"AND  | p     | q    ");
//WriteLine($"p    | {p & p,-5} | {p & q,-5} ");
//WriteLine($"q    | {q & p,-5} | {q & q,-5} ");
//WriteLine();
//WriteLine($"OR   | p     | q    ");
//WriteLine($"p    | {p | p,-5} | {p | q,-5} ");
//WriteLine($"q    | {q | p,-5} | {q | q,-5} ");
//WriteLine();
//WriteLine($"XOR  | p     | q    ");
//WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5} ");
//WriteLine($"q    | {q ^ p,-5} | {q ^ q,-5} ");
//WriteLine();

#endregion

#region Exploring conditional logical operators


WriteLine();
// Note that DoStuff() returns true
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

#endregion

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;

}