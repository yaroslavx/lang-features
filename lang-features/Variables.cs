namespace lang_features;

public class Variables
{
    public static void Main()
    {
        int x = -1;

        int y;
        y = 2;

        double f = 2.3;

        int x2 = 0;
        int x3 = new int();

        var a = 1;
        var b = 1.2;

        // Dictionary<int, string> dict = new Dictionary<int, string>();
        var dict = new Dictionary<int, string>();

        // const string v = "string";

        decimal money = 3.0m;

        char character = 'A';
        string name = "Name";

        bool isValid = false;
        bool isNotValid = true;

        object obj = 1;
        object obj1 = "string";

        Console.WriteLine(obj1);
    }
}