namespace Packt.Shared;

public class Square : Shape
{
    // Define Square-specific properties
    private double Side { get; set; }

    // Constructor to set paramter to accept side only
    public Square(double side)
    {
        // Set the inherited fields w and h with the provided parameter
        // Also set the Sqaure-Only Side field
        Width = side;
        Height = side;
        Side = side;
    }

    // Override Area field from Shape class, with Square-specific calculation
    public override double Area
    {
        get
        {
            // Math.Pow is a power of function
            // Area = s ^ 2
            return Math.Pow(Side, 2);
        }
    }
}