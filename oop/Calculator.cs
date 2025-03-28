namespace oop;

public class Calculator
{
    public double GetTriangleSquare(double ab, double ac, double bc)
    {
        double p = (ab + ac + bc) / 2;
        
        return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
    }

    public double GetTriangleSquare(double b, double h)
    {
        return 0.5 * b * h;
    }
}