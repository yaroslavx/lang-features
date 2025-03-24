namespace lang_features;

public class Casting
{
    public static void Main()
    {
        byte numberByte = 3; // 0000 0011
        int numberInt = numberByte; // 0000 0000 0000 0000 0000 0000 0000 0011
        long numberLong = numberInt; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011
        float numberFloat = numberInt; // 3.0

        numberByte = (byte)numberInt;

        numberInt = (int)numberFloat;

        numberFloat = 3.1f;
        numberInt = (int)numberFloat;
        // Console.WriteLine(bInt);
        
        string stringString = "3";
        
        // Console.WriteLine(long.Parse(stringString));

        int x = 5;
        int y = 2;
        double res = (double)x / y;
        Console.WriteLine(res);
    }
}