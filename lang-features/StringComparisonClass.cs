namespace lang_features;

public class StringComparisonClass
{
    public static void Main()
    {
        string str1 = "abc";
        string str2 = "abc";

        Console.WriteLine(str1 == str2);
        Console.WriteLine(string.Equals(str1, str2, StringComparison.InvariantCultureIgnoreCase));
    }
}