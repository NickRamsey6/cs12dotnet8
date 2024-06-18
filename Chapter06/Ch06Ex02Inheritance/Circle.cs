namespace Packt.Shared;

public class Circle : Shape
{
    public Circle() { }

    public Circle(double radius)
    {
        this.Width = radius * 2;
        this.Height = radius * 2;
    }
}