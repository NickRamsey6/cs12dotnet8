#region Looping with While

int x = 0;
while (x < 10)
{
    Console.WriteLine(x);
    x++;
}

#endregion

#region Looping with Do
string? actualPassword = "Pa$$w0rd";
string? password;

int passwordAttempts = 0;
do
{
    Console.Write("Enter your password: ");
    password = Console.ReadLine();
    passwordAttempts++;
    if (passwordAttempts >= 3 && password != actualPassword)
    {
        Console.WriteLine("You excceeded your pw attempts");
        break;
    }
    if (password == actualPassword)
    {
        Console.WriteLine("Correct!");
    }
}
while (password != actualPassword);



#endregion

#region Looping with For
for (int y = 1; y <= 10; y++)
{
    Console.WriteLine(y);
}

for (int y = 0; y < 10; y+=3)
{
    Console.WriteLine(y);
}

#endregion

#region looping with for each
string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    Console.WriteLine($"{name} has {name.Length} characters.");
}

#endregion