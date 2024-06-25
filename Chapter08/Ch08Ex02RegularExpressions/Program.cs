using System.Text.RegularExpressions; // To use [GeneratedRegex]


WriteLine("The default regular expression checks for at least one digit.");
do
{
    Write("Enter a regular expression (or press ENTER to use the default): ");
    string userRegexInput = ReadLine()!;

    if (string.IsNullOrEmpty(userRegexInput))
    {
        userRegexInput = @"\d";
    }

    // Get user text input to run Regex check on
    Write("Enter some input: ");
    string userTextInput = ReadLine()!;

    Regex userRegex = new Regex(userRegexInput);
    WriteLine($"{userTextInput} matches {userRegex.ToString()}: {userRegex.IsMatch(userTextInput)}");

    WriteLine("Press ESC to end or any key to try again");
}
while (ReadKey(intercept: true).Key != ConsoleKey.Escape);
