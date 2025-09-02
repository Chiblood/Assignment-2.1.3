public class Square : Shape
{
    public double Side { get; set; }

    public Square(int id, string name, string color, double side) : base(id, name, color)
    {
        Side = side;
    }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}