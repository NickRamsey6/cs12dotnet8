#region Wrapping error-prone code in a try block
Console.WriteLine("Before parsing");
Console.WriteLine("What is your age?");
string? input = Console.ReadLine();

if (input is null)
{
    Console.WriteLine("You did not enter a value so the app has ended.");
    return;
}

try
{
    int age = int.Parse(input!);
    Console.WriteLine($"You are {age} years old.");
}
// Catch specific exceptions
catch (OverflowException)
{
    Console.WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
    Console.WriteLine("The age you entered is not a valid number format.");
}
// Catching all exceptions
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}

Console.WriteLine("After parsing");
#endregion

#region Catching with filters
Console.WriteLine("Enter an amount: ");
string amount = Console.ReadLine()!;
if (string.IsNullOrEmpty(amount)) return;

try
{
    decimal amountValue = decimal.Parse(amount);
    Console.WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
    Console.WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    Console.WriteLine("Amounts must only contain digits!");
}

//#endregion

#region Throwing overflow exceptions with the checked statements
// Can use the checked statement to throw exception for overflow
checked
{
    int x = int.MaxValue - 1;
    Console.WriteLine($"Initial value: {x}");
    x++;
    Console.WriteLine($"Atfer incrementing: {x}");
    x++;
    Console.WriteLine($"After incrementing: {x}");
    x++;
    Console.WriteLine($"After incrementing: {x}");
}

// Can also use a typical try catch block
try
{
    checked
    {
        int x = int.MaxValue - 1;
        Console.WriteLine($"Initial value: {x}");
        x++;
        Console.WriteLine($"Atfer incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
    }
    
}
catch (OverflowException)
{
    Console.WriteLine("The code overflowed but I caught the exception.");
}

#endregion

#region Disabling compiler overflow checks with the unchecked statement
unchecked
{
    int y = int.MaxValue + 1;
    Console.WriteLine($"Intial value: {y}");
    y--;
    Console.WriteLine($"After decerementing: {y}");
    y--;
    Console.WriteLine($"After decrementing: {y}");
}


#endregion

double t = 6;
double ans = t / 0;
Console.WriteLine($"{ans}");

for (; ; );