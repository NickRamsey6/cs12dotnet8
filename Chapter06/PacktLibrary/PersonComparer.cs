namespace Packt.Shared;

public class PersonComparer : IComparer<Person?>
{
    public int Compare(Person? x, Person? y)
    {
        int position;

        if ((x is not null) && (y is not null))
        {
            if ((x.Name is not null) && (y.Name is not null))
            {
                // If both Name values are not null...

                // ... then compare the Name lengths
                int result = x.Name.Length.CompareTo(y.Name.Length);

                //... and if they are equal...
                if (result == 0)
                {
                    //... then compare them by the names...
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    // ...otherwise compare by the lengths
                    position = result;
                }
            }
            else if ((x.Name is not null) && (y.Name is null))
            {
                position = -1; // x person precedes y person
            }
            else if ((x is null) && (y is not null))
            {
                position = 1; // x person follows y person
            }
            else // x and y are both null
            {
                position = 0; // x and y are at the same position
            }
        }
        else if ((x is not null) && (y is null))
        {
            position = -1; // x person follows y person
        }
        else if ((x is null) && (y is not null))
        {
            position = 1; // x person follows y person
        }
        else // x and y are both null
        {
            position = 0; // x and y are at the same position
        }
        return position;
    }
}
