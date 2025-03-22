namespace lang_features;

public class Strings
{
    public static void Main()
    {
        string name = "someRandomString";
        bool containsA = name.Contains('a');

        bool endsWithG = name.EndsWith('g');
        bool endsWithIng = name.EndsWith("ing");

        bool startsWithSom = name.StartsWith("some");
        
        int indexForRandom = name.IndexOf("Random");
        
        int lastIndexForN = name.LastIndexOf('n');

        // Console.WriteLine(name.Length);

        string substring = name.Substring(1, 3);
        // Console.WriteLine(substring);

        string empty = "";
        string whiteSpaced = "     ";
        string notEmpty = " symbol";
        string nullString = null;

 
        // Console.WriteLine(string.IsNullOrEmpty(empty));
        // Console.WriteLine(string.IsNullOrEmpty(whiteSpaced));
        bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
        // Console.WriteLine(isNullOrEmpty);

        // Console.WriteLine(string.IsNullOrWhiteSpace(whiteSpaced));
        
        string emptyString = string.Empty;

        string concatenatedString = string.Concat(name, notEmpty);
        // Console.WriteLine(concatenatedString);
        
        // Console.WriteLine(name.Insert(3, notEmpty));
        // Console.WriteLine(name);

        // Console.WriteLine(concatenatedString.Remove(5, 7));

        // Console.WriteLine(concatenatedString.Replace("Random", ""));

        string data = "12;38;34;51";

        // Console.WriteLine(data.Split(";")[2]);
        
        char[] chars = name.ToCharArray();
        // Console.WriteLine(name[1]);
        // Console.WriteLine(chars[1]);

        // Console.WriteLine(name.ToLower());
        // Console.WriteLine(name.ToUpper());
        // Console.WriteLine(name.ToUpperInvariant());

        // Console.WriteLine(notEmpty.Trim());
        // Console.WriteLine(notEmpty);
    }
}