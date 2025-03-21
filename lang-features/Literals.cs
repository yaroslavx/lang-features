namespace lang_features;

public class Literals
{
    public static void Main()
    {
        int x = 0b11;
        int y = 0b1001;
        int k = 0b10001001;
        int m = 0b1001_0010;

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(k);
        Console.WriteLine(m);

        x = 0x1F;
        y = 0xFF0D;
        k = 0x1FAB30FF;
        m = 0x1FAB_30FF;

        Console.WriteLine();

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(k);
        Console.WriteLine(m);

        Console.WriteLine();

        Console.WriteLine(4.5e2);
        Console.WriteLine(4.5E-1);

        Console.WriteLine();

        Console.WriteLine('\x78');
        Console.WriteLine('\x5A');
        Console.WriteLine('\u004F');
    }
}