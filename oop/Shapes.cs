namespace oop;

public abstract class Shape
{
    public Shape()
    {
        Console.WriteLine("Shape created");
    }
    
    public abstract void Draw();

    public abstract double Area();
    
    public abstract double Perimeter();
}

public class Rectangle : Shape
{
    private readonly double _width;
    private readonly double _length;

    public Rectangle(double width, double length)
    {
        _width = width;
        _length = length;

        Console.WriteLine("Rectangle created");
    }


    public override void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }

    public override double Area()
    {
        return _width * _length;
    }

    public override double Perimeter()
    {
        return 2 * (_width + _length);
    }
}

public class Triangle : Shape
{
    private readonly double _ab;
    private readonly double _bc;
    private readonly double _ac;


    public Triangle(double ab, double bc, double ac)
    {
        _ab = ab;
        _bc = bc;
        _ac = ac;
        
        Console.WriteLine("Triangle created");
    }
    
    public override void Draw()
    {
        Console.WriteLine("Drawing triangle");
    }

    public override double Area()
    {
        double s = (_ab + _bc + _ac) / 2;
        return Math.Sqrt(s * (s - _ab) * (s - _bc) * (s - _ac));
    }

    public override double Perimeter()
    {
        return _ab + _bc + _ac;
    }
}