using System.Globalization; // To use CultureInfo
using static System.Convert; // To use the ToInt32 method

#region casting numbers implicitly and explicitly
int a = 10;
double b = a; // An int can be safely cast into a double
Console.WriteLine($" as is {a} and b is {b}");

double c = 9.8;
int d = (int)c; // Compiler gives an error if you do not explicitly cast
Console.WriteLine($"c is {c}, d is {d}");

long e = 10;
int f = (int)e;
Console.WriteLine($"e is {e:N0}, f is {f:N0}");

e = 5_000_000_000;
f = (int)e; // 5 billion can not fit into a 32-bit integer so it overflows
Console.WriteLine($"e is {e:N0}, f is {f:N0}");

#endregion

#region

Console.WriteLine("{0, 12} {1, 34}", "Decimal", "Binary");
Console.WriteLine("{0, 12} {0, 34:B32}", int.MaxValue);
for (int i = 8; i >= -8; i--)
{
    Console.WriteLine("{0,12}, {0,34:B32}", i);
}
Console.WriteLine("{0, 12} {0,34:B32}", int.MinValue);

#endregion

#region Converting with System.Convert type
double g = 9.8;
int h = ToInt32(g); // A method of System.Convert
Console.WriteLine($"g is {g}, h is {h}");

#endregion

#region Rounding numbers and the default rounding rules
double[,] doubles =
{
    { 9.49, 9.5, 9.51 },
    { 10.49, 10.5, 10.51 },
    { 11.49, 11.5, 11.51 },
    { 12.49, 12.5, 12.51 },
    { -12.49, -12.5, -12.51 },
    { -11.49, -11.5, -11.51 },
    { -10.49, -10.5, -10.51 },
    { -9.49, -9.5, -9.51 }
};

Console.WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
for (int x = 0; x < 8; x++)
{
    for (int y = 0; y < 3; y++)
    {
        Console.WriteLine($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]),7}");
    }
    Console.WriteLine("|");
}
Console.WriteLine();

#endregion

#region Taking control of rounding rules
foreach (double n in doubles)
{
    Console.WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0,
                   mode: MidpointRounding.AwayFromZero));
}

#endregion

#region
// Any object passed to the Console.WriteLine method implicitly converts to a sting
// So technically unneccesary here
int number = 12;
Console.WriteLine(number.ToString());
bool boolean = true;
Console.WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
Console.WriteLine(now.ToString());
object me = new();
Console.WriteLine(me.ToString());

#endregion

#region Converting from a binary object to a string
// Allocate an array of 128 bytes
byte[] binaryObject = new byte[128];

// Populate the array with random bytes
Random.Shared.NextBytes(binaryObject);

Console.WriteLine("Binary Object as bytes: ");
for (int index = 0; index < binaryObject.Length; index++)
{
    Console.WriteLine($"{binaryObject[index]:X2}");
}
Console.WriteLine();

// Convert the array to Base64 string and output as text
string encoded = ToBase64String(binaryObject);
Console.WriteLine($"Binary Object as Base64: {encoded}");

#endregion

#region Parsing from strings to numbers or date and times
// Set current culture to make sure date parsing works
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int friends = int.Parse("27");
DateTime birthday = DateTime.Parse("4 June 1980");
Console.WriteLine($"I have {friends} friends to invite to my party.");
Console.WriteLine($"My birthday is {birthday}.");
Console.WriteLine($"My birthday is {birthday:D}.");

#endregion

#region Avoiding Parse exceptions by using the TryParse method
Console.WriteLine("How many eggs are there?");
string? input = Console.ReadLine();

if (int.TryParse(input, out int count))
{
    Console.WriteLine($"There are {count} eggs.");
}
else
{
    Console.WriteLine("I could not parse the input.");
}

#endregion