namespace lang_features;

public class SomeMathOperations
{
    public static void Main()
    {
        int x = 1;
        int y = 2;

        int z = x + y;
        int k = x - y;
        int a = z + k - x;

        int b = z * 2;
        int c = k / 2;

        a = 4 % 2;
        b = 5 % 2;

        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");

        a = 2;
        a = a * a;
        a = a ^ 3;

        Console.WriteLine($"a: {a}");
    }
}