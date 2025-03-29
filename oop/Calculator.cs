namespace oop;

public static class Calculator
{
    public static bool TryDivide(double divisible, double divisor, out double result)
    {
        result = 0;

        if (divisor == 0)
        {
            return false;
        }
        else
        {
            result = divisible / divisor;
            return true;
        }
    }
    
    public static double Average(params int[] numbers)
    {
        double sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return sum / numbers.Length;
    }
    
    public static double GetTriangleSquare(double ab, double ac, double bc)
    {
        double p = (ab + ac + bc) / 2;
        
        return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
    }

    public static double GetTriangleSquare(double b, double h)
    {
        return 0.5 * b * h;
    }

    public static double GetTriangleSquera(double ab, double ac, int alpha, bool isInRadians = false)
    {
        if (isInRadians)
        {
            return 0.5 * ab * ac * Math.Sin(alpha);
        }
        else
        {
            double rads = alpha * Math.PI / 180;
            return 0.5 * ab * ac * Math.Sin(rads);
        }
    }
}