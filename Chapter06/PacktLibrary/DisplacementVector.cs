namespace Packt.Shared;

// Type is declared as struct instead of class
public record struct DisplacementVector
{
    // two int properties, named X and Y, that will auto-generate two private fields with the same data type, which will be allocated on the stack
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor to set the initial values of X and Y
    public DisplacementVector(int initialX, int initialY)
    {
        X = initialX;
        Y = initialY;
    }

    // Operator to add two instances together that returns a new instance 
    public static DisplacementVector operator +(
        DisplacementVector vector1,
        DisplacementVector vector2)

    {
        return new(
            vector1.X + vector2.X,
            vector1.Y + vector2.Y);
    }
}