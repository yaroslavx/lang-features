namespace lang_features;

public class MathClass
{
    public static void Main()
    {
        // Console.WriteLine(Math.Pow(2, 8));
        // Console.WriteLine(Math.Sqrt(28));
        // Console.WriteLine(Math.Round(2.8));
        // Console.WriteLine(Math.Round(2.3));
        // Console.WriteLine(Math.Round(2.5));
        Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero));
        Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven));
    }
}