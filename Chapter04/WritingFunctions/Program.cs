//TimesTable(7, 20);

ConfigureConsole(culture: "fr-FR");

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
Console.WriteLine($"You must pay {taxToPay:C} in tax.");

// Alternatively can call the function in the interpolated string.
// WriteLine($"You must pay {CalculatedTax(amount: 149, twoLetterRegionCode: "FR"):C} in tax.");