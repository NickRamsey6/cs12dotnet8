using Packt.Shared; // To use Address

int thisCannotBeNull = 4;
//thisCannotBeNull = null; // CS0037 compiler error!
WriteLine(thisCannotBeNull);

int? thisCouldBeNull = null;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

// The actual type of int? is Nullable<int>
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);

Address address = new(city: "London")
{
    Building = null,
    Street = null!, // null-forgiving operator
    Region = "UK"
};

WriteLine(address.Building?.Length);

if (address.Street is not null)
{
    WriteLine(address.Street.Length);
}

// Check that a variable is not null before using it
//if (thisCouldBeNull != null)
//{
//    // Access a member of thisCouldBeNull
//    int length = thisCouldBeNull;
//    ...
//}

// null conditional operator
string authorName = null;
int? authorNameLength;

// The following throws a NullReferenceException
authorNameLength = authorName.Length;

// Instead of throwing an exception, null is assigned
authorNameLength = authorName?.Length;

// Result will be 25 if authorName?.Length is null
authorNameLength = authorName?.Length ?? 25;

