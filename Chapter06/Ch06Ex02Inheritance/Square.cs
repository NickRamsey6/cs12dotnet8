namespace Packt.Shared;

public class Square : Shape
{
    public Square() { }

    public Square(double side)
    {
        this.Width = side;
        this.Height = side;
    }

    public new void FindArea(Square sq1)
    {
        //sq1.Area = sq1.Height * sq1.Height;
        sq1.Area = sq1.Height * sq1.Height;
    }
}