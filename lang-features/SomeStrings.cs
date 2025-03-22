namespace lang_features;

public class SomeStrings
{
    public static void Main()
    {
        string name = "randomName";
        string name1 = new string("randomName1");

        bool isContains = name.Contains("randomName");

        string abs = string.Concat(name, name1);

        int x = 1;
        string strX = x.ToString();

        Console.WriteLine(strX);
    }
}