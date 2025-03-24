namespace lang_features;

public class Arrays
{
    public static void Main()
    {
        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];

        int[] a3 = {1, 2, 3};

        Console.WriteLine(a3.Length);
        Console.WriteLine(a3[^1]);
    }
}