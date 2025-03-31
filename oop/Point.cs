namespace oop;

public readonly struct Point
{
    public double X { get; }
    public double Y { get; }
    public double Distance { get; }

    
    public Point(double x, double y) => (X, Y, Distance) = (x, y, Math.Sqrt(x * x + y * y));

    public static bool operator ==(Point left, Point right) =>
        (left.X, left.Y) == (right.X, right.Y);
    
    public static bool operator !=(Point left, Point right) =>
        (left.X, left.Y) != (right.X, right.Y);

    public override bool Equals(object obj)
        =>  obj is Point otherPoint && this == otherPoint;
}