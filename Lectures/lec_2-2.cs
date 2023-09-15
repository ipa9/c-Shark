var point = new Point();
var distance = point.DistanceFromCenter();
Console.WriteLine(distance);

public struct Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point (double x, double y)
    {
        this.X = x;
        this.Y = y;
    }

    public double DistanceFromCenter()
    {
        return Math.Sqrt(X*X + Y*Y);
    }
}
