Console.WriteLine("Enter a number between 0 and 255:");
// Using the null forgiving operator "!" at the end of the input to disable the compier warning
// I think it's impossible to give a truly null value because the user has to input even just a return in the console
string firstNum = Console.ReadLine()!;
Console.WriteLine("Enter another number between 0 and 255:");
string secondNum = Console.ReadLine()!;

try
{
    // Parsing the inputs to bytes because byte has a max value of 255
    byte numOne = byte.Parse(firstNum!);
    byte numTwo = byte.Parse(secondNum!);
    int answer = numOne / numTwo;
    Console.WriteLine($"{firstNum} divided by {secondNum} is {answer}");
}
// Starting with most specific exceptions and working our way down to the catch all
// Specifically catching the first two because they are common/expected and this way we can give a more accurate error message
catch (OverflowException)
{
    Console.WriteLine("The number you entered was a valid format but either too big or too small.");
}
catch (FormatException)
{
    Console.WriteLine("Input string was not in a correct format.");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}