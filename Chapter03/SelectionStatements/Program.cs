string password = "ninja";

if (password.Length < 8)
{
    Console.WriteLine("Your password is too short. Use at least 8 chars.");
}
else
{
    Console.WriteLine("Your password is strong");
}

// Add and remove the "" to change between string and int.
object o = 3;
int j = 4;

if (o is int i)
{
    Console.WriteLine($"{i} x {j} = {i * j}");
}
else
{
    Console.WriteLine("o is not an int so it cannot multiply!");
}

// Inclusive lower bound but exclusive upper bound
int number = Random.Shared.Next(minValue: 1, maxValue: 7);
Console.WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        Console.WriteLine("One");
        break; // Jumps to end of switch statement
    case 2:
        Console.WriteLine("Two");
        goto case 1;
    case 3: //multiple case section
    case 4:
        Console.WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        Console.WriteLine("Default");
        break;
} // end of switch statement
Console.WriteLine("After end of switch");
A_label:
Console.WriteLine($"After A_label");

// This array can contain any subtype of Animal or a null value
var animals = new Animal?[]
{
    new Cat { Name = "Tom", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true },
    null,
    new Cat { Name = "Sylvester", Born = new(year: 1994, month: 6, day: 12) },
    new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true},
    new Spider { Name = "Peter Parker", Born = DateTime.Today}
};

foreach (Animal? animal in animals)
{
    string message;

    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;
        case Cat wildCat when wildCat.IsDomestic == false:
            message = $"The non-domestic cast is named {wildCat.Name}.";
            break;
        case Cat cat:
            message = $"The cat is named {cat.Name}";
            break;
        default: // default is always evaluated last
            message = $"{animal.Name} is a {animal.GetType().Name}";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The {spider.Name} spider is poisonous. RUN!";
            break;
        case null:
            message = "The animal is null.";
            break;
    }
    Console.WriteLine($"switch statement: {message}");

    message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
            => $"The cat named {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.IsDomestic == false
            => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
            => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsPoisonous
            => $"The {spider.Name} spider is poisonous. RUN!",
        null
            => "The animal is null.",
        _
            => $"{animal.Name} is a {animal.GetType().Name}."
    };
    Console.WriteLine($"switch expression: {message}");
}