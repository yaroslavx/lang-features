namespace lang_features;

public class IncDec
{
    public static void Main()
    {
        int x = 1;
        x = x + 1;
        x++;
        ++x;
        x--;
        --x;

        int j = x++;
        j = ++x;

        x += 2;
        j -= 2;
    }
}