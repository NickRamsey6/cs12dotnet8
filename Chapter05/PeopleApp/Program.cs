﻿using Packt.Shared; // To use Person
# region Storing data in fields
ConfigureConsole(); // Sets current culture to US English

// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture
// ConfigureConsole(culture: "fr-FR"); // Use French culture

// Person bob = new Person(); // C# 1 or later
// var bob = new Person(); // C# 3 or later

Person bob = new();// C# 9 or later
bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time

// Add Favorite Ancient Wonders for Bob

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

WriteLine(format: "{0} was born on {1:D}.", // D is long date format
    arg0: bob.Name, arg1: bob.Born);
WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

// Add children for Bob
// Works with all versions of C#
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);

// Works with C# 3 or later
bob.Children.Add(new Person { Name = "Bella" });

// Works with C# 9 and later
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

WriteLine("Here are Bob's children displayed using a foreach");
foreach (Person child in bob.Children)
{
    WriteLine($"> {child.Name}");
}


Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    // This is an optional offset from UTC time zone.
    TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.", // d is short date format
    arg0: alice.Name, arg1: alice.Born);

//WriteLine(bob); // Implicit call to ToString()
// WriteLine(bob.ToString()); // Does the same thing
#endregion

#region Making a field static
BankAccount.InterestRate = 0.012M; // Store a shared value in static field.

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine(format: "{0} eared {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate);

#endregion

#region Making a field constant
WriteLine($"{bob.Name} is a {Person.Species}.");
#endregion

#region Making a field read-only
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

#endregion