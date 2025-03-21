namespace lang_features;

public class Overflow
{
    public static void Main()
    {
        checked
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);

            x += 1;

            Console.WriteLine(x);

            x -= 1;

            Console.WriteLine(x);
        }
    }
}