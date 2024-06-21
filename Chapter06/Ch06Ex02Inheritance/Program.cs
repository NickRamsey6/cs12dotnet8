using Packt.Shared;

Rectangle r = new(3, 4.5);
Console.WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}.");

Square s = new(5);
Console.WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area}");

Circle c = new(radius: 2.5);
Console.WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}");

Shape sh = r;
Console.WriteLine($"Shape H:{sh.Height}, W:{sh.Width},A: {sh.Area}");