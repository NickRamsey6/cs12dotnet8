namespace Packt.Shared;

public class Square : Shape
{
    public Square() { }

    public Square(double side)
    {
        this.Width = side;
        this.Height = side;
    }
}